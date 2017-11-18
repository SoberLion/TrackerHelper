namespace TrackerHelper
{
    partial class SetForm
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
            this.tbApiKey = new System.Windows.Forms.TextBox();
            this.lblApiKey = new System.Windows.Forms.Label();
            this.btnSettingsClose = new System.Windows.Forms.Button();
            this.dateTPFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTPTo = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbApiKey
            // 
            this.tbApiKey.Location = new System.Drawing.Point(12, 22);
            this.tbApiKey.Name = "tbApiKey";
            this.tbApiKey.Size = new System.Drawing.Size(260, 20);
            this.tbApiKey.TabIndex = 0;
            this.tbApiKey.Text = "1287ca3310be20d6992a764b57f9c8bcfbb05664";
            // 
            // lblApiKey
            // 
            this.lblApiKey.AutoSize = true;
            this.lblApiKey.Location = new System.Drawing.Point(12, 6);
            this.lblApiKey.Name = "lblApiKey";
            this.lblApiKey.Size = new System.Drawing.Size(40, 13);
            this.lblApiKey.TabIndex = 1;
            this.lblApiKey.Text = "ApiKey";
            // 
            // btnSettingsClose
            // 
            this.btnSettingsClose.Location = new System.Drawing.Point(106, 289);
            this.btnSettingsClose.Name = "btnSettingsClose";
            this.btnSettingsClose.Size = new System.Drawing.Size(75, 23);
            this.btnSettingsClose.TabIndex = 2;
            this.btnSettingsClose.Text = "Close";
            this.btnSettingsClose.UseVisualStyleBackColor = true;
            this.btnSettingsClose.Click += new System.EventHandler(this.btnSettingsClose_Click);
            // 
            // dateTPFrom
            // 
            this.dateTPFrom.CustomFormat = "";
            this.dateTPFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPFrom.Location = new System.Drawing.Point(12, 60);
            this.dateTPFrom.Name = "dateTPFrom";
            this.dateTPFrom.Size = new System.Drawing.Size(120, 20);
            this.dateTPFrom.TabIndex = 3;
            this.dateTPFrom.Value = new System.DateTime(2017, 6, 1, 0, 0, 0, 0);
            // 
            // dateTPTo
            // 
            this.dateTPTo.CustomFormat = "";
            this.dateTPTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTPTo.Location = new System.Drawing.Point(151, 60);
            this.dateTPTo.Name = "dateTPTo";
            this.dateTPTo.Size = new System.Drawing.Size(120, 20);
            this.dateTPTo.TabIndex = 4;
            this.dateTPTo.Value = new System.DateTime(2017, 6, 30, 0, 0, 0, 0);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTPTo);
            this.Controls.Add(this.dateTPFrom);
            this.Controls.Add(this.btnSettingsClose);
            this.Controls.Add(this.lblApiKey);
            this.Controls.Add(this.tbApiKey);
            this.Name = "SetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblApiKey;
        private System.Windows.Forms.Button btnSettingsClose;
        public System.Windows.Forms.TextBox tbApiKey;
        public System.Windows.Forms.DateTimePicker dateTPFrom;
        public System.Windows.Forms.DateTimePicker dateTPTo;
        private System.Windows.Forms.Button button1;
    }
}