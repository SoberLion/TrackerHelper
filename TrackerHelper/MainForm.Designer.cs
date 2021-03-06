﻿namespace TrackerHelper
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.techSupportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupedByStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newClosedLastYearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newIssuesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeEntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashBoardsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.techSuppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.dashBoardsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(384, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tasksToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // tasksToolStripMenuItem
            // 
            this.tasksToolStripMenuItem.Name = "tasksToolStripMenuItem";
            this.tasksToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.tasksToolStripMenuItem.Text = "Tasks";
            this.tasksToolStripMenuItem.Click += new System.EventHandler(this.tasksToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupsToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.techSupportToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // techSupportToolStripMenuItem
            // 
            this.techSupportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupedByStatusToolStripMenuItem,
            this.newClosedLastYearToolStripMenuItem,
            this.newIssuesMenuItem,
            this.timeEntriesToolStripMenuItem});
            this.techSupportToolStripMenuItem.Name = "techSupportToolStripMenuItem";
            this.techSupportToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.techSupportToolStripMenuItem.Text = "Tech support";
            // 
            // groupedByStatusToolStripMenuItem
            // 
            this.groupedByStatusToolStripMenuItem.Name = "groupedByStatusToolStripMenuItem";
            this.groupedByStatusToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.groupedByStatusToolStripMenuItem.Text = "Grouped by status";
            this.groupedByStatusToolStripMenuItem.Click += new System.EventHandler(this.groupedByStatusToolStripMenuItem_Click);
            // 
            // newClosedLastYearToolStripMenuItem
            // 
            this.newClosedLastYearToolStripMenuItem.Name = "newClosedLastYearToolStripMenuItem";
            this.newClosedLastYearToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.newClosedLastYearToolStripMenuItem.Text = "New/Closed last year";
            this.newClosedLastYearToolStripMenuItem.Click += new System.EventHandler(this.newClosedLastYearToolStripMenuItem_Click);
            // 
            // newIssuesMenuItem
            // 
            this.newIssuesMenuItem.Name = "newIssuesMenuItem";
            this.newIssuesMenuItem.Size = new System.Drawing.Size(185, 22);
            this.newIssuesMenuItem.Text = "New issues";
            this.newIssuesMenuItem.Click += new System.EventHandler(this.newIssuesMenuItem_Click);
            // 
            // timeEntriesToolStripMenuItem
            // 
            this.timeEntriesToolStripMenuItem.Name = "timeEntriesToolStripMenuItem";
            this.timeEntriesToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.timeEntriesToolStripMenuItem.Text = "Time entries";
            this.timeEntriesToolStripMenuItem.Click += new System.EventHandler(this.timeEntriesToolStripMenuItem_Click);
            // 
            // dashBoardsToolStripMenuItem
            // 
            this.dashBoardsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.techSuppToolStripMenuItem});
            this.dashBoardsToolStripMenuItem.Name = "dashBoardsToolStripMenuItem";
            this.dashBoardsToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.dashBoardsToolStripMenuItem.Text = "DashBoards";
            // 
            // techSuppToolStripMenuItem
            // 
            this.techSuppToolStripMenuItem.Name = "techSuppToolStripMenuItem";
            this.techSuppToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.techSuppToolStripMenuItem.Text = "TechSupp";
            this.techSuppToolStripMenuItem.Click += new System.EventHandler(this.techSuppToolStripMenuItem_Click);
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.groupsToolStripMenuItem.Text = "Groups";
            this.groupsToolStripMenuItem.Click += new System.EventHandler(this.groupsToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 616);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackerHelper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem techSupportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupedByStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newClosedLastYearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newIssuesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timeEntriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashBoardsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem techSuppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
    }
}

