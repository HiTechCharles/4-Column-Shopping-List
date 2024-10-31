
namespace _4_Column_Shopping_List
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BreakfastEntryTB = new System.Windows.Forms.TextBox();
            this.BreakfastListLB = new System.Windows.Forms.ListBox();
            this.BreakfastItemCountTB = new System.Windows.Forms.TextBox();
            this.BreakfastDeleteBTN = new System.Windows.Forms.Button();
            this.LunchDeleteBTN = new System.Windows.Forms.Button();
            this.LunchItemCountTB = new System.Windows.Forms.TextBox();
            this.LunchListLB = new System.Windows.Forms.ListBox();
            this.LunchEntryTB = new System.Windows.Forms.TextBox();
            this.DinnerDeleteBTN = new System.Windows.Forms.Button();
            this.DinnerItemCountTB = new System.Windows.Forms.TextBox();
            this.DinnerListLB = new System.Windows.Forms.ListBox();
            this.DinnerEntryTB = new System.Windows.Forms.TextBox();
            this.SpeakListCB = new System.Windows.Forms.ComboBox();
            this.SpeakListBTN = new System.Windows.Forms.Button();
            this.ExtrasDeleteBTN = new System.Windows.Forms.Button();
            this.ExtrasItemCountTB = new System.Windows.Forms.TextBox();
            this.ExtrasListLB = new System.Windows.Forms.ListBox();
            this.ExtrasEntryTB = new System.Windows.Forms.TextBox();
            this.ListSave = new System.Windows.Forms.SaveFileDialog();
            this.SaveListBTN = new System.Windows.Forms.Button();
            this.LunchLBL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.j = new System.Windows.Forms.Label();
            this.ExtrasLBL = new System.Windows.Forms.Label();
            this.StatusTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BreakfastEntryTB
            // 
            this.BreakfastEntryTB.AccessibleDescription = "Breakfast - Type new item then press enter";
            this.BreakfastEntryTB.AccessibleName = "Breakfast - Type new item then press enter";
            this.BreakfastEntryTB.CausesValidation = false;
            this.BreakfastEntryTB.Location = new System.Drawing.Point(0, 56);
            this.BreakfastEntryTB.Name = "BreakfastEntryTB";
            this.BreakfastEntryTB.Size = new System.Drawing.Size(357, 40);
            this.BreakfastEntryTB.TabIndex = 1;
            this.BreakfastEntryTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BreakfastEntryTB_KeyDown);
            // 
            // BreakfastListLB
            // 
            this.BreakfastListLB.AccessibleDescription = "Breakfast - List of Items";
            this.BreakfastListLB.AccessibleName = "Breakfast - List of Items";
            this.BreakfastListLB.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BreakfastListLB.CausesValidation = false;
            this.BreakfastListLB.FormattingEnabled = true;
            this.BreakfastListLB.ItemHeight = 33;
            this.BreakfastListLB.Location = new System.Drawing.Point(0, 101);
            this.BreakfastListLB.Name = "BreakfastListLB";
            this.BreakfastListLB.Size = new System.Drawing.Size(357, 466);
            this.BreakfastListLB.Sorted = true;
            this.BreakfastListLB.TabIndex = 2;
            // 
            // BreakfastItemCountTB
            // 
            this.BreakfastItemCountTB.AccessibleDescription = "Breakfast Item Count";
            this.BreakfastItemCountTB.AccessibleName = "Breakfast Item Count";
            this.BreakfastItemCountTB.CausesValidation = false;
            this.BreakfastItemCountTB.Location = new System.Drawing.Point(0, 573);
            this.BreakfastItemCountTB.Name = "BreakfastItemCountTB";
            this.BreakfastItemCountTB.ReadOnly = true;
            this.BreakfastItemCountTB.Size = new System.Drawing.Size(178, 40);
            this.BreakfastItemCountTB.TabIndex = 3;
            this.BreakfastItemCountTB.Text = "No Items";
            this.BreakfastItemCountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BreakfastDeleteBTN
            // 
            this.BreakfastDeleteBTN.AccessibleDescription = "Breakfast - Delete selected item";
            this.BreakfastDeleteBTN.AccessibleName = "Breakfast - Delete selected item";
            this.BreakfastDeleteBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BreakfastDeleteBTN.CausesValidation = false;
            this.BreakfastDeleteBTN.Location = new System.Drawing.Point(179, 572);
            this.BreakfastDeleteBTN.Name = "BreakfastDeleteBTN";
            this.BreakfastDeleteBTN.Size = new System.Drawing.Size(178, 41);
            this.BreakfastDeleteBTN.TabIndex = 4;
            this.BreakfastDeleteBTN.Text = "Delete";
            this.BreakfastDeleteBTN.UseVisualStyleBackColor = true;
            this.BreakfastDeleteBTN.Click += new System.EventHandler(this.BreakfastDeleteBTN_Click);
            // 
            // LunchDeleteBTN
            // 
            this.LunchDeleteBTN.AccessibleDescription = "Lunch - Delete Selected Item";
            this.LunchDeleteBTN.AccessibleName = "Lunch - Delete Selected Item";
            this.LunchDeleteBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.LunchDeleteBTN.CausesValidation = false;
            this.LunchDeleteBTN.Location = new System.Drawing.Point(547, 573);
            this.LunchDeleteBTN.Name = "LunchDeleteBTN";
            this.LunchDeleteBTN.Size = new System.Drawing.Size(173, 41);
            this.LunchDeleteBTN.TabIndex = 8;
            this.LunchDeleteBTN.Text = "Delete";
            this.LunchDeleteBTN.UseVisualStyleBackColor = true;
            this.LunchDeleteBTN.Click += new System.EventHandler(this.LunchDeleteBTN_Click);
            // 
            // LunchItemCountTB
            // 
            this.LunchItemCountTB.AccessibleDescription = "Lunch Item Count";
            this.LunchItemCountTB.AccessibleName = "Lunch Item Count";
            this.LunchItemCountTB.CausesValidation = false;
            this.LunchItemCountTB.Location = new System.Drawing.Point(363, 573);
            this.LunchItemCountTB.Name = "LunchItemCountTB";
            this.LunchItemCountTB.ReadOnly = true;
            this.LunchItemCountTB.Size = new System.Drawing.Size(178, 40);
            this.LunchItemCountTB.TabIndex = 7;
            this.LunchItemCountTB.Text = "No Items";
            this.LunchItemCountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LunchListLB
            // 
            this.LunchListLB.AccessibleDescription = "Lunch - List of Items";
            this.LunchListLB.AccessibleName = "Lunch - List of Items";
            this.LunchListLB.CausesValidation = false;
            this.LunchListLB.FormattingEnabled = true;
            this.LunchListLB.ItemHeight = 33;
            this.LunchListLB.Location = new System.Drawing.Point(363, 101);
            this.LunchListLB.Name = "LunchListLB";
            this.LunchListLB.Size = new System.Drawing.Size(357, 466);
            this.LunchListLB.Sorted = true;
            this.LunchListLB.TabIndex = 6;
            // 
            // LunchEntryTB
            // 
            this.LunchEntryTB.AccessibleDescription = "Lunch - Type new item then press enter";
            this.LunchEntryTB.AccessibleName = "Lunch - Type new item then press enter";
            this.LunchEntryTB.CausesValidation = false;
            this.LunchEntryTB.Location = new System.Drawing.Point(363, 55);
            this.LunchEntryTB.Name = "LunchEntryTB";
            this.LunchEntryTB.Size = new System.Drawing.Size(357, 40);
            this.LunchEntryTB.TabIndex = 5;
            this.LunchEntryTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LunchEntryTB_KeyDown);
            // 
            // DinnerDeleteBTN
            // 
            this.DinnerDeleteBTN.AccessibleDescription = "Dinner - Delete Selected Item";
            this.DinnerDeleteBTN.AccessibleName = "Dinner - Delete Selected Item";
            this.DinnerDeleteBTN.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.DinnerDeleteBTN.CausesValidation = false;
            this.DinnerDeleteBTN.Location = new System.Drawing.Point(910, 573);
            this.DinnerDeleteBTN.Name = "DinnerDeleteBTN";
            this.DinnerDeleteBTN.Size = new System.Drawing.Size(173, 41);
            this.DinnerDeleteBTN.TabIndex = 12;
            this.DinnerDeleteBTN.Text = "Delete";
            this.DinnerDeleteBTN.UseVisualStyleBackColor = true;
            this.DinnerDeleteBTN.Click += new System.EventHandler(this.DinnerDeleteBTN_Click);
            // 
            // DinnerItemCountTB
            // 
            this.DinnerItemCountTB.AccessibleDescription = "Dinner Item Count";
            this.DinnerItemCountTB.AccessibleName = "Dinner Item Count";
            this.DinnerItemCountTB.CausesValidation = false;
            this.DinnerItemCountTB.Location = new System.Drawing.Point(726, 573);
            this.DinnerItemCountTB.Name = "DinnerItemCountTB";
            this.DinnerItemCountTB.ReadOnly = true;
            this.DinnerItemCountTB.Size = new System.Drawing.Size(178, 40);
            this.DinnerItemCountTB.TabIndex = 11;
            this.DinnerItemCountTB.Text = "No Items";
            this.DinnerItemCountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DinnerListLB
            // 
            this.DinnerListLB.AccessibleDescription = "Dinner - List of Items";
            this.DinnerListLB.AccessibleName = "Dinner - List of Items";
            this.DinnerListLB.CausesValidation = false;
            this.DinnerListLB.FormattingEnabled = true;
            this.DinnerListLB.ItemHeight = 33;
            this.DinnerListLB.Location = new System.Drawing.Point(726, 101);
            this.DinnerListLB.Name = "DinnerListLB";
            this.DinnerListLB.Size = new System.Drawing.Size(357, 466);
            this.DinnerListLB.Sorted = true;
            this.DinnerListLB.TabIndex = 10;
            // 
            // DinnerEntryTB
            // 
            this.DinnerEntryTB.AccessibleDescription = "Dinner - Type new item then press Enter";
            this.DinnerEntryTB.AccessibleName = "Dinner - Type new item then press Enter";
            this.DinnerEntryTB.CausesValidation = false;
            this.DinnerEntryTB.Location = new System.Drawing.Point(726, 55);
            this.DinnerEntryTB.Name = "DinnerEntryTB";
            this.DinnerEntryTB.Size = new System.Drawing.Size(357, 40);
            this.DinnerEntryTB.TabIndex = 9;
            this.DinnerEntryTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DinnerEntryTB_KeyDown);
            // 
            // SpeakListCB
            // 
            this.SpeakListCB.AccessibleDescription = "List Selection - Choose a list to speak";
            this.SpeakListCB.AccessibleName = "List Selection - Choose a list to speak";
            this.SpeakListCB.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.SpeakListCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpeakListCB.Items.AddRange(new object[] {
            "Breakfast",
            "Lunch",
            "Dinner",
            "Extras"});
            this.SpeakListCB.Location = new System.Drawing.Point(12, 631);
            this.SpeakListCB.Name = "SpeakListCB";
            this.SpeakListCB.Size = new System.Drawing.Size(178, 41);
            this.SpeakListCB.TabIndex = 17;
            // 
            // SpeakListBTN
            // 
            this.SpeakListBTN.AccessibleDescription = "Speaks the selected list";
            this.SpeakListBTN.AccessibleName = "Speaks the selected list";
            this.SpeakListBTN.CausesValidation = false;
            this.SpeakListBTN.Location = new System.Drawing.Point(196, 632);
            this.SpeakListBTN.Name = "SpeakListBTN";
            this.SpeakListBTN.Size = new System.Drawing.Size(178, 40);
            this.SpeakListBTN.TabIndex = 18;
            this.SpeakListBTN.Text = "Speak List";
            this.SpeakListBTN.UseVisualStyleBackColor = true;
            this.SpeakListBTN.Click += new System.EventHandler(this.SpeakListBTN_Click);
            // 
            // ExtrasDeleteBTN
            // 
            this.ExtrasDeleteBTN.AccessibleDescription = "Extras - Delete Selected Item";
            this.ExtrasDeleteBTN.AccessibleName = "Extras - Delete Selected Item";
            this.ExtrasDeleteBTN.CausesValidation = false;
            this.ExtrasDeleteBTN.Location = new System.Drawing.Point(1273, 572);
            this.ExtrasDeleteBTN.Name = "ExtrasDeleteBTN";
            this.ExtrasDeleteBTN.Size = new System.Drawing.Size(173, 41);
            this.ExtrasDeleteBTN.TabIndex = 16;
            this.ExtrasDeleteBTN.Text = "Delete";
            this.ExtrasDeleteBTN.UseVisualStyleBackColor = true;
            this.ExtrasDeleteBTN.Click += new System.EventHandler(this.ExtrasDeleteBTN_Click);
            // 
            // ExtrasItemCountTB
            // 
            this.ExtrasItemCountTB.AccessibleDescription = "Extras Item Count";
            this.ExtrasItemCountTB.AccessibleName = "Extras Item Count";
            this.ExtrasItemCountTB.CausesValidation = false;
            this.ExtrasItemCountTB.Location = new System.Drawing.Point(1089, 573);
            this.ExtrasItemCountTB.Name = "ExtrasItemCountTB";
            this.ExtrasItemCountTB.ReadOnly = true;
            this.ExtrasItemCountTB.Size = new System.Drawing.Size(178, 40);
            this.ExtrasItemCountTB.TabIndex = 15;
            this.ExtrasItemCountTB.Text = "No Items";
            this.ExtrasItemCountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExtrasListLB
            // 
            this.ExtrasListLB.AccessibleDescription = "Extras - List of Items";
            this.ExtrasListLB.AccessibleName = "Extras - List of Items";
            this.ExtrasListLB.CausesValidation = false;
            this.ExtrasListLB.FormattingEnabled = true;
            this.ExtrasListLB.ItemHeight = 33;
            this.ExtrasListLB.Location = new System.Drawing.Point(1089, 101);
            this.ExtrasListLB.Name = "ExtrasListLB";
            this.ExtrasListLB.Size = new System.Drawing.Size(357, 466);
            this.ExtrasListLB.Sorted = true;
            this.ExtrasListLB.TabIndex = 14;
            // 
            // ExtrasEntryTB
            // 
            this.ExtrasEntryTB.AccessibleDescription = "Extras - Type new item then press Enter";
            this.ExtrasEntryTB.AccessibleName = "Extras - Type new item then press Enter";
            this.ExtrasEntryTB.CausesValidation = false;
            this.ExtrasEntryTB.Location = new System.Drawing.Point(1089, 55);
            this.ExtrasEntryTB.Name = "ExtrasEntryTB";
            this.ExtrasEntryTB.Size = new System.Drawing.Size(357, 40);
            this.ExtrasEntryTB.TabIndex = 13;
            this.ExtrasEntryTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExtrasEntryTB_KeyDown);
            // 
            // ListSave
            // 
            this.ListSave.DefaultExt = "txt";
            this.ListSave.Title = "Save Shopping  List";
            // 
            // SaveListBTN
            // 
            this.SaveListBTN.AccessibleDescription = "Saves the list to a text file";
            this.SaveListBTN.AccessibleName = "Saves the list to a text file";
            this.SaveListBTN.CausesValidation = false;
            this.SaveListBTN.Location = new System.Drawing.Point(380, 632);
            this.SaveListBTN.Name = "SaveListBTN";
            this.SaveListBTN.Size = new System.Drawing.Size(188, 40);
            this.SaveListBTN.TabIndex = 19;
            this.SaveListBTN.Text = "Save List";
            this.SaveListBTN.UseVisualStyleBackColor = true;
            this.SaveListBTN.Click += new System.EventHandler(this.SaveListBTN_Click);
            // 
            // LunchLBL
            // 
            this.LunchLBL.AutoSize = true;
            this.LunchLBL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LunchLBL.Location = new System.Drawing.Point(357, 9);
            this.LunchLBL.Name = "LunchLBL";
            this.LunchLBL.Size = new System.Drawing.Size(110, 33);
            this.LunchLBL.TabIndex = 20;
            this.LunchLBL.Text = "LUNCH";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 33);
            this.label1.TabIndex = 23;
            this.label1.Text = "BREAKFAST";
            // 
            // j
            // 
            this.j.AutoSize = true;
            this.j.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.j.Location = new System.Drawing.Point(720, 9);
            this.j.Name = "j";
            this.j.Size = new System.Drawing.Size(127, 33);
            this.j.TabIndex = 24;
            this.j.Text = "DINNER";
            // 
            // ExtrasLBL
            // 
            this.ExtrasLBL.AutoSize = true;
            this.ExtrasLBL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExtrasLBL.Location = new System.Drawing.Point(1083, 9);
            this.ExtrasLBL.Name = "ExtrasLBL";
            this.ExtrasLBL.Size = new System.Drawing.Size(122, 33);
            this.ExtrasLBL.TabIndex = 25;
            this.ExtrasLBL.Text = "EXTRAS";
            // 
            // StatusTB
            // 
            this.StatusTB.AccessibleDescription = "Status Bar ";
            this.StatusTB.AccessibleName = "Status Bar ";
            this.StatusTB.CausesValidation = false;
            this.StatusTB.Location = new System.Drawing.Point(574, 632);
            this.StatusTB.Name = "StatusTB";
            this.StatusTB.ReadOnly = true;
            this.StatusTB.Size = new System.Drawing.Size(872, 40);
            this.StatusTB.TabIndex = 26;
            this.StatusTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1453, 687);
            this.Controls.Add(this.StatusTB);
            this.Controls.Add(this.ExtrasLBL);
            this.Controls.Add(this.j);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LunchLBL);
            this.Controls.Add(this.SaveListBTN);
            this.Controls.Add(this.ExtrasDeleteBTN);
            this.Controls.Add(this.ExtrasItemCountTB);
            this.Controls.Add(this.ExtrasListLB);
            this.Controls.Add(this.ExtrasEntryTB);
            this.Controls.Add(this.SpeakListBTN);
            this.Controls.Add(this.SpeakListCB);
            this.Controls.Add(this.DinnerDeleteBTN);
            this.Controls.Add(this.DinnerItemCountTB);
            this.Controls.Add(this.DinnerListLB);
            this.Controls.Add(this.DinnerEntryTB);
            this.Controls.Add(this.LunchDeleteBTN);
            this.Controls.Add(this.LunchItemCountTB);
            this.Controls.Add(this.LunchListLB);
            this.Controls.Add(this.LunchEntryTB);
            this.Controls.Add(this.BreakfastDeleteBTN);
            this.Controls.Add(this.BreakfastItemCountTB);
            this.Controls.Add(this.BreakfastListLB);
            this.Controls.Add(this.BreakfastEntryTB);
            this.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "j";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BreakfastEntryTB;
        private System.Windows.Forms.ListBox BreakfastListLB;
        private System.Windows.Forms.TextBox BreakfastItemCountTB;
        private System.Windows.Forms.Button BreakfastDeleteBTN;
        private System.Windows.Forms.Button LunchDeleteBTN;
        private System.Windows.Forms.TextBox LunchItemCountTB;
        private System.Windows.Forms.ListBox LunchListLB;
        private System.Windows.Forms.TextBox LunchEntryTB;
        private System.Windows.Forms.Button DinnerDeleteBTN;
        private System.Windows.Forms.TextBox DinnerItemCountTB;
        private System.Windows.Forms.ListBox DinnerListLB;
        private System.Windows.Forms.TextBox DinnerEntryTB;
        private System.Windows.Forms.ComboBox SpeakListCB;
        private System.Windows.Forms.Button SpeakListBTN;
        private System.Windows.Forms.Button ExtrasDeleteBTN;
        private System.Windows.Forms.TextBox ExtrasItemCountTB;
        private System.Windows.Forms.ListBox ExtrasListLB;
        private System.Windows.Forms.TextBox ExtrasEntryTB;
        private System.Windows.Forms.SaveFileDialog ListSave;
        private System.Windows.Forms.Button SaveListBTN;
        private System.Windows.Forms.Label LunchLBL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label j;
        private System.Windows.Forms.Label ExtrasLBL;
        private System.Windows.Forms.TextBox StatusTB;
    }
}

