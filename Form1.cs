using System.Windows.Forms;
using System.Speech;  //allows speech synthesis
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
        private void BreakfastAddBTN_Click(object sender, System.EventArgs e)
        {
            //if breakfastentrytb has length >=2 add item to listbox
            if ( BreakfastEntryTB.Text.Length >2 )
            {
                //add item in textbox to list
                speechSynthesizerObj = new SpeechSynthesizer();
                speechSynthesizerObj.Speak(BreakfastEntryTB.Text.ToString()
                    + " added");
                //put contents of textbox into listbox
                BreakfastListLB.Items.Add(BreakfastEntryTB.Text);
                BreakfastEntryTB.Clear();  //clear textbox
                BreakfastEntryTB.Focus();  //return to input box
                BreakfastItemCountTB.Text = BreakfastListLB.Items.Count + " Items";
            }
        }

        private void BreakfastDeleteBTN_Click(object sender, System.EventArgs e)
        {
            if (BreakfastListLB.SelectedIndex > -1)  //if an item is selected
            {
                speechSynthesizerObj = new SpeechSynthesizer();
                speechSynthesizerObj.Speak(BreakfastListLB.SelectedItem + " removed");
                BreakfastListLB.Items.RemoveAt(BreakfastListLB.SelectedIndex);
                BreakfastItemCountTB.Text = BreakfastListLB.Items.Count + " Items";
            }
            else
                speechSynthesizerObj.Speak("select a breakfast item first");
        }

        private void BreakfastSpeakBTN_Click(object sender, System.EventArgs e)
        {
            //if breakfast listbox has items
            if (BreakfastListLB.Items.Count > 0 )
            {
                speechSynthesizerObj = new SpeechSynthesizer();
                speechSynthesizerObj.Speak("You have " + BreakfastListLB.Items.Count + " Breakfast items as follows");

                for (int i = 0; i < BreakfastListLB.Items.Count; i++) //loop througn lb items
                {
                    speechSynthesizerObj.Speak(BreakfastListLB.Items[i].ToString());
                }
            }
            else
                speechSynthesizerObj. Speak("There are No items in the breakfast list");
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            speechSynthesizerObj = new SpeechSynthesizer();
            speechSynthesizerObj.Speak("Welcome to the 4 column shopping list");
        }

        private void LunchAddBTN_Click(object sender, System.EventArgs e)
        {
            if (LunchEntryTB.Text.Length > 2)
            {
                //add item in textbox to list
                speechSynthesizerObj = new SpeechSynthesizer();
                speechSynthesizerObj.Speak(LunchEntryTB.Text.ToString()
 + " added");
                LunchListLB.Items.Add(LunchEntryTB.Text);
                LunchEntryTB.Clear();  //clear textbox
                LunchEntryTB.Focus();  //return to input box
                LunchItemCountTB.Text = LunchListLB.Items.Count + " Items";
            }
        }

        private void LunchDeleteBTN_Click(object sender, System.EventArgs e)
        {
            if (LunchListLB.SelectedIndex > -1)  //if am item is selected
            {
                speechSynthesizerObj = new SpeechSynthesizer();
                speechSynthesizerObj.Speak(LunchListLB.SelectedItem + " removed");
                LunchListLB.Items.RemoveAt(LunchListLB.SelectedIndex);
                LunchItemCountTB.Text = LunchListLB.Items.Count + " Items";
            }
            else
                speechSynthesizerObj.Speak("Select a lunch item first");
        }

        private void LunchSpeakBTN_Click(object sender, System.EventArgs e)
        {
            if (LunchListLB.Items.Count > 0)
            {
                speechSynthesizerObj = new SpeechSynthesizer();
                speechSynthesizerObj.Speak("You have " + LunchListLB.Items.Count + " Lunch items as follows:");

                for (int i = 0; i < LunchListLB.Items.Count; i++)
                {
                    speechSynthesizerObj.Speak(LunchListLB.Items[i].ToString());
                }
            }
            else
                speechSynthesizerObj.Speak("There are No items in the lunch list");
        }
    }
   
}