namespace TrackerHelper
{
    partial class TSDashboard
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
            this.sgNewIssues = new LiveCharts.WinForms.SolidGauge();
            this.pnlBotLayer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sgClosed = new LiveCharts.WinForms.SolidGauge();
            this.label3 = new System.Windows.Forms.Label();
            this.sgAssigned = new LiveCharts.WinForms.SolidGauge();
            this.pnlMidLayer = new System.Windows.Forms.Panel();
            this.pnlLayerTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pieChartStatus = new LiveCharts.WinForms.PieChart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pieChartProjects = new LiveCharts.WinForms.PieChart();
            this.pnlCartesianChart = new System.Windows.Forms.Panel();
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.pnlBotLayer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlMidLayer.SuspendLayout();
            this.pnlLayerTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlCartesianChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // sgNewIssues
            // 
            this.sgNewIssues.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sgNewIssues.BackColorTransparent = true;
            this.sgNewIssues.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sgNewIssues.ForeColor = System.Drawing.SystemColors.Control;
            this.sgNewIssues.Location = new System.Drawing.Point(13, 31);
            this.sgNewIssues.Name = "sgNewIssues";
            this.sgNewIssues.Size = new System.Drawing.Size(201, 103);
            this.sgNewIssues.TabIndex = 3;
            this.sgNewIssues.TabStop = false;
            // 
            // pnlBotLayer
            // 
            this.pnlBotLayer.Controls.Add(this.panel3);
            this.pnlBotLayer.Controls.Add(this.label2);
            this.pnlBotLayer.Controls.Add(this.label1);
            this.pnlBotLayer.Controls.Add(this.sgClosed);
            this.pnlBotLayer.Controls.Add(this.sgNewIssues);
            this.pnlBotLayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotLayer.Location = new System.Drawing.Point(0, 475);
            this.pnlBotLayer.Name = "pnlBotLayer";
            this.pnlBotLayer.Size = new System.Drawing.Size(1034, 147);
            this.pnlBotLayer.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnUpdateData);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(834, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 147);
            this.panel3.TabIndex = 7;
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(192)))), ((int)(((byte)(7)))));
            this.btnUpdateData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateData.FlatAppearance.BorderSize = 0;
            this.btnUpdateData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnUpdateData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnUpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateData.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateData.ForeColor = System.Drawing.Color.White;
            this.btnUpdateData.Location = new System.Drawing.Point(0, 0);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(200, 147);
            this.btnUpdateData.TabIndex = 1;
            this.btnUpdateData.Text = "      UPDATE DATA";
            this.btnUpdateData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateData.UseVisualStyleBackColor = false;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(306, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "CLOSED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "NEW";
            // 
            // sgClosed
            // 
            this.sgClosed.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sgClosed.BackColorTransparent = true;
            this.sgClosed.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sgClosed.ForeColor = System.Drawing.SystemColors.Control;
            this.sgClosed.Location = new System.Drawing.Point(239, 31);
            this.sgClosed.Name = "sgClosed";
            this.sgClosed.Size = new System.Drawing.Size(201, 103);
            this.sgClosed.TabIndex = 4;
            this.sgClosed.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(69, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "ASSIGNED";
            // 
            // sgAssigned
            // 
            this.sgAssigned.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sgAssigned.BackColorTransparent = true;
            this.sgAssigned.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sgAssigned.ForeColor = System.Drawing.SystemColors.Control;
            this.sgAssigned.Location = new System.Drawing.Point(13, 41);
            this.sgAssigned.Name = "sgAssigned";
            this.sgAssigned.Size = new System.Drawing.Size(201, 102);
            this.sgAssigned.TabIndex = 7;
            this.sgAssigned.TabStop = false;
            // 
            // pnlMidLayer
            // 
            this.pnlMidLayer.Controls.Add(this.label3);
            this.pnlMidLayer.Controls.Add(this.sgAssigned);
            this.pnlMidLayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMidLayer.Location = new System.Drawing.Point(0, 326);
            this.pnlMidLayer.Name = "pnlMidLayer";
            this.pnlMidLayer.Size = new System.Drawing.Size(1034, 149);
            this.pnlMidLayer.TabIndex = 6;
            // 
            // pnlLayerTop
            // 
            this.pnlLayerTop.Controls.Add(this.panel2);
            this.pnlLayerTop.Controls.Add(this.panel1);
            this.pnlLayerTop.Controls.Add(this.pnlCartesianChart);
            this.pnlLayerTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayerTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLayerTop.Name = "pnlLayerTop";
            this.pnlLayerTop.Size = new System.Drawing.Size(1034, 326);
            this.pnlLayerTop.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pieChartStatus);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(532, 163);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(502, 163);
            this.panel2.TabIndex = 5;
            // 
            // pieChartStatus
            // 
            this.pieChartStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartStatus.Location = new System.Drawing.Point(0, 0);
            this.pieChartStatus.Name = "pieChartStatus";
            this.pieChartStatus.Size = new System.Drawing.Size(502, 163);
            this.pieChartStatus.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pieChartProjects);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(532, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(502, 163);
            this.panel1.TabIndex = 4;
            // 
            // pieChartProjects
            // 
            this.pieChartProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartProjects.Location = new System.Drawing.Point(0, 0);
            this.pieChartProjects.Name = "pieChartProjects";
            this.pieChartProjects.Size = new System.Drawing.Size(502, 163);
            this.pieChartProjects.TabIndex = 0;
            // 
            // pnlCartesianChart
            // 
            this.pnlCartesianChart.Controls.Add(this.cartesianChart);
            this.pnlCartesianChart.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlCartesianChart.Location = new System.Drawing.Point(0, 0);
            this.pnlCartesianChart.Name = "pnlCartesianChart";
            this.pnlCartesianChart.Size = new System.Drawing.Size(532, 326);
            this.pnlCartesianChart.TabIndex = 3;
            // 
            // cartesianChart
            // 
            this.cartesianChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cartesianChart.ForeColor = System.Drawing.SystemColors.Control;
            this.cartesianChart.Location = new System.Drawing.Point(0, 0);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Size = new System.Drawing.Size(532, 326);
            this.cartesianChart.TabIndex = 0;
            this.cartesianChart.TabStop = false;
            // 
            // TSDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.pnlLayerTop);
            this.Controls.Add(this.pnlMidLayer);
            this.Controls.Add(this.pnlBotLayer);
            this.Name = "TSDashboard";
            this.Size = new System.Drawing.Size(1034, 622);
            this.Load += new System.EventHandler(this.TSDashboard_Load);
            this.pnlBotLayer.ResumeLayout(false);
            this.pnlBotLayer.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlMidLayer.ResumeLayout(false);
            this.pnlMidLayer.PerformLayout();
            this.pnlLayerTop.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlCartesianChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlBotLayer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlMidLayer;
        private System.Windows.Forms.Panel pnlLayerTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlCartesianChart;
        public LiveCharts.WinForms.CartesianChart cartesianChart;
        public LiveCharts.WinForms.PieChart pieChartStatus;
        public LiveCharts.WinForms.PieChart pieChartProjects;
        public LiveCharts.WinForms.SolidGauge sgNewIssues;
        public LiveCharts.WinForms.SolidGauge sgClosed;
        public LiveCharts.WinForms.SolidGauge sgAssigned;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnUpdateData;
    }
}
