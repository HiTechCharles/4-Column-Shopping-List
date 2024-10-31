using System.Windows.Forms;
using System.Speech.Synthesis;

namespace _4_Column_Shopping_List
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpeechSynthesizer speechSynthesizerObj;
        
        #region DELETE BUTTONS
        private void BreakfastDeleteBTN_Click(object sender, System.EventArgs e)
        {
            if (BreakfastListLB.SelectedIndex > -1)  //if an item is selected
            {   //remove item from list
                StatusTB.Text = "Removed Breakfast Item " + BreakfastListLB.SelectedItem;
                BreakfastListLB.Items.RemoveAt(BreakfastListLB.SelectedIndex);
                //Update item count
                BreakfastItemCountTB.Text = BreakfastListLB.Items.Count + " Items";
            }
        }

        private void LunchDeleteBTN_Click(object sender, System.EventArgs e)
        {
            if (LunchListLB.SelectedIndex > -1)  //if am item is selected
            {
                StatusTB.Text = "Removed lunch Item " + LunchListLB.SelectedItem;
                LunchListLB.Items.RemoveAt(LunchListLB.SelectedIndex);
               LunchItemCountTB.Text = LunchListLB.Items.Count + " Items";
            }
        }

        private void DinnerDeleteBTN_Click(object sender, System.EventArgs e)
        {
            if (DinnerListLB.SelectedIndex > -1)  //if am item is selected
            {
                StatusTB.Text = "Removed dinner Item " + DinnerListLB.SelectedItem;
                DinnerListLB.Items.RemoveAt(DinnerListLB.SelectedIndex);
                DinnerItemCountTB.Text = DinnerListLB.Items.Count + " Items";
            }
        }

        private void ExtrasDeleteBTN_Click(object sender, System.EventArgs e)
        {
            if (ExtrasListLB.SelectedIndex > -1)  //if am item is selected
            {
                StatusTB.Text = "Removed extras Item " + ExtrasListLB.SelectedItem;
                ExtrasListLB.Items.RemoveAt(ExtrasListLB.SelectedIndex);
                ExtrasItemCountTB.Text = ExtrasListLB.Items.Count + " Items";
            }
        }
        #endregion

        #region KEYDOWN EVENTS
        private void BreakfastEntryTB_KeyDown(object sender, KeyEventArgs e)
        {
            //if enter is hit while in BreakfastEntryTB
            if (e.KeyCode == Keys.Enter)
            {
                //if breakfastEntryTB has length >=2 add item to listbox
                if (BreakfastEntryTB.Text.Length > 2)
                {
                    //add item in textbox to list
                    BreakfastListLB.Items.Add(BreakfastEntryTB.Text);
                    StatusTB.Text = "Added breakfast Item " + BreakfastEntryTB.Text;
                    BreakfastEntryTB.Clear();  //clear textbox
                    BreakfastEntryTB.Focus();  //return to input box
                    BreakfastItemCountTB.Text = BreakfastListLB.Items.Count + " Items";
                }
                e.Handled = true;  //prevents ding when hitting enter
                e.SuppressKeyPress = true;

            }
        }

        private void LunchEntryTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //if lunchentrytb has length >=2 add item to listbox
                if (LunchEntryTB.Text.Length > 2)
                {
                    LunchListLB.Items.Add(LunchEntryTB.Text);
                    StatusTB.Text = "Added lunch Item " + LunchEntryTB.Text;
                    LunchEntryTB.Clear();  //clear textbox
                    LunchEntryTB.Focus();  //return to input box
                    LunchItemCountTB.Text = LunchListLB.Items.Count + " Items";
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void DinnerEntryTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //if Dinnerentrytb has length >=2 add item to listbox
                if (DinnerEntryTB.Text.Length > 2)
                {
                    //put contents of textbox into listbox
                    DinnerListLB.Items.Add(DinnerEntryTB.Text);
                    StatusTB.Text = "Added dinner Item " + DinnerEntryTB.Text;
                    DinnerEntryTB.Clear();  //clear textbox
                    DinnerEntryTB.Focus();  //return to input box
                    DinnerItemCountTB.Text = DinnerListLB.Items.Count + " Items";
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void ExtrasEntryTB_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //if Extrasentrytb has length >=2 add item to listbox
                if (ExtrasEntryTB.Text.Length > 2)
                {
                    //put contents of textbox into listbox
                    ExtrasListLB.Items.Add(ExtrasEntryTB.Text);
                    StatusTB.Text = "Added extras Item " + ExtrasEntryTB.Text;
                    ExtrasEntryTB.Clear();  //clear textbox
                    ExtrasEntryTB.Focus();  //return to input box
                    ExtrasItemCountTB.Text = ExtrasListLB.Items.Count + " Items";
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
        #endregion 

        private void SpeakListBTN_Click(object sender, System.EventArgs e)
        {
            //start speech synthesizer, speak selected list from SpeakListCB
            speechSynthesizerObj = new SpeechSynthesizer();
            switch (SpeakListCB.SelectedIndex)
            {
                case 0:  //breakfast
                    //if breakfast listbox has items
                    if (BreakfastListLB.Items.Count > 0)
                    {
                        speechSynthesizerObj.Speak("You have " + BreakfastListLB.Items.Count + " Breakfast items as follows");

                        for (int i = 0; i < BreakfastListLB.Items.Count; i++) //loop througn lb items
                        {   //loop through listbox items and speak them.
                            speechSynthesizerObj.Speak(BreakfastListLB.Items[i].ToString());
                        }
                    }
                    else  //empty listbox
                        speechSynthesizerObj.Speak("There are No items in the breakfast list");
                    break;
                case 1:   //lunch
                    if (LunchListLB.Items.Count > 0)
                    {
                        speechSynthesizerObj.Speak("You have " + LunchListLB.Items.Count + " Lunch items as follows:");

                        for (int i = 0; i < LunchListLB.Items.Count; i++)
                        {
                            speechSynthesizerObj.Speak(LunchListLB.Items[i].ToString());
                        }
                    }
                    else
                        speechSynthesizerObj.Speak("There are No items in the lunch list");
                    break;
                case 2:  //dinner
                    if (DinnerListLB.Items.Count > 0)
                    {
                        speechSynthesizerObj.Speak("You have " + DinnerListLB.Items.Count + " Dinner items as follows:");

                        for (int i = 0; i < DinnerListLB.Items.Count; i++)
                        {
                            speechSynthesizerObj.Speak(DinnerListLB.Items[i].ToString());
                        }
                    }
                    else
                        speechSynthesizerObj.Speak("There are no items in the dinner list");
                    break;
                case 3:  //extras
                    if (ExtrasListLB.Items.Count > 0)
                    {
                        speechSynthesizerObj.Speak("You have " + ExtrasListLB.Items.Count + " Extras items as follows:");

                        for (int i = 0; i < ExtrasListLB.Items.Count; i++)
                        {
                            speechSynthesizerObj.Speak(ExtrasListLB.Items[i].ToString());
                        }
                    }
                    else
                        speechSynthesizerObj.Speak("There are no items in the Extras list");
                    break;
            }
        }

        private void SaveListBTN_Click(object sender, System.EventArgs e)
        {   
            //use the savefile dialog to gat a file name to save to.
            ListSave.ShowDialog();

            //start saving items to selected file
            //for each category, it prints the list name, and items
            System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(ListSave.FileName);
            StatusTB.Text = "List saved to " + ListSave.FileName;
            
            SaveFile.WriteLine("BREAKFAST");
            foreach (var item in BreakfastListLB.Items)
{
                SaveFile.WriteLine("    " + item.ToString());  //write items indented
            }

            SaveFile.WriteLine("LUNCH");
            foreach (var item in LunchListLB.Items)
            {
                SaveFile.WriteLine("    " + item.ToString());
            }

            SaveFile.WriteLine("DINNER");
            foreach (var item in DinnerListLB.Items)
            {
                SaveFile.WriteLine("    " + item.ToString());
            }

            SaveFile.WriteLine("EXTRAS");
            foreach (var item in ExtrasListLB.Items)
            {
                SaveFile.WriteLine("    " + item.ToString());
            }
            SaveFile.Close();  //close file, we're all done
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            //set combobox to first item so it's not blank on top
            SpeakListCB.SelectedIndex = 0;
            StatusTB.Text = "Hello!  Type in list items then hit enter.";
        }
    }
}