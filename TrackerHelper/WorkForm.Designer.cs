namespace TrackerHelper
{
    partial class WorkForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.tControl = new System.Windows.Forms.TabControl();
            this.tP_IssueList = new System.Windows.Forms.TabPage();
            this.pnl_TreeView = new System.Windows.Forms.Panel();
            this.treeView_Issues = new System.Windows.Forms.TreeView();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.btn_GetIssues = new System.Windows.Forms.Button();
            this.tp_IssueJournal = new System.Windows.Forms.TabPage();
            this.pnl_listbox = new System.Windows.Forms.Panel();
            this.listbox_IssueJournal = new System.Windows.Forms.ListBox();
            this.pnl_tools = new System.Windows.Forms.Panel();
            this.tControl.SuspendLayout();
            this.tP_IssueList.SuspendLayout();
            this.pnl_TreeView.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.tp_IssueJournal.SuspendLayout();
            this.pnl_listbox.SuspendLayout();
            this.pnl_tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tControl
            // 
            this.tControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tControl.Controls.Add(this.tP_IssueList);
            this.tControl.Controls.Add(this.tp_IssueJournal);
            this.tControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tControl.Location = new System.Drawing.Point(0, 0);
            this.tControl.Name = "tControl";
            this.tControl.SelectedIndex = 0;
            this.tControl.Size = new System.Drawing.Size(305, 420);
            this.tControl.TabIndex = 1;
            // 
            // tP_IssueList
            // 
            this.tP_IssueList.Controls.Add(this.pnl_TreeView);
            this.tP_IssueList.Controls.Add(this.pnl_buttons);
            this.tP_IssueList.Location = new System.Drawing.Point(4, 25);
            this.tP_IssueList.Name = "tP_IssueList";
            this.tP_IssueList.Padding = new System.Windows.Forms.Padding(3);
            this.tP_IssueList.Size = new System.Drawing.Size(297, 391);
            this.tP_IssueList.TabIndex = 1;
            this.tP_IssueList.Text = "Issues";
            this.tP_IssueList.UseVisualStyleBackColor = true;
            // 
            // pnl_TreeView
            // 
            this.pnl_TreeView.Controls.Add(this.treeView_Issues);
            this.pnl_TreeView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_TreeView.Location = new System.Drawing.Point(3, 34);
            this.pnl_TreeView.Name = "pnl_TreeView";
            this.pnl_TreeView.Size = new System.Drawing.Size(291, 354);
            this.pnl_TreeView.TabIndex = 2;
            // 
            // treeView_Issues
            // 
            this.treeView_Issues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Issues.Location = new System.Drawing.Point(0, 0);
            this.treeView_Issues.Name = "treeView_Issues";
            this.treeView_Issues.Size = new System.Drawing.Size(291, 354);
            this.treeView_Issues.TabIndex = 0;
            this.treeView_Issues.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_Issues_NodeMouseDoubleClick);
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.btn_GetIssues);
            this.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_buttons.Location = new System.Drawing.Point(3, 3);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(291, 31);
            this.pnl_buttons.TabIndex = 1;
            // 
            // btn_GetIssues
            // 
            this.btn_GetIssues.Location = new System.Drawing.Point(3, 3);
            this.btn_GetIssues.Name = "btn_GetIssues";
            this.btn_GetIssues.Size = new System.Drawing.Size(75, 23);
            this.btn_GetIssues.TabIndex = 0;
            this.btn_GetIssues.Text = "GetIssues";
            this.btn_GetIssues.UseVisualStyleBackColor = true;
            this.btn_GetIssues.Click += new System.EventHandler(this.btn_GetIssues_Click);
            // 
            // tp_IssueJournal
            // 
            this.tp_IssueJournal.Controls.Add(this.pnl_listbox);
            this.tp_IssueJournal.Controls.Add(this.pnl_tools);
            this.tp_IssueJournal.Location = new System.Drawing.Point(4, 25);
            this.tp_IssueJournal.Name = "tp_IssueJournal";
            this.tp_IssueJournal.Padding = new System.Windows.Forms.Padding(3);
            this.tp_IssueJournal.Size = new System.Drawing.Size(297, 391);
            this.tp_IssueJournal.TabIndex = 0;
            this.tp_IssueJournal.Text = "Issue #";
            this.tp_IssueJournal.UseVisualStyleBackColor = true;
            // 
            // pnl_listbox
            // 
            this.pnl_listbox.Controls.Add(this.listbox_IssueJournal);
            this.pnl_listbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_listbox.Location = new System.Drawing.Point(3, 33);
            this.pnl_listbox.Name = "pnl_listbox";
            this.pnl_listbox.Size = new System.Drawing.Size(291, 355);
            this.pnl_listbox.TabIndex = 2;
            // 
            // listbox_IssueJournal
            // 
            this.listbox_IssueJournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listbox_IssueJournal.FormattingEnabled = true;
            this.listbox_IssueJournal.Location = new System.Drawing.Point(0, 0);
            this.listbox_IssueJournal.Name = "listbox_IssueJournal";
            this.listbox_IssueJournal.Size = new System.Drawing.Size(291, 355);
            this.listbox_IssueJournal.TabIndex = 0;
            // 
            // pnl_tools
            // 
            this.pnl_tools.Controls.Add(this.button1);
            this.pnl_tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_tools.Location = new System.Drawing.Point(3, 3);
            this.pnl_tools.Name = "pnl_tools";
            this.pnl_tools.Size = new System.Drawing.Size(291, 30);
            this.pnl_tools.TabIndex = 1;
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 420);
            this.Controls.Add(this.tControl);
            this.Name = "WorkForm";
            this.Text = "WorkForm";
            this.tControl.ResumeLayout(false);
            this.tP_IssueList.ResumeLayout(false);
            this.pnl_TreeView.ResumeLayout(false);
            this.pnl_buttons.ResumeLayout(false);
            this.tp_IssueJournal.ResumeLayout(false);
            this.pnl_listbox.ResumeLayout(false);
            this.pnl_tools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl tControl;
        private System.Windows.Forms.TabPage tp_IssueJournal;
        private System.Windows.Forms.TabPage tP_IssueList;
        private System.Windows.Forms.Button btn_GetIssues;
        private System.Windows.Forms.Panel pnl_TreeView;
        private System.Windows.Forms.TreeView treeView_Issues;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Panel pnl_listbox;
        private System.Windows.Forms.Panel pnl_tools;
        private System.Windows.Forms.ListBox listbox_IssueJournal;
    }
}