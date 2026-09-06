using System;
using System.IO;
using System.Speech.Synthesis;
using System.Text;
using System.Windows.Forms;

namespace _4_Column_Shopping_List
{
    public partial class Form1 : Form
    {
            private enum ListCategory
        {
            Breakfast = 0,
            Lunch = 1,
            Dinner = 2,
            Extras = 3,
            EntireList = 4
        }


        private SpeechSynthesizer speechSynthesizer;
        public static string AppDirectory = Path.Combine(
            Environment.GetEnvironmentVariable("onedriveconsumer") ?? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "documents", "4-Column Shopping List");  //application directory
        public static string SelectedFile = Path.Combine(AppDirectory, "Shopping List.txt"); //output order list file

        #region form1 loading and closingpublic Form1()
        public Form1()
        {
            InitializeComponent();

            Directory.CreateDirectory(AppDirectory); //ensure application directory exists
            // Initialize reusable synthesizer once to avoid repeated allocations.
            speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Rate = 3; // set a faster speaking rate
            speechSynthesizer.Volume = 100; // set max volume
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
                speechSynthesizer?.SpeakAsyncCancelAll();
                speechSynthesizer?.Dispose();
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
                MessageBox.Show(this, $"Failed to save file: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                speechSynthesizer.SpeakAsyncCancelAll(); // Cancel any ongoing speech
                speechSynthesizer.SpeakAsync(speechText);
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
                MessageBox.Show("Please select an item to delete.", "No Item Selected", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to create a new list? This will clear all current items.", "Confirm New List", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Save();
                MessageBox.Show("The previous list has been saved.\r\n\r\nThe list is located in the Documents folder, which will be overwritten when you add the first item.", "New List", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
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
            //future aboutbox implementation from ShadowFlame Class Library.
        }

        private void viewListFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //future View Report implementation from ShadowFlame Class Library.
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