namespace TrackerHelper
{
    partial class Settings
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
            this.btn_OK = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Id = new System.Windows.Forms.TextBox();
            this.tb_CompanyName = new System.Windows.Forms.TextBox();
            this.tb_Position = new System.Windows.Forms.TextBox();
            this.pnl_tools = new System.Windows.Forms.Panel();
            this.pnl_data = new System.Windows.Forms.Panel();
            this.btn_Check = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.tb_Phone = new System.Windows.Forms.TextBox();
            this.tb_internalPhone = new System.Windows.Forms.TextBox();
            this.tb_BaseAddress = new System.Windows.Forms.TextBox();
            this.tb_ApiKey = new System.Windows.Forms.TextBox();
            this.pnl_tools.SuspendLayout();
            this.pnl_data.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_OK
            // 
            this.btn_OK.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_OK.Location = new System.Drawing.Point(0, 0);
            this.btn_OK.Name = "btn_OK";
            this.btn_OK.Size = new System.Drawing.Size(30, 30);
            this.btn_OK.TabIndex = 0;
            this.btn_OK.Text = "OK";
            this.btn_OK.UseVisualStyleBackColor = true;
            this.btn_OK.Click += new System.EventHandler(this.Save_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Enabled = false;
            this.tb_Name.Location = new System.Drawing.Point(5, 5);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(85, 20);
            this.tb_Name.TabIndex = 1;
            // 
            // tb_Id
            // 
            this.tb_Id.Location = new System.Drawing.Point(5, 30);
            this.tb_Id.Name = "tb_Id";
            this.tb_Id.Size = new System.Drawing.Size(85, 20);
            this.tb_Id.TabIndex = 2;
            this.tb_Id.Text = "UserId";
            // 
            // tb_CompanyName
            // 
            this.tb_CompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_CompanyName.Enabled = false;
            this.tb_CompanyName.Location = new System.Drawing.Point(95, 5);
            this.tb_CompanyName.Name = "tb_CompanyName";
            this.tb_CompanyName.Size = new System.Drawing.Size(183, 20);
            this.tb_CompanyName.TabIndex = 3;
            // 
            // tb_Position
            // 
            this.tb_Position.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Position.Enabled = false;
            this.tb_Position.Location = new System.Drawing.Point(95, 30);
            this.tb_Position.Name = "tb_Position";
            this.tb_Position.Size = new System.Drawing.Size(183, 20);
            this.tb_Position.TabIndex = 4;
            // 
            // pnl_tools
            // 
            this.pnl_tools.Controls.Add(this.btn_Cancel);
            this.pnl_tools.Controls.Add(this.btn_Check);
            this.pnl_tools.Controls.Add(this.btn_OK);
            this.pnl_tools.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_tools.Location = new System.Drawing.Point(0, 0);
            this.pnl_tools.Name = "pnl_tools";
            this.pnl_tools.Size = new System.Drawing.Size(284, 30);
            this.pnl_tools.TabIndex = 5;
            // 
            // pnl_data
            // 
            this.pnl_data.Controls.Add(this.tb_ApiKey);
            this.pnl_data.Controls.Add(this.tb_BaseAddress);
            this.pnl_data.Controls.Add(this.tb_internalPhone);
            this.pnl_data.Controls.Add(this.tb_Phone);
            this.pnl_data.Controls.Add(this.tb_Name);
            this.pnl_data.Controls.Add(this.tb_CompanyName);
            this.pnl_data.Controls.Add(this.tb_Position);
            this.pnl_data.Controls.Add(this.tb_Id);
            this.pnl_data.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_data.Location = new System.Drawing.Point(0, 30);
            this.pnl_data.Name = "pnl_data";
            this.pnl_data.Size = new System.Drawing.Size(284, 232);
            this.pnl_data.TabIndex = 6;
            // 
            // btn_Check
            // 
            this.btn_Check.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Check.Location = new System.Drawing.Point(30, 0);
            this.btn_Check.Name = "btn_Check";
            this.btn_Check.Size = new System.Drawing.Size(30, 30);
            this.btn_Check.TabIndex = 1;
            this.btn_Check.Text = "Ch";
            this.btn_Check.UseVisualStyleBackColor = true;
            this.btn_Check.Click += new System.EventHandler(this.btn_Check_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Cancel.Location = new System.Drawing.Point(60, 0);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(30, 30);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Ca";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // tb_Phone
            // 
            this.tb_Phone.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_Phone.Enabled = false;
            this.tb_Phone.Location = new System.Drawing.Point(95, 56);
            this.tb_Phone.Name = "tb_Phone";
            this.tb_Phone.Size = new System.Drawing.Size(183, 20);
            this.tb_Phone.TabIndex = 5;
            // 
            // tb_internalPhone
            // 
            this.tb_internalPhone.Enabled = false;
            this.tb_internalPhone.Location = new System.Drawing.Point(5, 56);
            this.tb_internalPhone.Name = "tb_internalPhone";
            this.tb_internalPhone.Size = new System.Drawing.Size(85, 20);
            this.tb_internalPhone.TabIndex = 6;
            // 
            // tb_BaseAddress
            // 
            this.tb_BaseAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_BaseAddress.Location = new System.Drawing.Point(5, 82);
            this.tb_BaseAddress.Name = "tb_BaseAddress";
            this.tb_BaseAddress.Size = new System.Drawing.Size(273, 20);
            this.tb_BaseAddress.TabIndex = 7;
            this.tb_BaseAddress.Text = "http://test-tracker.ucs.ru/";
            // 
            // tb_ApiKey
            // 
            this.tb_ApiKey.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_ApiKey.Location = new System.Drawing.Point(6, 106);
            this.tb_ApiKey.Name = "tb_ApiKey";
            this.tb_ApiKey.Size = new System.Drawing.Size(273, 20);
            this.tb_ApiKey.TabIndex = 8;
            this.tb_ApiKey.Text = "1287ca3310be20d6992a764b57f9c8bcfbb05664";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.pnl_data);
            this.Controls.Add(this.pnl_tools);
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.pnl_tools.ResumeLayout(false);
            this.pnl_data.ResumeLayout(false);
            this.pnl_data.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_OK;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Id;
        private System.Windows.Forms.TextBox tb_CompanyName;
        private System.Windows.Forms.TextBox tb_Position;
        private System.Windows.Forms.Panel pnl_tools;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Check;
        private System.Windows.Forms.Panel pnl_data;
        private System.Windows.Forms.TextBox tb_internalPhone;
        private System.Windows.Forms.TextBox tb_Phone;
        private System.Windows.Forms.TextBox tb_BaseAddress;
        private System.Windows.Forms.TextBox tb_ApiKey;
    }
}