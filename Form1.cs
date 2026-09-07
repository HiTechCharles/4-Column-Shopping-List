using System;
using System.IO;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;
using ShadowFlame;

namespace _4_Column_Shopping_List
{
    public partial class Form1 : Form
    {
        #region Constants and fields
        private const string About_Title = "4-Column Shopping List";
        private const string About_CompanyText = "HiTechCharles\r\n4-Column Shopping List\r\n\r\nV4.9, developed using C# via Visual Studio 2026";
        private const string About_HelpText = "This application allows you to create a shopping list divided into four categories: Breakfast, Lunch, Dinner, and Extras. \r\n\r\nYou can add items to each category, delete selected items, and have the list read aloud using text-to-speech functionality.\r\n\r\nThe list is saved automatically when items are added or removed.  The view List option allows viewing of the entire list. ";

        private enum ListCategory
        {
            Breakfast = 0,
            Lunch = 1,
            Dinner = 2,
            Extras = 3,
            EntireList = 4
        }
        public static string AppDirectory = Path.Combine(
            Environment.GetEnvironmentVariable("onedriveconsumer") ?? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "documents", "4-Column Shopping List");  //application directory
        public static string SelectedFile = Path.Combine(AppDirectory, "Shopping List.txt"); //output order list file
        public static string TTSSettings = Path.Combine(AppDirectory, "TTS_Settings.txt");

        #endregion

        #region form1 loading and closingpublic Form1()
        public Form1()
        {
            InitializeComponent();
            this.Font = GlobalFontService.Instance.CurrentFont;
            MainMenuMST.Font = GlobalFontService.Instance.CurrentFont;
            Directory.CreateDirectory(AppDirectory); //ensure application directory exists

            //if no speech settings file exists, launch the TTS setup form
            if (!File.Exists(TTSSettings))
            {
                TTSSetup TTS = new TTSSetup();
                TTS.ShowDialog();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // initialize counts on load (in case designer set items)
            UpdateCount(BreakfastListLB, BreakfastItemCountTB);
            UpdateCount(LunchListLB, LunchItemCountTB);
            UpdateCount(DinnerListLB, DinnerItemCountTB);
            UpdateCount(ExtrasListLB, ExtrasItemCountTB);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            try
            {
                ShadowFlame.WindowsTTS.Stop();
                Save(); // Save the list on form closing
            }
            catch
            {
                // swallow disposal exceptions to avoid blocking shutdown
            }
        }
        #endregion

        #region Helper Methods

        private void UpdateCount(ListBox listBox, TextBox countTextBox)
        {
            var count = listBox.Items.Count;
            countTextBox.Text = $"{count} Item{(count == 1 ? "" : "s")}";
        }

        private void AddItemFromEntry(TextBox entry, ListBox listBox, TextBox countTextBox, string categoryLabel)
        {
            var text = entry.Text?.Trim();
            if (string.IsNullOrEmpty(text) || text.Length < 2)
                return;

            listBox.Items.Add(text);
            entry.Clear();
            entry.Focus();
            UpdateCount(listBox, countTextBox);
            Save(); // Save the list after adding an item
        }

        private void DeleteSelectedItem(ListBox listBox, TextBox countTextBox, string categoryLabel)
        {
            if (listBox.SelectedIndex <= -1)
                return;

            var removed = listBox.SelectedItem?.ToString();
            listBox.Items.RemoveAt(listBox.SelectedIndex);
            UpdateCount(listBox, countTextBox);
            Save(); // Save the list after deleting an item
        }

        private void BuildSpeechText(StringBuilder sb, ListBox listBox, string categoryName)
        {
            if (listBox.Items.Count > 0)
            {
                sb.AppendFormat("You have {0} {1} {2} as follows. ",
                    listBox.Items.Count,
                    categoryName,
                    listBox.Items.Count == 1 ? "item" : "items");
                foreach (var item in listBox.Items)
                    sb.Append(item).Append(". ");
            }
            else
            {
                sb.AppendFormat("There are no items in the {0} list.  ", categoryName.ToLower());
            }
        }

        private void Save()
        {
            try
            {
                using (var writer = new StreamWriter(SelectedFile, false, Encoding.UTF8))
                {
                    writer.WriteLine("4-COLUMN SHOPPING LIST");
                    writer.WriteLine(DateTime.Now.ToLongDateString());
                    writer.WriteLine();
                    writer.WriteLine("BREAKFAST - " + BreakfastItemCountTB.Text);
                    foreach (var item in BreakfastListLB.Items)
                        writer.WriteLine("    " + item);
                    writer.WriteLine();

                    writer.WriteLine("LUNCH - " + LunchItemCountTB.Text);
                    foreach (var item in LunchListLB.Items)
                        writer.WriteLine("    " + item);
                    writer.WriteLine();

                    writer.WriteLine("DINNER - " + DinnerItemCountTB.Text);
                    foreach (var item in DinnerListLB.Items)
                        writer.WriteLine("    " + item);
                    writer.WriteLine();

                    writer.WriteLine("EXTRAS - " + ExtrasItemCountTB.Text);
                    foreach (var item in ExtrasListLB.Items)
                        writer.WriteLine("    " + item);
                    writer.WriteLine();
                }
            }
            catch (Exception ex)
            {
                DisplayMessage.ShowError($"Failed to save file: {ex.Message}", "Save Error");
            }
        }

        private void SpeakCategory(ListCategory category)
        {
            var sb = new StringBuilder();
            switch (category)
            {
                case ListCategory.Breakfast:
                    BuildSpeechText(sb, BreakfastListLB, "Breakfast");
                    break;
                case ListCategory.Lunch:
                    BuildSpeechText(sb, LunchListLB, "Lunch");
                    break;
                case ListCategory.Dinner:
                    BuildSpeechText(sb, DinnerListLB, "Dinner");
                    break;
                case ListCategory.Extras:
                    BuildSpeechText(sb, ExtrasListLB, "Extras");
                    break;
                case ListCategory.EntireList:
                    BuildSpeechText(sb, BreakfastListLB, "Breakfast");
                    BuildSpeechText(sb, LunchListLB, "Lunch");
                    BuildSpeechText(sb, DinnerListLB, "Dinner");
                    BuildSpeechText(sb, ExtrasListLB, "Extras");
                    break;
            }
            var speechText = sb.ToString();
            if (!string.IsNullOrWhiteSpace(speechText))
            {
                ShadowFlame.WindowsTTS.Speak(speechText);
            }
        }
        #endregion

        #region KEYDOWN EVENTS

        private void BreakfastEntryTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddItemFromEntry(BreakfastEntryTB, BreakfastListLB, BreakfastItemCountTB, "Breakfast");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void LunchEntryTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddItemFromEntry(LunchEntryTB, LunchListLB, LunchItemCountTB, "Lunch");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void DinnerEntryTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddItemFromEntry(DinnerEntryTB, DinnerListLB, DinnerItemCountTB, "Dinner");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void ExtrasEntryTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AddItemFromEntry(ExtrasEntryTB, ExtrasListLB, ExtrasItemCountTB, "Extras");
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        #endregion

        #region Menu Item Click Handlers
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        
        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Determine which list box has focus and delete the selected item
            if (BreakfastListLB.Focused)
            {
                DeleteSelectedItem(BreakfastListLB, BreakfastItemCountTB, "Breakfast");
            }
            else if (LunchListLB.Focused)
            {
                DeleteSelectedItem(LunchListLB, LunchItemCountTB, "Lunch");
            }
            else if (DinnerListLB.Focused)
            {
                DeleteSelectedItem(DinnerListLB, DinnerItemCountTB, "Dinner");
            }
            else if (ExtrasListLB.Focused)
            {
                DeleteSelectedItem(ExtrasListLB, ExtrasItemCountTB, "Extras");
            } else {
                // Handle the case where no list box has focus
                DisplayMessage.ShowInfo("Please select an item to delete.", "No Item Selected");
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool result = DisplayMessage.GetConfirmation("Are you sure you want to create a new list? This will clear all current items.", "Confirm New List");
            
            if (result)
            {
                Save();
                DisplayMessage.ShowInfo("The previous list has been saved.\r\n\r\nThe list is located in the Documents folder, which will be overwritten when you add the first item.", "New List");  
                        
                // Clear all list boxes and item counts
                BreakfastListLB.Items.Clear();
                LunchListLB.Items.Clear();
                DinnerListLB.Items.Clear();
                ExtrasListLB.Items.Clear();
                UpdateCount(BreakfastListLB, BreakfastItemCountTB);
                UpdateCount(LunchListLB, LunchItemCountTB);
                UpdateCount(DinnerListLB, DinnerItemCountTB);
                UpdateCount(ExtrasListLB, ExtrasItemCountTB);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShadowFlame.AboutForm AF = new ShadowFlame.AboutForm(About_Title, About_CompanyText, About_HelpText);
            AF.ShowDialog();
        }

        private void viewListFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShadowFlame.ViewReport VR = new ViewReport("View 4-Column Shopping List", SelectedFile, null);
            System.Threading.Tasks.Task.Delay(100).Wait(); // slight delay to ensure file is ready
            VR.ShowDialog();
        }
        

        private void breakfastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeakCategory(ListCategory.Breakfast);
        }

        private void lunchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeakCategory(ListCategory.Lunch);
        }

        private void dinnerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeakCategory(ListCategory.Dinner);
        }

        private void extrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeakCategory(ListCategory.Extras);
        }

        private void everythingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SpeakCategory(ListCategory.EntireList);
        }
        #endregion
    }
}