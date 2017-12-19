namespace TrackerHelper.Controls
{
    partial class DashboardSettingsInfo
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.clbEmployees = new System.Windows.Forms.CheckedListBox();
            this.pnlEmployees = new System.Windows.Forms.Panel();
            this.pnlProjects = new System.Windows.Forms.Panel();
            this.clbProjects = new System.Windows.Forms.CheckedListBox();
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.clbStatus = new System.Windows.Forms.CheckedListBox();
            this.pnlStatusPreset = new System.Windows.Forms.Panel();
            this.pnlEmployees.SuspendLayout();
            this.pnlProjects.SuspendLayout();
            this.pnlStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbEmployees
            // 
            this.clbEmployees.CheckOnClick = true;
            this.clbEmployees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbEmployees.FormattingEnabled = true;
            this.clbEmployees.Location = new System.Drawing.Point(0, 0);
            this.clbEmployees.Name = "clbEmployees";
            this.clbEmployees.Size = new System.Drawing.Size(300, 966);
            this.clbEmployees.TabIndex = 0;
            // 
            // pnlEmployees
            // 
            this.pnlEmployees.Controls.Add(this.clbEmployees);
            this.pnlEmployees.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlEmployees.Location = new System.Drawing.Point(0, 0);
            this.pnlEmployees.Name = "pnlEmployees";
            this.pnlEmployees.Size = new System.Drawing.Size(300, 966);
            this.pnlEmployees.TabIndex = 1;
            // 
            // pnlProjects
            // 
            this.pnlProjects.Controls.Add(this.clbProjects);
            this.pnlProjects.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProjects.Location = new System.Drawing.Point(300, 0);
            this.pnlProjects.Name = "pnlProjects";
            this.pnlProjects.Size = new System.Drawing.Size(300, 966);
            this.pnlProjects.TabIndex = 2;
            // 
            // clbProjects
            // 
            this.clbProjects.CheckOnClick = true;
            this.clbProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbProjects.FormattingEnabled = true;
            this.clbProjects.Location = new System.Drawing.Point(0, 0);
            this.clbProjects.Name = "clbProjects";
            this.clbProjects.Size = new System.Drawing.Size(300, 966);
            this.clbProjects.TabIndex = 0;
            // 
            // pnlStatus
            // 
            this.pnlStatus.Controls.Add(this.clbStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlStatus.Location = new System.Drawing.Point(600, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(300, 966);
            this.pnlStatus.TabIndex = 3;
            // 
            // clbStatus
            // 
            this.clbStatus.CheckOnClick = true;
            this.clbStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clbStatus.FormattingEnabled = true;
            this.clbStatus.Location = new System.Drawing.Point(0, 0);
            this.clbStatus.Name = "clbStatus";
            this.clbStatus.Size = new System.Drawing.Size(300, 966);
            this.clbStatus.TabIndex = 0;
            this.clbStatus.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbStatus_ItemCheck);
            // 
            // pnlStatusPreset
            // 
            this.pnlStatusPreset.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlStatusPreset.Location = new System.Drawing.Point(900, 0);
            this.pnlStatusPreset.Name = "pnlStatusPreset";
            this.pnlStatusPreset.Size = new System.Drawing.Size(816, 966);
            this.pnlStatusPreset.TabIndex = 4;
            // 
            // DashboardSettingsInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlStatusPreset);
            this.Controls.Add(this.pnlStatus);
            this.Controls.Add(this.pnlProjects);
            this.Controls.Add(this.pnlEmployees);
            this.Name = "DashboardSettingsInfo";
            this.Size = new System.Drawing.Size(1716, 966);
            this.pnlEmployees.ResumeLayout(false);
            this.pnlProjects.ResumeLayout(false);
            this.pnlStatus.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbEmployees;
        private System.Windows.Forms.Panel pnlEmployees;
        private System.Windows.Forms.Panel pnlProjects;
        private System.Windows.Forms.CheckedListBox clbProjects;
        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.CheckedListBox clbStatus;
        private System.Windows.Forms.Panel pnlStatusPreset;
    }
}
