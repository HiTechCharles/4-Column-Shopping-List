using System.Windows.Forms;

namespace _4_Column_Shopping_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BreakfastAddBTN_Click(object sender, System.EventArgs e)
        {
            if ( BreakfastEntryTB.Text.Length >2 )
            {
                BreakfastListLB.Items.Add(BreakfastEntryTB.Text);
                BreakfastEntryTB.Clear();  //clear textbox
                BreakfastEntryTB.Focus();  //return to input box
                BreakfastItemCountTB.Text = BreakfastListLB.Items.Count + " Items";
            }
        }

        private void BreakfastDeleteBTN_Click(object sender, System.EventArgs e)
        {
            if ( BreakfastListLB.SelectedIndex > -1 )
            {
                BreakfastListLB.Items.RemoveAt(BreakfastListLB.SelectedIndex);
                BreakfastItemCountTB.Text = BreakfastListLB.Items.Count + " Items";
            }
        }
    }
}
