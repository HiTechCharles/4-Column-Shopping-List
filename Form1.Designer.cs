
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
            this.BreakfastAddBTN = new System.Windows.Forms.Button();
            this.BreakfastItemCountTB = new System.Windows.Forms.TextBox();
            this.BreakfastDeleteBTN = new System.Windows.Forms.Button();
            this.BreakfastSpeakBTN = new System.Windows.Forms.Button();
            this.LunchSpeakBTN = new System.Windows.Forms.Button();
            this.LunchDeleteBTN = new System.Windows.Forms.Button();
            this.LunchItemCountTB = new System.Windows.Forms.TextBox();
            this.LunchAddBTN = new System.Windows.Forms.Button();
            this.LunchListLB = new System.Windows.Forms.ListBox();
            this.LunchEntryTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BreakfastEntryTB
            // 
            this.BreakfastEntryTB.AccessibleDescription = "Breakfast - Type new item";
            this.BreakfastEntryTB.Location = new System.Drawing.Point(-1, 0);
            this.BreakfastEntryTB.Name = "BreakfastEntryTB";
            this.BreakfastEntryTB.Size = new System.Drawing.Size(272, 40);
            this.BreakfastEntryTB.TabIndex = 0;
            // 
            // BreakfastListLB
            // 
            this.BreakfastListLB.AccessibleDescription = "Breakfast - List of Items";
            this.BreakfastListLB.FormattingEnabled = true;
            this.BreakfastListLB.ItemHeight = 33;
            this.BreakfastListLB.Location = new System.Drawing.Point(-1, 46);
            this.BreakfastListLB.Name = "BreakfastListLB";
            this.BreakfastListLB.Size = new System.Drawing.Size(357, 466);
            this.BreakfastListLB.Sorted = true;
            this.BreakfastListLB.TabIndex = 2;
            // 
            // BreakfastAddBTN
            // 
            this.BreakfastAddBTN.AccessibleDescription = "Breakfast - Add item to list";
            this.BreakfastAddBTN.Location = new System.Drawing.Point(277, 0);
            this.BreakfastAddBTN.Name = "BreakfastAddBTN";
            this.BreakfastAddBTN.Size = new System.Drawing.Size(79, 40);
            this.BreakfastAddBTN.TabIndex = 1;
            this.BreakfastAddBTN.Text = "Add";
            this.BreakfastAddBTN.UseVisualStyleBackColor = true;
            this.BreakfastAddBTN.Click += new System.EventHandler(this.BreakfastAddBTN_Click);
            // 
            // BreakfastItemCountTB
            // 
            this.BreakfastItemCountTB.AccessibleDescription = "Breakfast Item Count";
            this.BreakfastItemCountTB.AccessibleName = "";
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
            this.LunchItemCountTB.Location = new System.Drawing.Point(362, 518);
            this.LunchItemCountTB.Name = "LunchItemCountTB";
            this.LunchItemCountTB.ReadOnly = true;
            this.LunchItemCountTB.Size = new System.Drawing.Size(357, 40);
            this.LunchItemCountTB.TabIndex = 9;
            this.LunchItemCountTB.Text = "No Items";
            this.LunchItemCountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LunchAddBTN
            // 
            this.LunchAddBTN.AccessibleDescription = "Lunch - Add item to list";
            this.LunchAddBTN.Location = new System.Drawing.Point(640, 0);
            this.LunchAddBTN.Name = "LunchAddBTN";
            this.LunchAddBTN.Size = new System.Drawing.Size(79, 40);
            this.LunchAddBTN.TabIndex = 7;
            this.LunchAddBTN.Text = "Add";
            this.LunchAddBTN.UseVisualStyleBackColor = true;
            this.LunchAddBTN.Click += new System.EventHandler(this.LunchAddBTN_Click);
            // 
            // LunchListLB
            // 
            this.LunchListLB.AccessibleDescription = "Lunch - List of Items";
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
            this.LunchEntryTB.AccessibleDescription = "Lunch - Type new item";
            this.LunchEntryTB.Location = new System.Drawing.Point(362, 0);
            this.LunchEntryTB.Name = "LunchEntryTB";
            this.LunchEntryTB.Size = new System.Drawing.Size(272, 40);
            this.LunchEntryTB.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1468, 627);
            this.Controls.Add(this.LunchSpeakBTN);
            this.Controls.Add(this.LunchDeleteBTN);
            this.Controls.Add(this.LunchItemCountTB);
            this.Controls.Add(this.LunchAddBTN);
            this.Controls.Add(this.LunchListLB);
            this.Controls.Add(this.LunchEntryTB);
            this.Controls.Add(this.BreakfastSpeakBTN);
            this.Controls.Add(this.BreakfastDeleteBTN);
            this.Controls.Add(this.BreakfastItemCountTB);
            this.Controls.Add(this.BreakfastAddBTN);
            this.Controls.Add(this.BreakfastListLB);
            this.Controls.Add(this.BreakfastEntryTB);
            this.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4 column Shopping List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BreakfastEntryTB;
        private System.Windows.Forms.ListBox BreakfastListLB;
        private System.Windows.Forms.Button BreakfastAddBTN;
        private System.Windows.Forms.TextBox BreakfastItemCountTB;
        private System.Windows.Forms.Button BreakfastDeleteBTN;
        private System.Windows.Forms.Button BreakfastSpeakBTN;
        private System.Windows.Forms.Button LunchSpeakBTN;
        private System.Windows.Forms.Button LunchDeleteBTN;
        private System.Windows.Forms.TextBox LunchItemCountTB;
        private System.Windows.Forms.Button LunchAddBTN;
        private System.Windows.Forms.ListBox LunchListLB;
        private System.Windows.Forms.TextBox LunchEntryTB;
    }
}

