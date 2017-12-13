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
            this.tControl = new System.Windows.Forms.TabControl();
            this.tP_IssueList = new System.Windows.Forms.TabPage();
            this.pnl_TreeView = new System.Windows.Forms.Panel();
            this.treeView_Issues = new System.Windows.Forms.TreeView();
            this.pnl_buttons = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.btn_UpdateIssues = new System.Windows.Forms.Button();
            this.dtPicker_IssuesTo = new System.Windows.Forms.DateTimePicker();
            this.dtPicker_IssuesFrom = new System.Windows.Forms.DateTimePicker();
            this.btn_GetAllIssues = new System.Windows.Forms.Button();
            this.tp_IssueJournal = new System.Windows.Forms.TabPage();
            this.pnl_listbox = new System.Windows.Forms.Panel();
            this.listbox_IssueJournal = new System.Windows.Forms.ListBox();
            this.pnl_tools = new System.Windows.Forms.Panel();
            this.btnUpdateTE = new System.Windows.Forms.Button();
            this.tbNumOfDays = new System.Windows.Forms.TextBox();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.pbBGWork = new System.Windows.Forms.ProgressBar();
            this.tControl.SuspendLayout();
            this.tP_IssueList.SuspendLayout();
            this.pnl_TreeView.SuspendLayout();
            this.pnl_buttons.SuspendLayout();
            this.tp_IssueJournal.SuspendLayout();
            this.pnl_listbox.SuspendLayout();
            this.pnl_tools.SuspendLayout();
            this.SuspendLayout();
            // 
            // tControl
            // 
            this.tControl.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tControl.Controls.Add(this.tP_IssueList);
            this.tControl.Controls.Add(this.tp_IssueJournal);
            this.tControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tControl.Location = new System.Drawing.Point(0, 10);
            this.tControl.Name = "tControl";
            this.tControl.SelectedIndex = 0;
            this.tControl.Size = new System.Drawing.Size(334, 602);
            this.tControl.TabIndex = 1;
            // 
            // tP_IssueList
            // 
            this.tP_IssueList.Controls.Add(this.pnl_TreeView);
            this.tP_IssueList.Controls.Add(this.pnl_buttons);
            this.tP_IssueList.Location = new System.Drawing.Point(4, 25);
            this.tP_IssueList.Name = "tP_IssueList";
            this.tP_IssueList.Padding = new System.Windows.Forms.Padding(3);
            this.tP_IssueList.Size = new System.Drawing.Size(326, 583);
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
            this.pnl_TreeView.Size = new System.Drawing.Size(320, 546);
            this.pnl_TreeView.TabIndex = 2;
            // 
            // treeView_Issues
            // 
            this.treeView_Issues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView_Issues.Location = new System.Drawing.Point(0, 0);
            this.treeView_Issues.Name = "treeView_Issues";
            this.treeView_Issues.Size = new System.Drawing.Size(320, 546);
            this.treeView_Issues.TabIndex = 0;
            this.treeView_Issues.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView_Issues_NodeMouseDoubleClick);
            // 
            // pnl_buttons
            // 
            this.pnl_buttons.Controls.Add(this.checkBox1);
            this.pnl_buttons.Controls.Add(this.btn_UpdateIssues);
            this.pnl_buttons.Controls.Add(this.dtPicker_IssuesTo);
            this.pnl_buttons.Controls.Add(this.dtPicker_IssuesFrom);
            this.pnl_buttons.Controls.Add(this.btn_GetAllIssues);
            this.pnl_buttons.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_buttons.Location = new System.Drawing.Point(3, 3);
            this.pnl_buttons.Name = "pnl_buttons";
            this.pnl_buttons.Size = new System.Drawing.Size(320, 31);
            this.pnl_buttons.TabIndex = 1;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(77, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // btn_UpdateIssues
            // 
            this.btn_UpdateIssues.Location = new System.Drawing.Point(39, 3);
            this.btn_UpdateIssues.Name = "btn_UpdateIssues";
            this.btn_UpdateIssues.Size = new System.Drawing.Size(32, 24);
            this.btn_UpdateIssues.TabIndex = 3;
            this.btn_UpdateIssues.Text = "GetIssues";
            this.btn_UpdateIssues.UseVisualStyleBackColor = true;
            this.btn_UpdateIssues.Click += new System.EventHandler(this.btn_UpdateIssues_Click);
            // 
            // dtPicker_IssuesTo
            // 
            this.dtPicker_IssuesTo.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtPicker_IssuesTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker_IssuesTo.Location = new System.Drawing.Point(194, 5);
            this.dtPicker_IssuesTo.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtPicker_IssuesTo.Name = "dtPicker_IssuesTo";
            this.dtPicker_IssuesTo.Size = new System.Drawing.Size(89, 22);
            this.dtPicker_IssuesTo.TabIndex = 2;
            // 
            // dtPicker_IssuesFrom
            // 
            this.dtPicker_IssuesFrom.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtPicker_IssuesFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker_IssuesFrom.Location = new System.Drawing.Point(99, 5);
            this.dtPicker_IssuesFrom.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dtPicker_IssuesFrom.Name = "dtPicker_IssuesFrom";
            this.dtPicker_IssuesFrom.Size = new System.Drawing.Size(89, 22);
            this.dtPicker_IssuesFrom.TabIndex = 1;
            // 
            // btn_GetAllIssues
            // 
            this.btn_GetAllIssues.Location = new System.Drawing.Point(3, 3);
            this.btn_GetAllIssues.Name = "btn_GetAllIssues";
            this.btn_GetAllIssues.Size = new System.Drawing.Size(32, 24);
            this.btn_GetAllIssues.TabIndex = 0;
            this.btn_GetAllIssues.Text = "GetIssues";
            this.btn_GetAllIssues.UseVisualStyleBackColor = true;
            this.btn_GetAllIssues.Click += new System.EventHandler(this.btn_GetIssues_Click);
            // 
            // tp_IssueJournal
            // 
            this.tp_IssueJournal.Controls.Add(this.pnl_listbox);
            this.tp_IssueJournal.Controls.Add(this.pnl_tools);
            this.tp_IssueJournal.Location = new System.Drawing.Point(4, 25);
            this.tp_IssueJournal.Name = "tp_IssueJournal";
            this.tp_IssueJournal.Padding = new System.Windows.Forms.Padding(3);
            this.tp_IssueJournal.Size = new System.Drawing.Size(326, 573);
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
            this.pnl_listbox.Size = new System.Drawing.Size(320, 537);
            this.pnl_listbox.TabIndex = 2;
            // 
            // listbox_IssueJournal
            // 
            this.listbox_IssueJournal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listbox_IssueJournal.FormattingEnabled = true;
            this.listbox_IssueJournal.Location = new System.Drawing.Point(0, 0);
            this.listbox_IssueJournal.Name = "listbox_IssueJournal";
            this.listbox_IssueJournal.Size = new System.Drawing.Size(320, 537);
            this.listbox_IssueJournal.TabIndex = 0;
            // 
            // pnl_tools
            // 
            this.pnl_tools.Controls.Add(this.btnUpdateTE);
            this.pnl_tools.Controls.Add(this.tbNumOfDays);
            this.pnl_tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_tools.Location = new System.Drawing.Point(3, 3);
            this.pnl_tools.Name = "pnl_tools";
            this.pnl_tools.Size = new System.Drawing.Size(320, 30);
            this.pnl_tools.TabIndex = 1;
            // 
            // btnUpdateTE
            // 
            this.btnUpdateTE.Location = new System.Drawing.Point(60, 4);
            this.btnUpdateTE.Name = "btnUpdateTE";
            this.btnUpdateTE.Size = new System.Drawing.Size(90, 23);
            this.btnUpdateTE.TabIndex = 3;
            this.btnUpdateTE.Text = "Update";
            this.btnUpdateTE.UseVisualStyleBackColor = true;
            this.btnUpdateTE.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbNumOfDays
            // 
            this.tbNumOfDays.Location = new System.Drawing.Point(6, 4);
            this.tbNumOfDays.Name = "tbNumOfDays";
            this.tbNumOfDays.Size = new System.Drawing.Size(48, 21);
            this.tbNumOfDays.TabIndex = 2;
            this.tbNumOfDays.Text = "1";
            // 
            // bgWorker
            // 
            this.bgWorker.WorkerReportsProgress = true;
            this.bgWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWorker_DoWork);
            this.bgWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWorker_ProgressChanged);
            this.bgWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWorker_RunWorkerCompleted);
            // 
            // pbBGWork
            // 
            this.pbBGWork.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbBGWork.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pbBGWork.Location = new System.Drawing.Point(0, 0);
            this.pbBGWork.Name = "pbBGWork";
            this.pbBGWork.Size = new System.Drawing.Size(334, 10);
            this.pbBGWork.TabIndex = 3;
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 612);
            this.Controls.Add(this.tControl);
            this.Controls.Add(this.pbBGWork);
            this.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "WorkForm";
            this.Text = "WorkForm";
            this.tControl.ResumeLayout(false);
            this.tP_IssueList.ResumeLayout(false);
            this.pnl_TreeView.ResumeLayout(false);
            this.pnl_buttons.ResumeLayout(false);
            this.pnl_buttons.PerformLayout();
            this.tp_IssueJournal.ResumeLayout(false);
            this.pnl_listbox.ResumeLayout(false);
            this.pnl_tools.ResumeLayout(false);
            this.pnl_tools.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tControl;
        private System.Windows.Forms.TabPage tp_IssueJournal;
        private System.Windows.Forms.TabPage tP_IssueList;
        private System.Windows.Forms.Button btn_GetAllIssues;
        private System.Windows.Forms.Panel pnl_TreeView;
        private System.Windows.Forms.TreeView treeView_Issues;
        private System.Windows.Forms.Panel pnl_buttons;
        private System.Windows.Forms.Panel pnl_listbox;
        private System.Windows.Forms.Panel pnl_tools;
        private System.Windows.Forms.ListBox listbox_IssueJournal;
        private System.Windows.Forms.DateTimePicker dtPicker_IssuesTo;
        private System.Windows.Forms.DateTimePicker dtPicker_IssuesFrom;
        private System.Windows.Forms.Button btn_UpdateIssues;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox tbNumOfDays;
        private System.Windows.Forms.Button btnUpdateTE;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.ProgressBar pbBGWork;
    }
}