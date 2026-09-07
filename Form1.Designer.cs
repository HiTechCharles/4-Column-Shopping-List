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
            BreakfastEntryTB = new System.Windows.Forms.TextBox();
            BreakfastListLB = new System.Windows.Forms.ListBox();
            BreakfastItemCountTB = new System.Windows.Forms.TextBox();
            LunchItemCountTB = new System.Windows.Forms.TextBox();
            LunchListLB = new System.Windows.Forms.ListBox();
            LunchEntryTB = new System.Windows.Forms.TextBox();
            DinnerItemCountTB = new System.Windows.Forms.TextBox();
            DinnerListLB = new System.Windows.Forms.ListBox();
            DinnerEntryTB = new System.Windows.Forms.TextBox();
            ExtrasItemCountTB = new System.Windows.Forms.TextBox();
            ExtrasListLB = new System.Windows.Forms.ListBox();
            ExtrasEntryTB = new System.Windows.Forms.TextBox();
            LunchLBL = new System.Windows.Forms.Label();
            BreakfastLBL = new System.Windows.Forms.Label();
            DinnerLBL = new System.Windows.Forms.Label();
            ExtrasLBL = new System.Windows.Forms.Label();
            MainMenuMST = new System.Windows.Forms.MenuStrip();
            optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            speakListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            breakfastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            lunchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            dinnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            everythingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            viewListFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            MainMenuMST.SuspendLayout();
            SuspendLayout();
            // 
            // BreakfastEntryTB
            // 
            BreakfastEntryTB.AccessibleDescription = "Breakfast - Type new item then press enter";
            BreakfastEntryTB.AccessibleName = "Breakfast - Type new item then press enter";
            BreakfastEntryTB.CausesValidation = false;
            BreakfastEntryTB.Location = new System.Drawing.Point(7, 94);
            BreakfastEntryTB.Name = "BreakfastEntryTB";
            BreakfastEntryTB.Size = new System.Drawing.Size(315, 36);
            BreakfastEntryTB.TabIndex = 1;
            BreakfastEntryTB.KeyDown += BreakfastEntryTB_KeyDown;
            // 
            // BreakfastListLB
            // 
            BreakfastListLB.AccessibleDescription = "Breakfast - List of Items";
            BreakfastListLB.AccessibleName = "Breakfast - List of Items";
            BreakfastListLB.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            BreakfastListLB.CausesValidation = false;
            BreakfastListLB.FormattingEnabled = true;
            BreakfastListLB.Location = new System.Drawing.Point(7, 136);
            BreakfastListLB.Name = "BreakfastListLB";
            BreakfastListLB.Size = new System.Drawing.Size(315, 381);
            BreakfastListLB.Sorted = true;
            BreakfastListLB.TabIndex = 2;
            // 
            // BreakfastItemCountTB
            // 
            BreakfastItemCountTB.AccessibleDescription = "Breakfast Item Count";
            BreakfastItemCountTB.AccessibleName = "Breakfast Item Count";
            BreakfastItemCountTB.CausesValidation = false;
            BreakfastItemCountTB.Location = new System.Drawing.Point(7, 523);
            BreakfastItemCountTB.Name = "BreakfastItemCountTB";
            BreakfastItemCountTB.ReadOnly = true;
            BreakfastItemCountTB.Size = new System.Drawing.Size(315, 36);
            BreakfastItemCountTB.TabIndex = 3;
            BreakfastItemCountTB.Text = "No Items";
            BreakfastItemCountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LunchItemCountTB
            // 
            LunchItemCountTB.AccessibleDescription = "Lunch Item Count";
            LunchItemCountTB.AccessibleName = "Lunch Item Count";
            LunchItemCountTB.CausesValidation = false;
            LunchItemCountTB.Location = new System.Drawing.Point(342, 523);
            LunchItemCountTB.Name = "LunchItemCountTB";
            LunchItemCountTB.ReadOnly = true;
            LunchItemCountTB.Size = new System.Drawing.Size(315, 36);
            LunchItemCountTB.TabIndex = 7;
            LunchItemCountTB.Text = "No Items";
            LunchItemCountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LunchListLB
            // 
            LunchListLB.AccessibleDescription = "Lunch - List of Items";
            LunchListLB.AccessibleName = "Lunch - List of Items";
            LunchListLB.CausesValidation = false;
            LunchListLB.FormattingEnabled = true;
            LunchListLB.Location = new System.Drawing.Point(342, 136);
            LunchListLB.Name = "LunchListLB";
            LunchListLB.Size = new System.Drawing.Size(315, 381);
            LunchListLB.Sorted = true;
            LunchListLB.TabIndex = 6;
            // 
            // LunchEntryTB
            // 
            LunchEntryTB.AccessibleDescription = "Lunch - Type new item then press enter";
            LunchEntryTB.AccessibleName = "Lunch - Type new item then press enter";
            LunchEntryTB.CausesValidation = false;
            LunchEntryTB.Location = new System.Drawing.Point(342, 94);
            LunchEntryTB.Name = "LunchEntryTB";
            LunchEntryTB.Size = new System.Drawing.Size(315, 36);
            LunchEntryTB.TabIndex = 5;
            LunchEntryTB.KeyDown += LunchEntryTB_KeyDown;
            // 
            // DinnerItemCountTB
            // 
            DinnerItemCountTB.AccessibleDescription = "Dinner Item Count";
            DinnerItemCountTB.AccessibleName = "Dinner Item Count";
            DinnerItemCountTB.CausesValidation = false;
            DinnerItemCountTB.Location = new System.Drawing.Point(671, 525);
            DinnerItemCountTB.Name = "DinnerItemCountTB";
            DinnerItemCountTB.ReadOnly = true;
            DinnerItemCountTB.Size = new System.Drawing.Size(315, 36);
            DinnerItemCountTB.TabIndex = 11;
            DinnerItemCountTB.Text = "No Items";
            DinnerItemCountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DinnerListLB
            // 
            DinnerListLB.AccessibleDescription = "Dinner - List of Items";
            DinnerListLB.AccessibleName = "Dinner - List of Items";
            DinnerListLB.CausesValidation = false;
            DinnerListLB.FormattingEnabled = true;
            DinnerListLB.Location = new System.Drawing.Point(671, 136);
            DinnerListLB.Name = "DinnerListLB";
            DinnerListLB.Size = new System.Drawing.Size(315, 381);
            DinnerListLB.Sorted = true;
            DinnerListLB.TabIndex = 10;
            // 
            // DinnerEntryTB
            // 
            DinnerEntryTB.AccessibleDescription = "Dinner - Type new item then press Enter";
            DinnerEntryTB.AccessibleName = "Dinner - Type new item then press Enter";
            DinnerEntryTB.CausesValidation = false;
            DinnerEntryTB.Location = new System.Drawing.Point(671, 94);
            DinnerEntryTB.Name = "DinnerEntryTB";
            DinnerEntryTB.Size = new System.Drawing.Size(315, 36);
            DinnerEntryTB.TabIndex = 9;
            DinnerEntryTB.KeyDown += DinnerEntryTB_KeyDown;
            // 
            // ExtrasItemCountTB
            // 
            ExtrasItemCountTB.AccessibleDescription = "Extras Item Count";
            ExtrasItemCountTB.AccessibleName = "Extras Item Count";
            ExtrasItemCountTB.CausesValidation = false;
            ExtrasItemCountTB.Location = new System.Drawing.Point(999, 525);
            ExtrasItemCountTB.Name = "ExtrasItemCountTB";
            ExtrasItemCountTB.ReadOnly = true;
            ExtrasItemCountTB.Size = new System.Drawing.Size(315, 36);
            ExtrasItemCountTB.TabIndex = 15;
            ExtrasItemCountTB.Text = "No Items";
            ExtrasItemCountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ExtrasListLB
            // 
            ExtrasListLB.AccessibleDescription = "Extras - List of Items";
            ExtrasListLB.AccessibleName = "Extras - List of Items";
            ExtrasListLB.CausesValidation = false;
            ExtrasListLB.FormattingEnabled = true;
            ExtrasListLB.Location = new System.Drawing.Point(999, 136);
            ExtrasListLB.Name = "ExtrasListLB";
            ExtrasListLB.Size = new System.Drawing.Size(315, 381);
            ExtrasListLB.Sorted = true;
            ExtrasListLB.TabIndex = 14;
            // 
            // ExtrasEntryTB
            // 
            ExtrasEntryTB.AccessibleDescription = "Extras - Type new item then press Enter";
            ExtrasEntryTB.AccessibleName = "Extras - Type new item then press Enter";
            ExtrasEntryTB.CausesValidation = false;
            ExtrasEntryTB.Location = new System.Drawing.Point(999, 94);
            ExtrasEntryTB.Name = "ExtrasEntryTB";
            ExtrasEntryTB.Size = new System.Drawing.Size(315, 36);
            ExtrasEntryTB.TabIndex = 13;
            ExtrasEntryTB.KeyDown += ExtrasEntryTB_KeyDown;
            // 
            // LunchLBL
            // 
            LunchLBL.AutoSize = true;
            LunchLBL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            LunchLBL.Location = new System.Drawing.Point(342, 54);
            LunchLBL.Name = "LunchLBL";
            LunchLBL.Size = new System.Drawing.Size(98, 29);
            LunchLBL.TabIndex = 20;
            LunchLBL.Text = "LUNCH";
            // 
            // BreakfastLBL
            // 
            BreakfastLBL.AutoSize = true;
            BreakfastLBL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            BreakfastLBL.Location = new System.Drawing.Point(7, 54);
            BreakfastLBL.Name = "BreakfastLBL";
            BreakfastLBL.Size = new System.Drawing.Size(154, 29);
            BreakfastLBL.TabIndex = 23;
            BreakfastLBL.Text = "BREAKFAST";
            // 
            // DinnerLBL
            // 
            DinnerLBL.AutoSize = true;
            DinnerLBL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            DinnerLBL.Location = new System.Drawing.Point(671, 54);
            DinnerLBL.Name = "DinnerLBL";
            DinnerLBL.Size = new System.Drawing.Size(113, 29);
            DinnerLBL.TabIndex = 24;
            DinnerLBL.Text = "DINNER";
            // 
            // ExtrasLBL
            // 
            ExtrasLBL.AutoSize = true;
            ExtrasLBL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            ExtrasLBL.Location = new System.Drawing.Point(999, 54);
            ExtrasLBL.Name = "ExtrasLBL";
            ExtrasLBL.Size = new System.Drawing.Size(107, 29);
            ExtrasLBL.TabIndex = 25;
            ExtrasLBL.Text = "EXTRAS";
            // 
            // MainMenuMST
            // 
            MainMenuMST.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            MainMenuMST.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { optionsToolStripMenuItem, helpToolStripMenuItem });
            MainMenuMST.Location = new System.Drawing.Point(0, 0);
            MainMenuMST.Name = "MainMenuMST";
            MainMenuMST.Size = new System.Drawing.Size(1331, 37);
            MainMenuMST.TabIndex = 27;
            MainMenuMST.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { deleteItemToolStripMenuItem, newToolStripMenuItem, speakListToolStripMenuItem, viewListFileToolStripMenuItem, exitToolStripMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new System.Drawing.Size(117, 33);
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // deleteItemToolStripMenuItem
            // 
            deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            deleteItemToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            deleteItemToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            deleteItemToolStripMenuItem.Text = "&Delete Item";
            deleteItemToolStripMenuItem.Click += deleteItemToolStripMenuItem_Click;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N;
            newToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            newToolStripMenuItem.Text = "&New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // speakListToolStripMenuItem
            // 
            speakListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { breakfastToolStripMenuItem, lunchToolStripMenuItem, dinnerToolStripMenuItem, extrasToolStripMenuItem, everythingToolStripMenuItem });
            speakListToolStripMenuItem.Name = "speakListToolStripMenuItem";
            speakListToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            speakListToolStripMenuItem.Text = "&Speak List";
            // 
            // breakfastToolStripMenuItem
            // 
            breakfastToolStripMenuItem.Name = "breakfastToolStripMenuItem";
            breakfastToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B;
            breakfastToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            breakfastToolStripMenuItem.Text = "&Breakfast";
            breakfastToolStripMenuItem.Click += breakfastToolStripMenuItem_Click;
            // 
            // lunchToolStripMenuItem
            // 
            lunchToolStripMenuItem.Name = "lunchToolStripMenuItem";
            lunchToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L;
            lunchToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            lunchToolStripMenuItem.Text = "&Lunch";
            lunchToolStripMenuItem.Click += lunchToolStripMenuItem_Click;
            // 
            // dinnerToolStripMenuItem
            // 
            dinnerToolStripMenuItem.Name = "dinnerToolStripMenuItem";
            dinnerToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D;
            dinnerToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            dinnerToolStripMenuItem.Text = "&Dinner";
            dinnerToolStripMenuItem.Click += dinnerToolStripMenuItem_Click;
            // 
            // extrasToolStripMenuItem
            // 
            extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            extrasToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X;
            extrasToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            extrasToolStripMenuItem.Text = "E&xtras";
            extrasToolStripMenuItem.Click += extrasToolStripMenuItem_Click;
            // 
            // everythingToolStripMenuItem
            // 
            everythingToolStripMenuItem.Name = "everythingToolStripMenuItem";
            everythingToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E;
            everythingToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            everythingToolStripMenuItem.Text = "&Everything";
            everythingToolStripMenuItem.Click += everythingToolStripMenuItem_Click;
            // 
            // viewListFileToolStripMenuItem
            // 
            viewListFileToolStripMenuItem.Name = "viewListFileToolStripMenuItem";
            viewListFileToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V;
            viewListFileToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            viewListFileToolStripMenuItem.Text = "&View List File";
            viewListFileToolStripMenuItem.Click += viewListFileToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4;
            exitToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(79, 33);
            helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U;
            aboutToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            aboutToolStripMenuItem.Text = "A&bout...";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(1331, 588);
            Controls.Add(ExtrasLBL);
            Controls.Add(DinnerLBL);
            Controls.Add(BreakfastLBL);
            Controls.Add(LunchLBL);
            Controls.Add(ExtrasItemCountTB);
            Controls.Add(ExtrasListLB);
            Controls.Add(ExtrasEntryTB);
            Controls.Add(DinnerItemCountTB);
            Controls.Add(DinnerListLB);
            Controls.Add(DinnerEntryTB);
            Controls.Add(LunchItemCountTB);
            Controls.Add(LunchListLB);
            Controls.Add(LunchEntryTB);
            Controls.Add(BreakfastItemCountTB);
            Controls.Add(BreakfastListLB);
            Controls.Add(BreakfastEntryTB);
            Controls.Add(MainMenuMST);
            Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            KeyPreview = true;
            MainMenuStrip = MainMenuMST;
            Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "4-Column Shopping List";
            Load += Form1_Load;
            MainMenuMST.ResumeLayout(false);
            MainMenuMST.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BreakfastEntryTB;
        private System.Windows.Forms.ListBox BreakfastListLB;
        private System.Windows.Forms.TextBox BreakfastItemCountTB;
        private System.Windows.Forms.TextBox LunchItemCountTB;
        private System.Windows.Forms.ListBox LunchListLB;
        private System.Windows.Forms.TextBox LunchEntryTB;
        private System.Windows.Forms.TextBox DinnerItemCountTB;
        private System.Windows.Forms.ListBox DinnerListLB;
        private System.Windows.Forms.TextBox DinnerEntryTB;
        private System.Windows.Forms.TextBox ExtrasItemCountTB;
        private System.Windows.Forms.ListBox ExtrasListLB;
        private System.Windows.Forms.TextBox ExtrasEntryTB;
        private System.Windows.Forms.Label LunchLBL;
        private System.Windows.Forms.Label BreakfastLBL;
        private System.Windows.Forms.Label DinnerLBL;
        private System.Windows.Forms.Label ExtrasLBL;
        private System.Windows.Forms.MenuStrip MainMenuMST;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem speakListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem breakfastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lunchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dinnerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem extrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem everythingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewListFileToolStripMenuItem;
    }
}

