namespace TrackerHelper.Controls
{
    partial class DashboardTime
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
            this.pnlLayoutBot = new System.Windows.Forms.Panel();
            this.pnlLayoutMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlLayoutBot
            // 
            this.pnlLayoutBot.BackColor = System.Drawing.Color.Transparent;
            this.pnlLayoutBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLayoutBot.Location = new System.Drawing.Point(0, 630);
            this.pnlLayoutBot.Name = "pnlLayoutBot";
            this.pnlLayoutBot.Size = new System.Drawing.Size(1200, 170);
            this.pnlLayoutBot.TabIndex = 0;
            // 
            // pnlLayoutMain
            // 
            this.pnlLayoutMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlLayoutMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayoutMain.Location = new System.Drawing.Point(0, 0);
            this.pnlLayoutMain.Name = "pnlLayoutMain";
            this.pnlLayoutMain.Size = new System.Drawing.Size(1200, 630);
            this.pnlLayoutMain.TabIndex = 1;
            // 
            // DashboardTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.pnlLayoutMain);
            this.Controls.Add(this.pnlLayoutBot);
            this.Name = "DashboardTime";
            this.Size = new System.Drawing.Size(1200, 800);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLayoutBot;
        private System.Windows.Forms.Panel pnlLayoutMain;
    }
}
