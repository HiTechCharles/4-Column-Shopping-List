
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
            this.SuspendLayout();
            // 
            // BreakfastEntryTB
            // 
            this.BreakfastEntryTB.AccessibleDescription = "Breakfast - Item Entry";
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
            this.BreakfastListLB.TabIndex = 1;
            // 
            // BreakfastAddBTN
            // 
            this.BreakfastAddBTN.AccessibleDescription = "Breakfast - Add item to list";
            this.BreakfastAddBTN.Location = new System.Drawing.Point(277, 0);
            this.BreakfastAddBTN.Name = "BreakfastAddBTN";
            this.BreakfastAddBTN.Size = new System.Drawing.Size(79, 40);
            this.BreakfastAddBTN.TabIndex = 2;
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
            this.BreakfastDeleteBTN.AccessibleDescription = "Delete selected item";
            this.BreakfastDeleteBTN.Location = new System.Drawing.Point(-1, 564);
            this.BreakfastDeleteBTN.Name = "BreakfastDeleteBTN";
            this.BreakfastDeleteBTN.Size = new System.Drawing.Size(166, 40);
            this.BreakfastDeleteBTN.TabIndex = 4;
            this.BreakfastDeleteBTN.Text = "Delete";
            this.BreakfastDeleteBTN.UseVisualStyleBackColor = true;
            this.BreakfastDeleteBTN.Click += new System.EventHandler(this.BreakfastDeleteBTN_Click);
            // 
            // Form1
            // 
            this.AccessibleDescription = "4 Collumn Shopping List";
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1468, 627);
            this.Controls.Add(this.BreakfastDeleteBTN);
            this.Controls.Add(this.BreakfastItemCountTB);
            this.Controls.Add(this.BreakfastAddBTN);
            this.Controls.Add(this.BreakfastListLB);
            this.Controls.Add(this.BreakfastEntryTB);
            this.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.Name = "Form1";
            this.Text = "4 column Shopping List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BreakfastEntryTB;
        private System.Windows.Forms.ListBox BreakfastListLB;
        private System.Windows.Forms.Button BreakfastAddBTN;
        private System.Windows.Forms.TextBox BreakfastItemCountTB;
        private System.Windows.Forms.Button BreakfastDeleteBTN;
    }
}

