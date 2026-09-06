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
            this.LunchItemCountTB = new System.Windows.Forms.TextBox();
            this.LunchListLB = new System.Windows.Forms.ListBox();
            this.LunchEntryTB = new System.Windows.Forms.TextBox();
            this.DinnerItemCountTB = new System.Windows.Forms.TextBox();
            this.DinnerListLB = new System.Windows.Forms.ListBox();
            this.DinnerEntryTB = new System.Windows.Forms.TextBox();
            this.ExtrasItemCountTB = new System.Windows.Forms.TextBox();
            this.ExtrasListLB = new System.Windows.Forms.ListBox();
            this.ExtrasEntryTB = new System.Windows.Forms.TextBox();
            this.LunchLBL = new System.Windows.Forms.Label();
            this.BreakfastLBL = new System.Windows.Forms.Label();
            this.DinnerLBL = new System.Windows.Forms.Label();
            this.ExtrasLBL = new System.Windows.Forms.Label();
            this.MainMenuMST = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.speakListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.breakfastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lunchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dinnerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.everythingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewListFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.object_8badae07_4511_40fe_beff_845ff436e90f = new System.Windows.Forms.Form();
            this.object_3c1eae5c_f549_41b7_8500_a09688764ebc = new System.Windows.Forms.Form();
            this.MainMenuMST.SuspendLayout();
            this.SuspendLayout();
            // 
            // BreakfastEntryTB
            // 
            this.BreakfastEntryTB.AccessibleDescription = "Breakfast - Type new item then press enter";
            this.BreakfastEntryTB.AccessibleName = "Breakfast - Type new item then press enter";
            this.BreakfastEntryTB.CausesValidation = false;
            this.BreakfastEntryTB.Location = new System.Drawing.Point(7, 94);
            this.BreakfastEntryTB.Name = "BreakfastEntryTB";
            this.BreakfastEntryTB.Size = new System.Drawing.Size(315, 36);
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
            this.BreakfastListLB.ItemHeight = 29;
            this.BreakfastListLB.Location = new System.Drawing.Point(7, 136);
            this.BreakfastListLB.Name = "BreakfastListLB";
            this.BreakfastListLB.Size = new System.Drawing.Size(315, 381);
            this.BreakfastListLB.Sorted = true;
            this.BreakfastListLB.TabIndex = 2;
            // 
            // BreakfastItemCountTB
            // 
            this.BreakfastItemCountTB.AccessibleDescription = "Breakfast Item Count";
            this.BreakfastItemCountTB.AccessibleName = "Breakfast Item Count";
            this.BreakfastItemCountTB.CausesValidation = false;
            this.BreakfastItemCountTB.Location = new System.Drawing.Point(7, 523);
            this.BreakfastItemCountTB.Name = "BreakfastItemCountTB";
            this.BreakfastItemCountTB.ReadOnly = true;
            this.BreakfastItemCountTB.Size = new System.Drawing.Size(315, 36);
            this.BreakfastItemCountTB.TabIndex = 3;
            this.BreakfastItemCountTB.Text = "No Items";
            this.BreakfastItemCountTB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LunchItemCountTB
            // 
            this.LunchItemCountTB.AccessibleDescription = "Lunch Item Count";
            this.LunchItemCountTB.AccessibleName = "Lunch Item Count";
            this.LunchItemCountTB.CausesValidation = false;
            this.LunchItemCountTB.Location = new System.Drawing.Point(342, 523);
            this.LunchItemCountTB.Name = "LunchItemCountTB";
            this.LunchItemCountTB.ReadOnly = true;
            this.LunchItemCountTB.Size = new System.Drawing.Size(315, 36);
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
            this.LunchListLB.ItemHeight = 29;
            this.LunchListLB.Location = new System.Drawing.Point(342, 136);
            this.LunchListLB.Name = "LunchListLB";
            this.LunchListLB.Size = new System.Drawing.Size(315, 381);
            this.LunchListLB.Sorted = true;
            this.LunchListLB.TabIndex = 6;
            // 
            // LunchEntryTB
            // 
            this.LunchEntryTB.AccessibleDescription = "Lunch - Type new item then press enter";
            this.LunchEntryTB.AccessibleName = "Lunch - Type new item then press enter";
            this.LunchEntryTB.CausesValidation = false;
            this.LunchEntryTB.Location = new System.Drawing.Point(342, 94);
            this.LunchEntryTB.Name = "LunchEntryTB";
            this.LunchEntryTB.Size = new System.Drawing.Size(315, 36);
            this.LunchEntryTB.TabIndex = 5;
            this.LunchEntryTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LunchEntryTB_KeyDown);
            // 
            // DinnerItemCountTB
            // 
            this.DinnerItemCountTB.AccessibleDescription = "Dinner Item Count";
            this.DinnerItemCountTB.AccessibleName = "Dinner Item Count";
            this.DinnerItemCountTB.CausesValidation = false;
            this.DinnerItemCountTB.Location = new System.Drawing.Point(671, 525);
            this.DinnerItemCountTB.Name = "DinnerItemCountTB";
            this.DinnerItemCountTB.ReadOnly = true;
            this.DinnerItemCountTB.Size = new System.Drawing.Size(315, 36);
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
            this.DinnerListLB.ItemHeight = 29;
            this.DinnerListLB.Location = new System.Drawing.Point(671, 136);
            this.DinnerListLB.Name = "DinnerListLB";
            this.DinnerListLB.Size = new System.Drawing.Size(315, 381);
            this.DinnerListLB.Sorted = true;
            this.DinnerListLB.TabIndex = 10;
            // 
            // DinnerEntryTB
            // 
            this.DinnerEntryTB.AccessibleDescription = "Dinner - Type new item then press Enter";
            this.DinnerEntryTB.AccessibleName = "Dinner - Type new item then press Enter";
            this.DinnerEntryTB.CausesValidation = false;
            this.DinnerEntryTB.Location = new System.Drawing.Point(671, 94);
            this.DinnerEntryTB.Name = "DinnerEntryTB";
            this.DinnerEntryTB.Size = new System.Drawing.Size(315, 36);
            this.DinnerEntryTB.TabIndex = 9;
            this.DinnerEntryTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DinnerEntryTB_KeyDown);
            // 
            // ExtrasItemCountTB
            // 
            this.ExtrasItemCountTB.AccessibleDescription = "Extras Item Count";
            this.ExtrasItemCountTB.AccessibleName = "Extras Item Count";
            this.ExtrasItemCountTB.CausesValidation = false;
            this.ExtrasItemCountTB.Location = new System.Drawing.Point(999, 525);
            this.ExtrasItemCountTB.Name = "ExtrasItemCountTB";
            this.ExtrasItemCountTB.ReadOnly = true;
            this.ExtrasItemCountTB.Size = new System.Drawing.Size(315, 36);
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
            this.ExtrasListLB.ItemHeight = 29;
            this.ExtrasListLB.Location = new System.Drawing.Point(999, 136);
            this.ExtrasListLB.Name = "ExtrasListLB";
            this.ExtrasListLB.Size = new System.Drawing.Size(315, 381);
            this.ExtrasListLB.Sorted = true;
            this.ExtrasListLB.TabIndex = 14;
            // 
            // ExtrasEntryTB
            // 
            this.ExtrasEntryTB.AccessibleDescription = "Extras - Type new item then press Enter";
            this.ExtrasEntryTB.AccessibleName = "Extras - Type new item then press Enter";
            this.ExtrasEntryTB.CausesValidation = false;
            this.ExtrasEntryTB.Location = new System.Drawing.Point(999, 94);
            this.ExtrasEntryTB.Name = "ExtrasEntryTB";
            this.ExtrasEntryTB.Size = new System.Drawing.Size(315, 36);
            this.ExtrasEntryTB.TabIndex = 13;
            this.ExtrasEntryTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExtrasEntryTB_KeyDown);
            // 
            // LunchLBL
            // 
            this.LunchLBL.AutoSize = true;
            this.LunchLBL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LunchLBL.Location = new System.Drawing.Point(342, 54);
            this.LunchLBL.Name = "LunchLBL";
            this.LunchLBL.Size = new System.Drawing.Size(98, 29);
            this.LunchLBL.TabIndex = 20;
            this.LunchLBL.Text = "LUNCH";
            // 
            // BreakfastLBL
            // 
            this.BreakfastLBL.AutoSize = true;
            this.BreakfastLBL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BreakfastLBL.Location = new System.Drawing.Point(7, 54);
            this.BreakfastLBL.Name = "BreakfastLBL";
            this.BreakfastLBL.Size = new System.Drawing.Size(154, 29);
            this.BreakfastLBL.TabIndex = 23;
            this.BreakfastLBL.Text = "BREAKFAST";
            // 
            // DinnerLBL
            // 
            this.DinnerLBL.AutoSize = true;
            this.DinnerLBL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DinnerLBL.Location = new System.Drawing.Point(671, 54);
            this.DinnerLBL.Name = "DinnerLBL";
            this.DinnerLBL.Size = new System.Drawing.Size(113, 29);
            this.DinnerLBL.TabIndex = 24;
            this.DinnerLBL.Text = "DINNER";
            // 
            // ExtrasLBL
            // 
            this.ExtrasLBL.AutoSize = true;
            this.ExtrasLBL.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ExtrasLBL.Location = new System.Drawing.Point(999, 54);
            this.ExtrasLBL.Name = "ExtrasLBL";
            this.ExtrasLBL.Size = new System.Drawing.Size(107, 29);
            this.ExtrasLBL.TabIndex = 25;
            this.ExtrasLBL.Text = "EXTRAS";
            // 
            // MainMenuMST
            // 
            this.MainMenuMST.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.MainMenuMST.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.MainMenuMST.Location = new System.Drawing.Point(0, 0);
            this.MainMenuMST.Name = "MainMenuMST";
            this.MainMenuMST.Size = new System.Drawing.Size(1331, 37);
            this.MainMenuMST.TabIndex = 27;
            this.MainMenuMST.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteItemToolStripMenuItem,
            this.newToolStripMenuItem,
            this.speakListToolStripMenuItem,
            this.viewListFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(117, 33);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // deleteItemToolStripMenuItem
            // 
            this.deleteItemToolStripMenuItem.Name = "deleteItemToolStripMenuItem";
            this.deleteItemToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.deleteItemToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.deleteItemToolStripMenuItem.Text = "&Delete Item";
            this.deleteItemToolStripMenuItem.Click += new System.EventHandler(this.deleteItemToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.newToolStripMenuItem.Text = "&New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // speakListToolStripMenuItem
            // 
            this.speakListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.breakfastToolStripMenuItem,
            this.lunchToolStripMenuItem,
            this.dinnerToolStripMenuItem,
            this.extrasToolStripMenuItem,
            this.everythingToolStripMenuItem});
            this.speakListToolStripMenuItem.Name = "speakListToolStripMenuItem";
            this.speakListToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.speakListToolStripMenuItem.Text = "&Speak List";
            // 
            // breakfastToolStripMenuItem
            // 
            this.breakfastToolStripMenuItem.Name = "breakfastToolStripMenuItem";
            this.breakfastToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.breakfastToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            this.breakfastToolStripMenuItem.Text = "&Breakfast";
            this.breakfastToolStripMenuItem.Click += new System.EventHandler(this.breakfastToolStripMenuItem_Click);
            // 
            // lunchToolStripMenuItem
            // 
            this.lunchToolStripMenuItem.Name = "lunchToolStripMenuItem";
            this.lunchToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.lunchToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            this.lunchToolStripMenuItem.Text = "&Lunch";
            this.lunchToolStripMenuItem.Click += new System.EventHandler(this.lunchToolStripMenuItem_Click);
            // 
            // dinnerToolStripMenuItem
            // 
            this.dinnerToolStripMenuItem.Name = "dinnerToolStripMenuItem";
            this.dinnerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.dinnerToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            this.dinnerToolStripMenuItem.Text = "&Dinner";
            this.dinnerToolStripMenuItem.Click += new System.EventHandler(this.dinnerToolStripMenuItem_Click);
            // 
            // extrasToolStripMenuItem
            // 
            this.extrasToolStripMenuItem.Name = "extrasToolStripMenuItem";
            this.extrasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.extrasToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            this.extrasToolStripMenuItem.Text = "E&xtras";
            this.extrasToolStripMenuItem.Click += new System.EventHandler(this.extrasToolStripMenuItem_Click);
            // 
            // everythingToolStripMenuItem
            // 
            this.everythingToolStripMenuItem.Name = "everythingToolStripMenuItem";
            this.everythingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.everythingToolStripMenuItem.Size = new System.Drawing.Size(306, 34);
            this.everythingToolStripMenuItem.Text = "&Everything";
            this.everythingToolStripMenuItem.Click += new System.EventHandler(this.everythingToolStripMenuItem_Click);
            // 
            // viewListFileToolStripMenuItem
            // 
            this.viewListFileToolStripMenuItem.Name = "viewListFileToolStripMenuItem";
            this.viewListFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.viewListFileToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.viewListFileToolStripMenuItem.Text = "&View List File";
            this.viewListFileToolStripMenuItem.Click += new System.EventHandler(this.viewListFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(335, 34);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(79, 33);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(275, 34);
            this.aboutToolStripMenuItem.Text = "A&bout...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // object_8badae07_4511_40fe_beff_845ff436e90f
            // 
            this.object_8badae07_4511_40fe_beff_845ff436e90f.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.object_8badae07_4511_40fe_beff_845ff436e90f.ClientSize = new System.Drawing.Size(1282, 640);
            this.object_8badae07_4511_40fe_beff_845ff436e90f.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.object_8badae07_4511_40fe_beff_845ff436e90f.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.object_8badae07_4511_40fe_beff_845ff436e90f.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.object_8badae07_4511_40fe_beff_845ff436e90f.KeyPreview = true;
            this.object_8badae07_4511_40fe_beff_845ff436e90f.Location = new System.Drawing.Point(15, 15);
            this.object_8badae07_4511_40fe_beff_845ff436e90f.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.object_8badae07_4511_40fe_beff_845ff436e90f.MaximizeBox = false;
            this.object_8badae07_4511_40fe_beff_845ff436e90f.Name = "object_8badae07_4511_40fe_beff_845ff436e90f";
            this.object_8badae07_4511_40fe_beff_845ff436e90f.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.object_8badae07_4511_40fe_beff_845ff436e90f.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.object_8badae07_4511_40fe_beff_845ff436e90f.Visible = false;
            // 
            // object_3c1eae5c_f549_41b7_8500_a09688764ebc
            // 
            this.object_3c1eae5c_f549_41b7_8500_a09688764ebc.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.object_3c1eae5c_f549_41b7_8500_a09688764ebc.ClientSize = new System.Drawing.Size(1282, 640);
            this.object_3c1eae5c_f549_41b7_8500_a09688764ebc.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.object_3c1eae5c_f549_41b7_8500_a09688764ebc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.object_3c1eae5c_f549_41b7_8500_a09688764ebc.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.object_3c1eae5c_f549_41b7_8500_a09688764ebc.KeyPreview = true;
            this.object_3c1eae5c_f549_41b7_8500_a09688764ebc.Location = new System.Drawing.Point(15, 15);
            this.object_3c1eae5c_f549_41b7_8500_a09688764ebc.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.object_3c1eae5c_f549_41b7_8500_a09688764ebc.MaximizeBox = false;
            this.object_3c1eae5c_f549_41b7_8500_a09688764ebc.Name = "object_3c1eae5c_f549_41b7_8500_a09688764ebc";
            this.object_3c1eae5c_f549_41b7_8500_a09688764ebc.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.object_3c1eae5c_f549_41b7_8500_a09688764ebc.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.object_3c1eae5c_f549_41b7_8500_a09688764ebc.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1331, 588);
            this.Controls.Add(this.ExtrasLBL);
            this.Controls.Add(this.DinnerLBL);
            this.Controls.Add(this.BreakfastLBL);
            this.Controls.Add(this.LunchLBL);
            this.Controls.Add(this.ExtrasItemCountTB);
            this.Controls.Add(this.ExtrasListLB);
            this.Controls.Add(this.ExtrasEntryTB);
            this.Controls.Add(this.DinnerItemCountTB);
            this.Controls.Add(this.DinnerListLB);
            this.Controls.Add(this.DinnerEntryTB);
            this.Controls.Add(this.LunchItemCountTB);
            this.Controls.Add(this.LunchListLB);
            this.Controls.Add(this.LunchEntryTB);
            this.Controls.Add(this.BreakfastItemCountTB);
            this.Controls.Add(this.BreakfastListLB);
            this.Controls.Add(this.BreakfastEntryTB);
            this.Controls.Add(this.MainMenuMST);
            this.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.KeyPreview = true;
            this.MainMenuStrip = this.MainMenuMST;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "4-Column Shopping List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainMenuMST.ResumeLayout(false);
            this.MainMenuMST.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Form object_8badae07_4511_40fe_beff_845ff436e90f;
        private System.Windows.Forms.Form object_3c1eae5c_f549_41b7_8500_a09688764ebc;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewListFileToolStripMenuItem;
    }
}

