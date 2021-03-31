
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
            this.BreakfastSpeakBTN = new System.Windows.Forms.Button();
            this.LunchSpeakBTN = new System.Windows.Forms.Button();
            this.LunchDeleteBTN = new System.Windows.Forms.Button();
            this.LunchItemCountTB = new System.Windows.Forms.TextBox();
            this.LunchListLB = new System.Windows.Forms.ListBox();
            this.LunchEntryTB = new System.Windows.Forms.TextBox();
            this.DinnerSpeakBTN = new System.Windows.Forms.Button();
            this.DinnerDeleteBTN = new System.Windows.Forms.Button();
            this.DinnerItemCountTB = new System.Windows.Forms.TextBox();
            this.DinnerListLB = new System.Windows.Forms.ListBox();
            this.DinnerEntryTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BreakfastEntryTB
            // 
            this.BreakfastEntryTB.AccessibleDescription = "Breakfast - Type new item then press enter";
            this.BreakfastEntryTB.CausesValidation = false;
            this.BreakfastEntryTB.Location = new System.Drawing.Point(-1, 1);
            this.BreakfastEntryTB.Name = "BreakfastEntryTB";
            this.BreakfastEntryTB.Size = new System.Drawing.Size(357, 40);
            this.BreakfastEntryTB.TabIndex = 0;
            this.BreakfastEntryTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BreakfastEntryTB_KeyDown);
            // 
            // BreakfastListLB
            // 
            this.BreakfastListLB.AccessibleDescription = "Breakfast - List of Items";
            this.BreakfastListLB.CausesValidation = false;
            this.BreakfastListLB.FormattingEnabled = true;
            this.BreakfastListLB.ItemHeight = 33;
            this.BreakfastListLB.Location = new System.Drawing.Point(-1, 46);
            this.BreakfastListLB.Name = "BreakfastListLB";
            this.BreakfastListLB.Size = new System.Drawing.Size(357, 466);
            this.BreakfastListLB.Sorted = true;
            this.BreakfastListLB.TabIndex = 2;
            // 
            // BreakfastItemCountTB
            // 
            this.BreakfastItemCountTB.AccessibleDescription = "Breakfast Item Count";
            this.BreakfastItemCountTB.AccessibleName = "";
            this.BreakfastItemCountTB.CausesValidation = false;
            this.BreakfastItemCountTB.Location = new System.Drawing.Point(-1, 518);
            this.BreakfastItemCountTB.Name = "BreakfastItemCountTB";
            this.BreakfastItemCountTB.ReadOnly = true;
            this.BreakfastItemCountTB.Size = new System.Drawing.Size(357, 40);
            this.BreakfastItemCountTB.TabIndex = 3;
            this.BreakfastItemCountTB.Text = "No Items";
            this.BreakfastItemCountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BreakfastDeleteBTN
            // 
            this.BreakfastDeleteBTN.AccessibleDescription = "Breakfast - Delete selected item";
            this.BreakfastDeleteBTN.CausesValidation = false;
            this.BreakfastDeleteBTN.Location = new System.Drawing.Point(-1, 564);
            this.BreakfastDeleteBTN.Name = "BreakfastDeleteBTN";
            this.BreakfastDeleteBTN.Size = new System.Drawing.Size(178, 40);
            this.BreakfastDeleteBTN.TabIndex = 4;
            this.BreakfastDeleteBTN.Text = "Delete";
            this.BreakfastDeleteBTN.UseVisualStyleBackColor = true;
            this.BreakfastDeleteBTN.Click += new System.EventHandler(this.BreakfastDeleteBTN_Click);
            // 
            // BreakfastSpeakBTN
            // 
            this.BreakfastSpeakBTN.AccessibleDescription = "Speaks all breakfast Items";
            this.BreakfastSpeakBTN.CausesValidation = false;
            this.BreakfastSpeakBTN.Location = new System.Drawing.Point(178, 564);
            this.BreakfastSpeakBTN.Name = "BreakfastSpeakBTN";
            this.BreakfastSpeakBTN.Size = new System.Drawing.Size(178, 40);
            this.BreakfastSpeakBTN.TabIndex = 5;
            this.BreakfastSpeakBTN.Text = "Speak";
            this.BreakfastSpeakBTN.UseVisualStyleBackColor = true;
            this.BreakfastSpeakBTN.Click += new System.EventHandler(this.BreakfastSpeakBTN_Click);
            // 
            // LunchSpeakBTN
            // 
            this.LunchSpeakBTN.AccessibleDescription = "Speaks all Lunch Items";
            this.LunchSpeakBTN.CausesValidation = false;
            this.LunchSpeakBTN.Location = new System.Drawing.Point(541, 564);
            this.LunchSpeakBTN.Name = "LunchSpeakBTN";
            this.LunchSpeakBTN.Size = new System.Drawing.Size(178, 40);
            this.LunchSpeakBTN.TabIndex = 11;
            this.LunchSpeakBTN.Text = "Speak";
            this.LunchSpeakBTN.UseVisualStyleBackColor = true;
            this.LunchSpeakBTN.Click += new System.EventHandler(this.LunchSpeakBTN_Click);
            // 
            // LunchDeleteBTN
            // 
            this.LunchDeleteBTN.AccessibleDescription = "Lunch - Delete Selected Item";
            this.LunchDeleteBTN.CausesValidation = false;
            this.LunchDeleteBTN.Location = new System.Drawing.Point(362, 564);
            this.LunchDeleteBTN.Name = "LunchDeleteBTN";
            this.LunchDeleteBTN.Size = new System.Drawing.Size(178, 40);
            this.LunchDeleteBTN.TabIndex = 10;
            this.LunchDeleteBTN.Text = "Delete";
            this.LunchDeleteBTN.UseVisualStyleBackColor = true;
            this.LunchDeleteBTN.Click += new System.EventHandler(this.LunchDeleteBTN_Click);
            // 
            // LunchItemCountTB
            // 
            this.LunchItemCountTB.AccessibleDescription = "Lunch Item Count";
            this.LunchItemCountTB.AccessibleName = "";
            this.LunchItemCountTB.CausesValidation = false;
            this.LunchItemCountTB.Location = new System.Drawing.Point(362, 518);
            this.LunchItemCountTB.Name = "LunchItemCountTB";
            this.LunchItemCountTB.ReadOnly = true;
            this.LunchItemCountTB.Size = new System.Drawing.Size(357, 40);
            this.LunchItemCountTB.TabIndex = 9;
            this.LunchItemCountTB.Text = "No Items";
            this.LunchItemCountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LunchListLB
            // 
            this.LunchListLB.AccessibleDescription = "Lunch - List of Items";
            this.LunchListLB.CausesValidation = false;
            this.LunchListLB.FormattingEnabled = true;
            this.LunchListLB.ItemHeight = 33;
            this.LunchListLB.Location = new System.Drawing.Point(362, 46);
            this.LunchListLB.Name = "LunchListLB";
            this.LunchListLB.Size = new System.Drawing.Size(357, 466);
            this.LunchListLB.Sorted = true;
            this.LunchListLB.TabIndex = 8;
            // 
            // LunchEntryTB
            // 
            this.LunchEntryTB.AccessibleDescription = "Lunch - Type new item then press enter";
            this.LunchEntryTB.CausesValidation = false;
            this.LunchEntryTB.Location = new System.Drawing.Point(362, 0);
            this.LunchEntryTB.Name = "LunchEntryTB";
            this.LunchEntryTB.Size = new System.Drawing.Size(357, 40);
            this.LunchEntryTB.TabIndex = 6;
            this.LunchEntryTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LunchEntryTB_KeyDown);
            // 
            // DinnerSpeakBTN
            // 
            this.DinnerSpeakBTN.AccessibleDescription = "Speaks all Dinner Items";
            this.DinnerSpeakBTN.CausesValidation = false;
            this.DinnerSpeakBTN.Location = new System.Drawing.Point(904, 564);
            this.DinnerSpeakBTN.Name = "DinnerSpeakBTN";
            this.DinnerSpeakBTN.Size = new System.Drawing.Size(178, 40);
            this.DinnerSpeakBTN.TabIndex = 16;
            this.DinnerSpeakBTN.Text = "Speak";
            this.DinnerSpeakBTN.UseVisualStyleBackColor = true;
            this.DinnerSpeakBTN.Click += new System.EventHandler(this.DinnerSpeakBTN_Click);
            // 
            // DinnerDeleteBTN
            // 
            this.DinnerDeleteBTN.AccessibleDescription = "Dinner - Delete Selected Item";
            this.DinnerDeleteBTN.CausesValidation = false;
            this.DinnerDeleteBTN.Location = new System.Drawing.Point(725, 564);
            this.DinnerDeleteBTN.Name = "DinnerDeleteBTN";
            this.DinnerDeleteBTN.Size = new System.Drawing.Size(178, 40);
            this.DinnerDeleteBTN.TabIndex = 15;
            this.DinnerDeleteBTN.Text = "Delete";
            this.DinnerDeleteBTN.UseVisualStyleBackColor = true;
            this.DinnerDeleteBTN.Click += new System.EventHandler(this.DinnerDeleteBTN_Click);
            // 
            // DinnerItemCountTB
            // 
            this.DinnerItemCountTB.AccessibleDescription = "Dinner Item Count";
            this.DinnerItemCountTB.AccessibleName = "";
            this.DinnerItemCountTB.CausesValidation = false;
            this.DinnerItemCountTB.Location = new System.Drawing.Point(725, 518);
            this.DinnerItemCountTB.Name = "DinnerItemCountTB";
            this.DinnerItemCountTB.ReadOnly = true;
            this.DinnerItemCountTB.Size = new System.Drawing.Size(357, 40);
            this.DinnerItemCountTB.TabIndex = 14;
            this.DinnerItemCountTB.Text = "No Items";
            this.DinnerItemCountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DinnerListLB
            // 
            this.DinnerListLB.AccessibleDescription = "Dinner - List of Items";
            this.DinnerListLB.CausesValidation = false;
            this.DinnerListLB.FormattingEnabled = true;
            this.DinnerListLB.ItemHeight = 33;
            this.DinnerListLB.Location = new System.Drawing.Point(725, 46);
            this.DinnerListLB.Name = "DinnerListLB";
            this.DinnerListLB.Size = new System.Drawing.Size(357, 466);
            this.DinnerListLB.Sorted = true;
            this.DinnerListLB.TabIndex = 13;
            // 
            // DinnerEntryTB
            // 
            this.DinnerEntryTB.AccessibleDescription = "Dinner - Type new item then press Enger";
            this.DinnerEntryTB.CausesValidation = false;
            this.DinnerEntryTB.Location = new System.Drawing.Point(725, 0);
            this.DinnerEntryTB.Name = "DinnerEntryTB";
            this.DinnerEntryTB.Size = new System.Drawing.Size(357, 40);
            this.DinnerEntryTB.TabIndex = 12;
            this.DinnerEntryTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DinnerEntryTB_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1468, 627);
            this.Controls.Add(this.DinnerSpeakBTN);
            this.Controls.Add(this.DinnerDeleteBTN);
            this.Controls.Add(this.DinnerItemCountTB);
            this.Controls.Add(this.DinnerListLB);
            this.Controls.Add(this.DinnerEntryTB);
            this.Controls.Add(this.LunchSpeakBTN);
            this.Controls.Add(this.LunchDeleteBTN);
            this.Controls.Add(this.LunchItemCountTB);
            this.Controls.Add(this.LunchListLB);
            this.Controls.Add(this.LunchEntryTB);
            this.Controls.Add(this.BreakfastSpeakBTN);
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
            this.Text = "4 column Shopping List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BreakfastEntryTB;
        private System.Windows.Forms.ListBox BreakfastListLB;
        private System.Windows.Forms.TextBox BreakfastItemCountTB;
        private System.Windows.Forms.Button BreakfastDeleteBTN;
        private System.Windows.Forms.Button BreakfastSpeakBTN;
        private System.Windows.Forms.Button LunchSpeakBTN;
        private System.Windows.Forms.Button LunchDeleteBTN;
        private System.Windows.Forms.TextBox LunchItemCountTB;
        private System.Windows.Forms.ListBox LunchListLB;
        private System.Windows.Forms.TextBox LunchEntryTB;
        private System.Windows.Forms.Button DinnerSpeakBTN;
        private System.Windows.Forms.Button DinnerDeleteBTN;
        private System.Windows.Forms.TextBox DinnerItemCountTB;
        private System.Windows.Forms.ListBox DinnerListLB;
        private System.Windows.Forms.TextBox DinnerEntryTB;
    }
}

