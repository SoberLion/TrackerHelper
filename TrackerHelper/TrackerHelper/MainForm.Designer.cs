namespace TrackerHelper
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSMenu_Tickets = new System.Windows.Forms.ToolStripMenuItem();
            this.getToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.postToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabCMain = new System.Windows.Forms.TabControl();
            this.tabPage_Issues = new System.Windows.Forms.TabPage();
            this.xmlTreeView = new System.Windows.Forms.TreeView();
            this.cMStrip_TreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ticketsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showMoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtb_ROut = new System.Windows.Forms.RichTextBox();
            this.MainMenu.SuspendLayout();
            this.tabCMain.SuspendLayout();
            this.tabPage_Issues.SuspendLayout();
            this.cMStrip_TreeView.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.BackColor = System.Drawing.SystemColors.Control;
            this.MainMenu.GripMargin = new System.Windows.Forms.Padding(0);
            this.MainMenu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.MainMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(0);
            this.MainMenu.Size = new System.Drawing.Size(673, 19);
            this.MainMenu.TabIndex = 1;
            this.MainMenu.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.menuToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSMenu_Tickets,
            this.getToolStripMenuItem,
            this.postToolStripMenuItem,
            this.toolStripMenuItem3,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tSMenu_Tickets
            // 
            this.tSMenu_Tickets.BackColor = System.Drawing.SystemColors.Control;
            this.tSMenu_Tickets.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tSMenu_Tickets.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tSMenu_Tickets.Name = "tSMenu_Tickets";
            this.tSMenu_Tickets.Size = new System.Drawing.Size(152, 22);
            this.tSMenu_Tickets.Text = "Tickets";
            this.tSMenu_Tickets.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // getToolStripMenuItem
            // 
            this.getToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.getToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.getToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.getToolStripMenuItem.Name = "getToolStripMenuItem";
            this.getToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.getToolStripMenuItem.Text = "Time_entries";
            this.getToolStripMenuItem.Click += new System.EventHandler(this.getToolStripMenuItem_Click);
            // 
            // postToolStripMenuItem
            // 
            this.postToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.postToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.postToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.postToolStripMenuItem.Name = "postToolStripMenuItem";
            this.postToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.postToolStripMenuItem.Text = "Post";
            this.postToolStripMenuItem.Click += new System.EventHandler(this.postToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem3.ForeColor = System.Drawing.SystemColors.WindowText;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "List<Issue>";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.exitToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.WindowText;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 19);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // tabCMain
            // 
            this.tabCMain.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabCMain.Controls.Add(this.tabPage_Issues);
            this.tabCMain.Controls.Add(this.tabPage2);
            this.tabCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCMain.HotTrack = true;
            this.tabCMain.ItemSize = new System.Drawing.Size(96, 21);
            this.tabCMain.Location = new System.Drawing.Point(0, 19);
            this.tabCMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabCMain.Multiline = true;
            this.tabCMain.Name = "tabCMain";
            this.tabCMain.Padding = new System.Drawing.Point(0, 0);
            this.tabCMain.SelectedIndex = 0;
            this.tabCMain.Size = new System.Drawing.Size(673, 373);
            this.tabCMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCMain.TabIndex = 2;
            // 
            // tabPage_Issues
            // 
            this.tabPage_Issues.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_Issues.Controls.Add(this.xmlTreeView);
            this.tabPage_Issues.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Issues.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage_Issues.Name = "tabPage_Issues";
            this.tabPage_Issues.Size = new System.Drawing.Size(665, 344);
            this.tabPage_Issues.TabIndex = 0;
            this.tabPage_Issues.Text = "Задачи";
            // 
            // xmlTreeView
            // 
            this.xmlTreeView.BackColor = System.Drawing.SystemColors.Control;
            this.xmlTreeView.ContextMenuStrip = this.cMStrip_TreeView;
            this.xmlTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xmlTreeView.ForeColor = System.Drawing.Color.Lime;
            this.xmlTreeView.HideSelection = false;
            this.xmlTreeView.Location = new System.Drawing.Point(0, 0);
            this.xmlTreeView.Name = "xmlTreeView";
            this.xmlTreeView.Size = new System.Drawing.Size(665, 344);
            this.xmlTreeView.TabIndex = 2;
            // 
            // cMStrip_TreeView
            // 
            this.cMStrip_TreeView.BackColor = System.Drawing.SystemColors.WindowText;
            this.cMStrip_TreeView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cMStrip_TreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ticketsToolStripMenuItem,
            this.showMoreToolStripMenuItem});
            this.cMStrip_TreeView.Name = "cMStrip_TreeView";
            this.cMStrip_TreeView.ShowImageMargin = false;
            this.cMStrip_TreeView.Size = new System.Drawing.Size(107, 48);
            // 
            // ticketsToolStripMenuItem
            // 
            this.ticketsToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowText;
            this.ticketsToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ticketsToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ticketsToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.ticketsToolStripMenuItem.Name = "ticketsToolStripMenuItem";
            this.ticketsToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.ticketsToolStripMenuItem.Text = "Tickets";
            // 
            // showMoreToolStripMenuItem
            // 
            this.showMoreToolStripMenuItem.BackColor = System.Drawing.SystemColors.WindowText;
            this.showMoreToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.showMoreToolStripMenuItem.ForeColor = System.Drawing.Color.Lime;
            this.showMoreToolStripMenuItem.Name = "showMoreToolStripMenuItem";
            this.showMoreToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.showMoreToolStripMenuItem.Text = "ShowMore";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.rtb_ROut);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(665, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            // 
            // rtb_ROut
            // 
            this.rtb_ROut.BackColor = System.Drawing.SystemColors.Control;
            this.rtb_ROut.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_ROut.ContextMenuStrip = this.cMStrip_TreeView;
            this.rtb_ROut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_ROut.ForeColor = System.Drawing.SystemColors.WindowText;
            this.rtb_ROut.Location = new System.Drawing.Point(3, 3);
            this.rtb_ROut.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_ROut.Name = "rtb_ROut";
            this.rtb_ROut.Size = new System.Drawing.Size(659, 338);
            this.rtb_ROut.TabIndex = 2;
            this.rtb_ROut.Text = "";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(673, 392);
            this.ControlBox = false;
            this.Controls.Add(this.tabCMain);
            this.Controls.Add(this.MainMenu);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.tabCMain.ResumeLayout(false);
            this.tabPage_Issues.ResumeLayout(false);
            this.cMStrip_TreeView.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem getToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem postToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tSMenu_Tickets;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.TabControl tabCMain;
        private System.Windows.Forms.TabPage tabPage_Issues;
        private System.Windows.Forms.TreeView xmlTreeView;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip cMStrip_TreeView;
        private System.Windows.Forms.ToolStripMenuItem ticketsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showMoreToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtb_ROut;
    }
}

