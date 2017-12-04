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
            this.pnlLayoutBot = new System.Windows.Forms.Panel();
            this.lblClosedLastYear = new System.Windows.Forms.Label();
            this.lblNewlastYear = new System.Windows.Forms.Label();
            this.sgClosedLastYear = new LiveCharts.WinForms.SolidGauge();
            this.sgNewLastYear = new LiveCharts.WinForms.SolidGauge();
            this.pnlBotRightCorner = new System.Windows.Forms.Panel();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.pnlWeekFilter = new System.Windows.Forms.Panel();
            this.btnWeek = new System.Windows.Forms.Button();
            this.pnlMonthFilter = new System.Windows.Forms.Panel();
            this.btnMonth = new System.Windows.Forms.Button();
            this.pnlUpdateBtn = new System.Windows.Forms.Panel();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.sgClosed = new LiveCharts.WinForms.SolidGauge();
            this.label3 = new System.Windows.Forms.Label();
            this.sgAssigned = new LiveCharts.WinForms.SolidGauge();
            this.pnlLayoutMid = new System.Windows.Forms.Panel();
            this.pnlLayoutTop = new System.Windows.Forms.Panel();
            this.pnlCartesianChart = new System.Windows.Forms.Panel();
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.pnlTopRight = new System.Windows.Forms.Panel();
            this.pnlProjectsChart = new System.Windows.Forms.Panel();
            this.pieChartStatus = new LiveCharts.WinForms.PieChart();
            this.pnlProjects = new System.Windows.Forms.Panel();
            this.pieChartProjects = new LiveCharts.WinForms.PieChart();
            this.pnlHorizDividerBot = new System.Windows.Forms.Panel();
            this.pnlLayoutBot.SuspendLayout();
            this.pnlBotRightCorner.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlWeekFilter.SuspendLayout();
            this.pnlMonthFilter.SuspendLayout();
            this.pnlUpdateBtn.SuspendLayout();
            this.pnlLayoutMid.SuspendLayout();
            this.pnlLayoutTop.SuspendLayout();
            this.pnlCartesianChart.SuspendLayout();
            this.pnlTopRight.SuspendLayout();
            this.pnlProjectsChart.SuspendLayout();
            this.pnlProjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // sgNewIssues
            // 
            this.sgNewIssues.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sgNewIssues.BackColor = System.Drawing.Color.Transparent;
            this.sgNewIssues.BackColorTransparent = true;
            this.sgNewIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sgNewIssues.ForeColor = System.Drawing.SystemColors.Control;
            this.sgNewIssues.Location = new System.Drawing.Point(13, 31);
            this.sgNewIssues.Name = "sgNewIssues";
            this.sgNewIssues.Size = new System.Drawing.Size(201, 103);
            this.sgNewIssues.TabIndex = 3;
            this.sgNewIssues.TabStop = false;
            // 
            // pnlLayoutBot
            // 
            this.pnlLayoutBot.Controls.Add(this.lblClosedLastYear);
            this.pnlLayoutBot.Controls.Add(this.lblNewlastYear);
            this.pnlLayoutBot.Controls.Add(this.sgClosedLastYear);
            this.pnlLayoutBot.Controls.Add(this.sgNewLastYear);
            this.pnlLayoutBot.Controls.Add(this.pnlBotRightCorner);
            this.pnlLayoutBot.Controls.Add(this.label2);
            this.pnlLayoutBot.Controls.Add(this.label1);
            this.pnlLayoutBot.Controls.Add(this.sgClosed);
            this.pnlLayoutBot.Controls.Add(this.sgNewIssues);
            this.pnlLayoutBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLayoutBot.Location = new System.Drawing.Point(0, 475);
            this.pnlLayoutBot.Name = "pnlLayoutBot";
            this.pnlLayoutBot.Size = new System.Drawing.Size(1034, 147);
            this.pnlLayoutBot.TabIndex = 5;
            // 
            // lblClosedLastYear
            // 
            this.lblClosedLastYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblClosedLastYear.AutoSize = true;
            this.lblClosedLastYear.BackColor = System.Drawing.Color.Transparent;
            this.lblClosedLastYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblClosedLastYear.ForeColor = System.Drawing.Color.White;
            this.lblClosedLastYear.Location = new System.Drawing.Point(684, 8);
            this.lblClosedLastYear.Name = "lblClosedLastYear";
            this.lblClosedLastYear.Size = new System.Drawing.Size(184, 20);
            this.lblClosedLastYear.TabIndex = 11;
            this.lblClosedLastYear.Text = "CLOSED LAST YEAR";
            // 
            // lblNewlastYear
            // 
            this.lblNewlastYear.AutoSize = true;
            this.lblNewlastYear.BackColor = System.Drawing.Color.Transparent;
            this.lblNewlastYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblNewlastYear.ForeColor = System.Drawing.Color.White;
            this.lblNewlastYear.Location = new System.Drawing.Point(483, 8);
            this.lblNewlastYear.Name = "lblNewlastYear";
            this.lblNewlastYear.Size = new System.Drawing.Size(152, 20);
            this.lblNewlastYear.TabIndex = 10;
            this.lblNewlastYear.Text = "NEW LAST YEAR";
            // 
            // sgClosedLastYear
            // 
            this.sgClosedLastYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sgClosedLastYear.BackColor = System.Drawing.Color.Transparent;
            this.sgClosedLastYear.BackColorTransparent = true;
            this.sgClosedLastYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sgClosedLastYear.ForeColor = System.Drawing.SystemColors.Control;
            this.sgClosedLastYear.Location = new System.Drawing.Point(677, 32);
            this.sgClosedLastYear.Name = "sgClosedLastYear";
            this.sgClosedLastYear.Size = new System.Drawing.Size(201, 103);
            this.sgClosedLastYear.TabIndex = 9;
            this.sgClosedLastYear.TabStop = false;
            // 
            // sgNewLastYear
            // 
            this.sgNewLastYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sgNewLastYear.BackColor = System.Drawing.Color.Transparent;
            this.sgNewLastYear.BackColorTransparent = true;
            this.sgNewLastYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sgNewLastYear.ForeColor = System.Drawing.SystemColors.Control;
            this.sgNewLastYear.Location = new System.Drawing.Point(458, 31);
            this.sgNewLastYear.Name = "sgNewLastYear";
            this.sgNewLastYear.Size = new System.Drawing.Size(201, 103);
            this.sgNewLastYear.TabIndex = 8;
            this.sgNewLastYear.TabStop = false;
            // 
            // pnlBotRightCorner
            // 
            this.pnlBotRightCorner.Controls.Add(this.pnlFilters);
            this.pnlBotRightCorner.Controls.Add(this.pnlUpdateBtn);
            this.pnlBotRightCorner.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBotRightCorner.Location = new System.Drawing.Point(884, 0);
            this.pnlBotRightCorner.Name = "pnlBotRightCorner";
            this.pnlBotRightCorner.Size = new System.Drawing.Size(150, 147);
            this.pnlBotRightCorner.TabIndex = 7;
            // 
            // pnlFilters
            // 
            this.pnlFilters.Controls.Add(this.pnlWeekFilter);
            this.pnlFilters.Controls.Add(this.pnlMonthFilter);
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFilters.Location = new System.Drawing.Point(0, 0);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(150, 74);
            this.pnlFilters.TabIndex = 3;
            // 
            // pnlWeekFilter
            // 
            this.pnlWeekFilter.Controls.Add(this.btnWeek);
            this.pnlWeekFilter.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlWeekFilter.Location = new System.Drawing.Point(0, 0);
            this.pnlWeekFilter.Name = "pnlWeekFilter";
            this.pnlWeekFilter.Size = new System.Drawing.Size(75, 74);
            this.pnlWeekFilter.TabIndex = 1;
            // 
            // btnWeek
            // 
            this.btnWeek.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWeek.FlatAppearance.BorderSize = 0;
            this.btnWeek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnWeek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnWeek.ForeColor = System.Drawing.Color.White;
            this.btnWeek.Location = new System.Drawing.Point(0, 0);
            this.btnWeek.Name = "btnWeek";
            this.btnWeek.Size = new System.Drawing.Size(75, 74);
            this.btnWeek.TabIndex = 3;
            this.btnWeek.Text = "   week";
            this.btnWeek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWeek.UseVisualStyleBackColor = false;
            this.btnWeek.Click += new System.EventHandler(this.btnWeek_Click);
            // 
            // pnlMonthFilter
            // 
            this.pnlMonthFilter.Controls.Add(this.btnMonth);
            this.pnlMonthFilter.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMonthFilter.Location = new System.Drawing.Point(75, 0);
            this.pnlMonthFilter.Name = "pnlMonthFilter";
            this.pnlMonthFilter.Size = new System.Drawing.Size(75, 74);
            this.pnlMonthFilter.TabIndex = 0;
            // 
            // btnMonth
            // 
            this.btnMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMonth.FlatAppearance.BorderSize = 0;
            this.btnMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMonth.ForeColor = System.Drawing.Color.White;
            this.btnMonth.Location = new System.Drawing.Point(0, 0);
            this.btnMonth.Name = "btnMonth";
            this.btnMonth.Size = new System.Drawing.Size(75, 74);
            this.btnMonth.TabIndex = 2;
            this.btnMonth.Text = " month";
            this.btnMonth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMonth.UseVisualStyleBackColor = false;
            this.btnMonth.Click += new System.EventHandler(this.btnMonth_Click);
            // 
            // pnlUpdateBtn
            // 
            this.pnlUpdateBtn.Controls.Add(this.btnUpdateData);
            this.pnlUpdateBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpdateBtn.Location = new System.Drawing.Point(0, 74);
            this.pnlUpdateBtn.Name = "pnlUpdateBtn";
            this.pnlUpdateBtn.Size = new System.Drawing.Size(150, 73);
            this.pnlUpdateBtn.TabIndex = 2;
            // 
            // btnUpdateData
            // 
            this.btnUpdateData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnUpdateData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpdateData.FlatAppearance.BorderSize = 0;
            this.btnUpdateData.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnUpdateData.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnUpdateData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdateData.ForeColor = System.Drawing.Color.White;
            this.btnUpdateData.Location = new System.Drawing.Point(0, 0);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(150, 73);
            this.btnUpdateData.TabIndex = 1;
            this.btnUpdateData.Text = "   UPDATE";
            this.btnUpdateData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateData.UseVisualStyleBackColor = false;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(306, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "CLOSED";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(93, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "NEW";
            // 
            // sgClosed
            // 
            this.sgClosed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sgClosed.BackColor = System.Drawing.Color.Transparent;
            this.sgClosed.BackColorTransparent = true;
            this.sgClosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sgClosed.ForeColor = System.Drawing.SystemColors.Control;
            this.sgClosed.Location = new System.Drawing.Point(239, 31);
            this.sgClosed.Name = "sgClosed";
            this.sgClosed.Size = new System.Drawing.Size(201, 103);
            this.sgClosed.TabIndex = 4;
            this.sgClosed.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(61, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "ASSIGNED";
            // 
            // sgAssigned
            // 
            this.sgAssigned.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sgAssigned.BackColor = System.Drawing.Color.Transparent;
            this.sgAssigned.BackColorTransparent = true;
            this.sgAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sgAssigned.ForeColor = System.Drawing.SystemColors.Control;
            this.sgAssigned.Location = new System.Drawing.Point(13, 31);
            this.sgAssigned.Name = "sgAssigned";
            this.sgAssigned.Size = new System.Drawing.Size(201, 102);
            this.sgAssigned.TabIndex = 7;
            this.sgAssigned.TabStop = false;
            // 
            // pnlLayoutMid
            // 
            this.pnlLayoutMid.Controls.Add(this.label3);
            this.pnlLayoutMid.Controls.Add(this.sgAssigned);
            this.pnlLayoutMid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLayoutMid.Location = new System.Drawing.Point(0, 324);
            this.pnlLayoutMid.Name = "pnlLayoutMid";
            this.pnlLayoutMid.Size = new System.Drawing.Size(1034, 147);
            this.pnlLayoutMid.TabIndex = 6;
            // 
            // pnlLayoutTop
            // 
            this.pnlLayoutTop.Controls.Add(this.pnlCartesianChart);
            this.pnlLayoutTop.Controls.Add(this.pnlTopRight);
            this.pnlLayoutTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayoutTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLayoutTop.Name = "pnlLayoutTop";
            this.pnlLayoutTop.Size = new System.Drawing.Size(1034, 324);
            this.pnlLayoutTop.TabIndex = 7;
            // 
            // pnlCartesianChart
            // 
            this.pnlCartesianChart.Controls.Add(this.cartesianChart);
            this.pnlCartesianChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCartesianChart.Location = new System.Drawing.Point(0, 0);
            this.pnlCartesianChart.Name = "pnlCartesianChart";
            this.pnlCartesianChart.Size = new System.Drawing.Size(580, 324);
            this.pnlCartesianChart.TabIndex = 3;
            // 
            // cartesianChart
            // 
            this.cartesianChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cartesianChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cartesianChart.ForeColor = System.Drawing.SystemColors.Control;
            this.cartesianChart.Location = new System.Drawing.Point(0, 0);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Padding = new System.Windows.Forms.Padding(3);
            this.cartesianChart.Size = new System.Drawing.Size(580, 324);
            this.cartesianChart.TabIndex = 0;
            this.cartesianChart.TabStop = false;
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.Controls.Add(this.pnlProjectsChart);
            this.pnlTopRight.Controls.Add(this.pnlProjects);
            this.pnlTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTopRight.Location = new System.Drawing.Point(580, 0);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Size = new System.Drawing.Size(454, 324);
            this.pnlTopRight.TabIndex = 4;
            // 
            // pnlProjectsChart
            // 
            this.pnlProjectsChart.Controls.Add(this.pieChartStatus);
            this.pnlProjectsChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProjectsChart.Location = new System.Drawing.Point(0, 163);
            this.pnlProjectsChart.Name = "pnlProjectsChart";
            this.pnlProjectsChart.Size = new System.Drawing.Size(454, 163);
            this.pnlProjectsChart.TabIndex = 5;
            // 
            // pieChartStatus
            // 
            this.pieChartStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartStatus.Location = new System.Drawing.Point(0, 0);
            this.pieChartStatus.Name = "pieChartStatus";
            this.pieChartStatus.Size = new System.Drawing.Size(454, 163);
            this.pieChartStatus.TabIndex = 0;
            // 
            // pnlProjects
            // 
            this.pnlProjects.Controls.Add(this.pieChartProjects);
            this.pnlProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProjects.Location = new System.Drawing.Point(0, 0);
            this.pnlProjects.Name = "pnlProjects";
            this.pnlProjects.Size = new System.Drawing.Size(454, 163);
            this.pnlProjects.TabIndex = 4;
            // 
            // pieChartProjects
            // 
            this.pieChartProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieChartProjects.Location = new System.Drawing.Point(0, 0);
            this.pieChartProjects.Name = "pieChartProjects";
            this.pieChartProjects.Size = new System.Drawing.Size(454, 163);
            this.pieChartProjects.TabIndex = 0;
            // 
            // pnlHorizDividerBot
            // 
            this.pnlHorizDividerBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.pnlHorizDividerBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHorizDividerBot.Location = new System.Drawing.Point(0, 471);
            this.pnlHorizDividerBot.Name = "pnlHorizDividerBot";
            this.pnlHorizDividerBot.Size = new System.Drawing.Size(1034, 4);
            this.pnlHorizDividerBot.TabIndex = 9;
            // 
            // TSDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.Controls.Add(this.pnlLayoutTop);
            this.Controls.Add(this.pnlLayoutMid);
            this.Controls.Add(this.pnlHorizDividerBot);
            this.Controls.Add(this.pnlLayoutBot);
            this.Name = "TSDashboard";
            this.Size = new System.Drawing.Size(1034, 622);
            this.Load += new System.EventHandler(this.TSDashboard_Load);
            this.pnlLayoutBot.ResumeLayout(false);
            this.pnlLayoutBot.PerformLayout();
            this.pnlBotRightCorner.ResumeLayout(false);
            this.pnlFilters.ResumeLayout(false);
            this.pnlWeekFilter.ResumeLayout(false);
            this.pnlMonthFilter.ResumeLayout(false);
            this.pnlUpdateBtn.ResumeLayout(false);
            this.pnlLayoutMid.ResumeLayout(false);
            this.pnlLayoutMid.PerformLayout();
            this.pnlLayoutTop.ResumeLayout(false);
            this.pnlCartesianChart.ResumeLayout(false);
            this.pnlTopRight.ResumeLayout(false);
            this.pnlProjectsChart.ResumeLayout(false);
            this.pnlProjects.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLayoutBot;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlLayoutMid;
        private System.Windows.Forms.Panel pnlLayoutTop;
        private System.Windows.Forms.Panel pnlProjectsChart;
        private System.Windows.Forms.Panel pnlProjects;
        private System.Windows.Forms.Panel pnlCartesianChart;
        public LiveCharts.WinForms.CartesianChart cartesianChart;
        public LiveCharts.WinForms.PieChart pieChartStatus;
        public LiveCharts.WinForms.PieChart pieChartProjects;
        public LiveCharts.WinForms.SolidGauge sgNewIssues;
        public LiveCharts.WinForms.SolidGauge sgClosed;
        public LiveCharts.WinForms.SolidGauge sgAssigned;
        private System.Windows.Forms.Panel pnlBotRightCorner;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Panel pnlUpdateBtn;
        private System.Windows.Forms.Panel pnlWeekFilter;
        private System.Windows.Forms.Button btnWeek;
        private System.Windows.Forms.Panel pnlMonthFilter;
        private System.Windows.Forms.Button btnMonth;
        private System.Windows.Forms.Panel pnlTopRight;
        private System.Windows.Forms.Label lblClosedLastYear;
        private System.Windows.Forms.Label lblNewlastYear;
        public LiveCharts.WinForms.SolidGauge sgClosedLastYear;
        public LiveCharts.WinForms.SolidGauge sgNewLastYear;
        private System.Windows.Forms.Panel pnlHorizDividerBot;
    }
}
