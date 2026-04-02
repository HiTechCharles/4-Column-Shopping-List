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
            Extras = 3
        }

        private SpeechSynthesizer speechSynthesizer;
        public static string AppDirectory = Path.Combine(
            Environment.GetEnvironmentVariable("onedriveconsumer") ?? Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "documents", "4-Column Shopping List");  //application directory
        public static string SelectedFile = Path.Combine(AppDirectory, "Shopping List.txt"); //output order list file

        public Form1()
        {
            InitializeComponent();

            Directory.CreateDirectory(AppDirectory); //ensure application directory exists
            // Initialize reusable synthesizer once to avoid repeated allocations.
            speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.Rate = 3; // set a faster speaking rate
            speechSynthesizer.Volume = 100; // set max volume
        }

        #region Helper Methods

        private void UpdateStatus(string text)
        {
            StatusTB.Text = text;
        }

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
            UpdateStatus($"Added {categoryLabel} Item '{text}'");
            entry.Clear();
            entry.Focus();
            UpdateCount(listBox, countTextBox);
        }

        private void DeleteSelectedItem(ListBox listBox, TextBox countTextBox, string categoryLabel)
        {
            if (listBox.SelectedIndex <= -1)
                return;

            var removed = listBox.SelectedItem?.ToString();
            listBox.Items.RemoveAt(listBox.SelectedIndex);
            UpdateStatus($"Removed {categoryLabel} Item {removed}");
            UpdateCount(listBox, countTextBox);
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
                sb.AppendFormat("There are no items in the {0} list.", categoryName.ToLower());
            }
        }

        #endregion

        #region DELETE BUTTONS

        private void BreakfastDeleteBTN_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem(BreakfastListLB, BreakfastItemCountTB, "Breakfast");
        }

        private void LunchDeleteBTN_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem(LunchListLB, LunchItemCountTB, "Lunch");
        }

        private void DinnerDeleteBTN_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem(DinnerListLB, DinnerItemCountTB, "Dinner");
        }

        private void ExtrasDeleteBTN_Click(object sender, EventArgs e)
        {
            DeleteSelectedItem(ExtrasListLB, ExtrasItemCountTB, "Extras");
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

        private void SpeakListBTN_Click(object sender, EventArgs e)
        {
            if (SpeakListCB.SelectedIndex < 0)
                return;

            // Build a single speech string for the selected category to avoid overlapping SpeakAsync calls.
            var sb = new StringBuilder();
            var category = (ListCategory)SpeakListCB.SelectedIndex;

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
            }

            var speechText = sb.ToString();
            try
            {
                // Use SpeakAsync so the UI remains responsive.
                speechSynthesizer.SpeakAsyncCancelAll();
                speechSynthesizer.SpeakAsync(speechText);
            }
            catch (Exception ex)
            {
                // Keep UI-friendly handling for unexpected TTS errors.
                MessageBox.Show(this, $"Unable to speak the list: {ex.Message}", "Speech Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SaveListBTN_Click(object sender, EventArgs e)
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

                UpdateStatus("List saved to Documents Folder");
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Failed to save file: {ex.Message}", "Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateStatus("Save failed.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //set combobox to first item so it's not blank on top
            SpeakListCB.SelectedIndex = 0;
            StatusTB.Text = "Hello!  Type in list items then hit enter.";

            // initialize counts on load (in case designer set items)
            UpdateCount(BreakfastListLB, BreakfastItemCountTB);
            UpdateCount(LunchListLB, LunchItemCountTB);
            UpdateCount(DinnerListLB, DinnerItemCountTB);
            UpdateCount(ExtrasListLB, ExtrasItemCountTB);
        }

        // Ensure synthesizer is disposed when form closes.
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            try
            {
                speechSynthesizer?.SpeakAsyncCancelAll();
                speechSynthesizer?.Dispose();
            }
            catch
            {
                // swallow disposal exceptions to avoid blocking shutdown
            }
        }
    }
}