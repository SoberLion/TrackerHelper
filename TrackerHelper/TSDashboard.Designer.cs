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
            this.lblIssuesClosedLastYear = new System.Windows.Forms.Label();
            this.lblIssuesCreatedLastYear = new System.Windows.Forms.Label();
            this.sgClosedLastYear = new LiveCharts.WinForms.SolidGauge();
            this.sgNewLastYear = new LiveCharts.WinForms.SolidGauge();
            this.pnlBotRightCorner = new System.Windows.Forms.Panel();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.pnlWeekFilter = new System.Windows.Forms.Panel();
            this.btnWeek = new TrackerHelper.CheckedButton();
            this.pnlMonthFilter = new System.Windows.Forms.Panel();
            this.btnMonth = new TrackerHelper.CheckedButton();
            this.pnlUpdateBtn = new System.Windows.Forms.Panel();
            this.btnUpdateData = new System.Windows.Forms.Button();
            this.lblIssuesClosed = new System.Windows.Forms.Label();
            this.lblIssuesCreated = new System.Windows.Forms.Label();
            this.sgClosed = new LiveCharts.WinForms.SolidGauge();
            this.lblStatusAssigned = new System.Windows.Forms.Label();
            this.pnlLayoutMid = new System.Windows.Forms.Panel();
            this.pnlLayoutTop = new System.Windows.Forms.Panel();
            this.pnlCartesianChart = new System.Windows.Forms.Panel();
            this.cartesianChart = new LiveCharts.WinForms.CartesianChart();
            this.pnlTopRight = new System.Windows.Forms.Panel();
            this.pnlStatusChart = new System.Windows.Forms.Panel();
            this.pieChartStatus = new LiveCharts.WinForms.PieChart();
            this.pnlProjects = new System.Windows.Forms.Panel();
            this.pieChartProjects = new LiveCharts.WinForms.PieChart();
            this.pnlHorizDividerBot = new System.Windows.Forms.Panel();
            this.lblStatusNew = new System.Windows.Forms.Label();
            this.pnlStatusNew = new System.Windows.Forms.Panel();
            this.lblStatusNewValue = new System.Windows.Forms.Label();
            this.pnlStatusAssigned = new System.Windows.Forms.Panel();
            this.lblStatusAssignedValue = new System.Windows.Forms.Label();
            this.pnlStatusEscalated = new System.Windows.Forms.Panel();
            this.lblStatusEscalatedValue = new System.Windows.Forms.Label();
            this.lblStatusEscalated = new System.Windows.Forms.Label();
            this.lblStatusNewOverduedValue = new System.Windows.Forms.Label();
            this.lblPnlStatusHeader = new System.Windows.Forms.Label();
            this.pnlTopMid = new System.Windows.Forms.Panel();
            this.pnlLayoutBot.SuspendLayout();
            this.pnlBotRightCorner.SuspendLayout();
            this.pnlFilters.SuspendLayout();
            this.pnlWeekFilter.SuspendLayout();
            this.pnlMonthFilter.SuspendLayout();
            this.pnlUpdateBtn.SuspendLayout();
            this.pnlLayoutMid.SuspendLayout();
            this.pnlLayoutTop.SuspendLayout();
            this.pnlCartesianChart.SuspendLayout();
            this.pnlStatusChart.SuspendLayout();
            this.pnlProjects.SuspendLayout();
            this.pnlStatusNew.SuspendLayout();
            this.pnlStatusAssigned.SuspendLayout();
            this.pnlStatusEscalated.SuspendLayout();
            this.pnlTopMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // sgNewIssues
            // 
            this.sgNewIssues.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sgNewIssues.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sgNewIssues.BackColorTransparent = true;
            this.sgNewIssues.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sgNewIssues.ForeColor = System.Drawing.SystemColors.Control;
            this.sgNewIssues.Location = new System.Drawing.Point(10, 34);
            this.sgNewIssues.Name = "sgNewIssues";
            this.sgNewIssues.Size = new System.Drawing.Size(200, 103);
            this.sgNewIssues.TabIndex = 3;
            this.sgNewIssues.TabStop = false;
            // 
            // pnlLayoutBot
            // 
            this.pnlLayoutBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlLayoutBot.Controls.Add(this.lblIssuesClosedLastYear);
            this.pnlLayoutBot.Controls.Add(this.lblIssuesCreatedLastYear);
            this.pnlLayoutBot.Controls.Add(this.sgClosedLastYear);
            this.pnlLayoutBot.Controls.Add(this.sgNewLastYear);
            this.pnlLayoutBot.Controls.Add(this.pnlBotRightCorner);
            this.pnlLayoutBot.Controls.Add(this.lblIssuesClosed);
            this.pnlLayoutBot.Controls.Add(this.lblIssuesCreated);
            this.pnlLayoutBot.Controls.Add(this.sgClosed);
            this.pnlLayoutBot.Controls.Add(this.sgNewIssues);
            this.pnlLayoutBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLayoutBot.Location = new System.Drawing.Point(0, 475);
            this.pnlLayoutBot.Name = "pnlLayoutBot";
            this.pnlLayoutBot.Size = new System.Drawing.Size(1200, 147);
            this.pnlLayoutBot.TabIndex = 5;
            // 
            // lblIssuesClosedLastYear
            // 
            this.lblIssuesClosedLastYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIssuesClosedLastYear.AutoSize = true;
            this.lblIssuesClosedLastYear.BackColor = System.Drawing.Color.Transparent;
            this.lblIssuesClosedLastYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIssuesClosedLastYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblIssuesClosedLastYear.Location = new System.Drawing.Point(663, 12);
            this.lblIssuesClosedLastYear.Name = "lblIssuesClosedLastYear";
            this.lblIssuesClosedLastYear.Size = new System.Drawing.Size(166, 20);
            this.lblIssuesClosedLastYear.TabIndex = 11;
            this.lblIssuesClosedLastYear.Text = "CLOSED (last year)";
            // 
            // lblIssuesCreatedLastYear
            // 
            this.lblIssuesCreatedLastYear.AutoSize = true;
            this.lblIssuesCreatedLastYear.BackColor = System.Drawing.Color.Transparent;
            this.lblIssuesCreatedLastYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIssuesCreatedLastYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblIssuesCreatedLastYear.Location = new System.Drawing.Point(471, 12);
            this.lblIssuesCreatedLastYear.Name = "lblIssuesCreatedLastYear";
            this.lblIssuesCreatedLastYear.Size = new System.Drawing.Size(134, 20);
            this.lblIssuesCreatedLastYear.TabIndex = 10;
            this.lblIssuesCreatedLastYear.Text = "NEW (last year)";
            // 
            // sgClosedLastYear
            // 
            this.sgClosedLastYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sgClosedLastYear.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sgClosedLastYear.BackColorTransparent = true;
            this.sgClosedLastYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sgClosedLastYear.ForeColor = System.Drawing.SystemColors.Control;
            this.sgClosedLastYear.Location = new System.Drawing.Point(640, 34);
            this.sgClosedLastYear.Name = "sgClosedLastYear";
            this.sgClosedLastYear.Size = new System.Drawing.Size(200, 103);
            this.sgClosedLastYear.TabIndex = 9;
            this.sgClosedLastYear.TabStop = false;
            // 
            // sgNewLastYear
            // 
            this.sgNewLastYear.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sgNewLastYear.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sgNewLastYear.BackColorTransparent = true;
            this.sgNewLastYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sgNewLastYear.ForeColor = System.Drawing.SystemColors.Control;
            this.sgNewLastYear.Location = new System.Drawing.Point(430, 34);
            this.sgNewLastYear.Name = "sgNewLastYear";
            this.sgNewLastYear.Size = new System.Drawing.Size(200, 103);
            this.sgNewLastYear.TabIndex = 8;
            this.sgNewLastYear.TabStop = false;
            // 
            // pnlBotRightCorner
            // 
            this.pnlBotRightCorner.Controls.Add(this.pnlFilters);
            this.pnlBotRightCorner.Controls.Add(this.pnlUpdateBtn);
            this.pnlBotRightCorner.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBotRightCorner.Location = new System.Drawing.Point(1050, 0);
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
            this.btnWeek.Check = false;
            this.btnWeek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnWeek.FlatAppearance.BorderSize = 0;
            this.btnWeek.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnWeek.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWeek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnWeek.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
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
            this.btnMonth.Check = false;
            this.btnMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMonth.FlatAppearance.BorderSize = 0;
            this.btnMonth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnMonth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.btnMonth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnMonth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
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
            this.btnUpdateData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(184)))), ((int)(((byte)(92)))));
            this.btnUpdateData.Location = new System.Drawing.Point(0, 0);
            this.btnUpdateData.Name = "btnUpdateData";
            this.btnUpdateData.Size = new System.Drawing.Size(150, 73);
            this.btnUpdateData.TabIndex = 1;
            this.btnUpdateData.Text = "   UPDATE";
            this.btnUpdateData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateData.UseVisualStyleBackColor = false;
            this.btnUpdateData.Click += new System.EventHandler(this.btnUpdateData_Click);
            // 
            // lblIssuesClosed
            // 
            this.lblIssuesClosed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblIssuesClosed.AutoSize = true;
            this.lblIssuesClosed.BackColor = System.Drawing.Color.Transparent;
            this.lblIssuesClosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIssuesClosed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblIssuesClosed.Location = new System.Drawing.Point(281, 13);
            this.lblIssuesClosed.Name = "lblIssuesClosed";
            this.lblIssuesClosed.Size = new System.Drawing.Size(81, 20);
            this.lblIssuesClosed.TabIndex = 6;
            this.lblIssuesClosed.Text = "CLOSED";
            // 
            // lblIssuesCreated
            // 
            this.lblIssuesCreated.AutoSize = true;
            this.lblIssuesCreated.BackColor = System.Drawing.Color.Transparent;
            this.lblIssuesCreated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIssuesCreated.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblIssuesCreated.Location = new System.Drawing.Point(61, 13);
            this.lblIssuesCreated.Name = "lblIssuesCreated";
            this.lblIssuesCreated.Size = new System.Drawing.Size(93, 20);
            this.lblIssuesCreated.TabIndex = 5;
            this.lblIssuesCreated.Text = "CREATED";
            // 
            // sgClosed
            // 
            this.sgClosed.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.sgClosed.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.sgClosed.BackColorTransparent = true;
            this.sgClosed.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sgClosed.ForeColor = System.Drawing.SystemColors.Control;
            this.sgClosed.Location = new System.Drawing.Point(220, 34);
            this.sgClosed.Name = "sgClosed";
            this.sgClosed.Size = new System.Drawing.Size(200, 103);
            this.sgClosed.TabIndex = 4;
            this.sgClosed.TabStop = false;
            // 
            // lblStatusAssigned
            // 
            this.lblStatusAssigned.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusAssigned.AutoSize = true;
            this.lblStatusAssigned.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusAssigned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusAssigned.ForeColor = System.Drawing.Color.Black;
            this.lblStatusAssigned.Location = new System.Drawing.Point(10, 10);
            this.lblStatusAssigned.Name = "lblStatusAssigned";
            this.lblStatusAssigned.Size = new System.Drawing.Size(100, 20);
            this.lblStatusAssigned.TabIndex = 8;
            this.lblStatusAssigned.Text = "Назначена: ";
            // 
            // pnlLayoutMid
            // 
            this.pnlLayoutMid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlLayoutMid.Controls.Add(this.lblPnlStatusHeader);
            this.pnlLayoutMid.Controls.Add(this.pnlStatusEscalated);
            this.pnlLayoutMid.Controls.Add(this.pnlStatusAssigned);
            this.pnlLayoutMid.Controls.Add(this.pnlStatusNew);
            this.pnlLayoutMid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlLayoutMid.Location = new System.Drawing.Point(0, 324);
            this.pnlLayoutMid.Name = "pnlLayoutMid";
            this.pnlLayoutMid.Size = new System.Drawing.Size(1200, 147);
            this.pnlLayoutMid.TabIndex = 6;
            // 
            // pnlLayoutTop
            // 
            this.pnlLayoutTop.Controls.Add(this.pnlCartesianChart);
            this.pnlLayoutTop.Controls.Add(this.pnlTopMid);
            this.pnlLayoutTop.Controls.Add(this.pnlTopRight);
            this.pnlLayoutTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLayoutTop.Location = new System.Drawing.Point(0, 0);
            this.pnlLayoutTop.Name = "pnlLayoutTop";
            this.pnlLayoutTop.Size = new System.Drawing.Size(1200, 324);
            this.pnlLayoutTop.TabIndex = 7;
            // 
            // pnlCartesianChart
            // 
            this.pnlCartesianChart.Controls.Add(this.cartesianChart);
            this.pnlCartesianChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCartesianChart.Location = new System.Drawing.Point(0, 0);
            this.pnlCartesianChart.Name = "pnlCartesianChart";
            this.pnlCartesianChart.Size = new System.Drawing.Size(640, 324);
            this.pnlCartesianChart.TabIndex = 3;
            // 
            // cartesianChart
            // 
            this.cartesianChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cartesianChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cartesianChart.ForeColor = System.Drawing.SystemColors.Control;
            this.cartesianChart.Location = new System.Drawing.Point(10, 3);
            this.cartesianChart.Name = "cartesianChart";
            this.cartesianChart.Padding = new System.Windows.Forms.Padding(3);
            this.cartesianChart.Size = new System.Drawing.Size(620, 315);
            this.cartesianChart.TabIndex = 0;
            this.cartesianChart.TabStop = false;
            // 
            // pnlTopRight
            // 
            this.pnlTopRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTopRight.Location = new System.Drawing.Point(934, 0);
            this.pnlTopRight.Name = "pnlTopRight";
            this.pnlTopRight.Size = new System.Drawing.Size(266, 324);
            this.pnlTopRight.TabIndex = 4;
            // 
            // pnlStatusChart
            // 
            this.pnlStatusChart.Controls.Add(this.pieChartStatus);
            this.pnlStatusChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatusChart.Location = new System.Drawing.Point(0, 163);
            this.pnlStatusChart.Name = "pnlStatusChart";
            this.pnlStatusChart.Size = new System.Drawing.Size(294, 163);
            this.pnlStatusChart.TabIndex = 5;
            // 
            // pieChartStatus
            // 
            this.pieChartStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pieChartStatus.Location = new System.Drawing.Point(0, 0);
            this.pieChartStatus.Name = "pieChartStatus";
            this.pieChartStatus.Size = new System.Drawing.Size(294, 163);
            this.pieChartStatus.TabIndex = 0;
            // 
            // pnlProjects
            // 
            this.pnlProjects.Controls.Add(this.pieChartProjects);
            this.pnlProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlProjects.Location = new System.Drawing.Point(0, 0);
            this.pnlProjects.Name = "pnlProjects";
            this.pnlProjects.Size = new System.Drawing.Size(294, 163);
            this.pnlProjects.TabIndex = 4;
            // 
            // pieChartProjects
            // 
            this.pieChartProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.pieChartProjects.Location = new System.Drawing.Point(0, 0);
            this.pieChartProjects.Name = "pieChartProjects";
            this.pieChartProjects.Size = new System.Drawing.Size(294, 163);
            this.pieChartProjects.TabIndex = 0;
            this.pieChartProjects.DataClick += new LiveCharts.Events.DataClickHandler(this.pieChartProjects_DataClick);
            // 
            // pnlHorizDividerBot
            // 
            this.pnlHorizDividerBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(33)))), ((int)(((byte)(45)))));
            this.pnlHorizDividerBot.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlHorizDividerBot.Location = new System.Drawing.Point(0, 471);
            this.pnlHorizDividerBot.Name = "pnlHorizDividerBot";
            this.pnlHorizDividerBot.Size = new System.Drawing.Size(1200, 4);
            this.pnlHorizDividerBot.TabIndex = 9;
            // 
            // lblStatusNew
            // 
            this.lblStatusNew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusNew.AutoSize = true;
            this.lblStatusNew.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusNew.ForeColor = System.Drawing.Color.Black;
            this.lblStatusNew.Location = new System.Drawing.Point(10, 10);
            this.lblStatusNew.Name = "lblStatusNew";
            this.lblStatusNew.Size = new System.Drawing.Size(65, 20);
            this.lblStatusNew.TabIndex = 10;
            this.lblStatusNew.Text = "Новая: ";
            // 
            // pnlStatusNew
            // 
            this.pnlStatusNew.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlStatusNew.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlStatusNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.pnlStatusNew.Controls.Add(this.lblStatusNewOverduedValue);
            this.pnlStatusNew.Controls.Add(this.lblStatusNewValue);
            this.pnlStatusNew.Controls.Add(this.lblStatusNew);
            this.pnlStatusNew.Location = new System.Drawing.Point(10, 34);
            this.pnlStatusNew.Name = "pnlStatusNew";
            this.pnlStatusNew.Size = new System.Drawing.Size(200, 101);
            this.pnlStatusNew.TabIndex = 11;
            this.pnlStatusNew.Click += new System.EventHandler(this.pnlStatusNew_Click);
            // 
            // lblStatusNewValue
            // 
            this.lblStatusNewValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusNewValue.AutoSize = true;
            this.lblStatusNewValue.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusNewValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusNewValue.ForeColor = System.Drawing.Color.Black;
            this.lblStatusNewValue.Location = new System.Drawing.Point(10, 40);
            this.lblStatusNewValue.Name = "lblStatusNewValue";
            this.lblStatusNewValue.Size = new System.Drawing.Size(0, 24);
            this.lblStatusNewValue.TabIndex = 11;
            // 
            // pnlStatusAssigned
            // 
            this.pnlStatusAssigned.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlStatusAssigned.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlStatusAssigned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(195)))), ((int)(((byte)(228)))), ((int)(((byte)(252)))));
            this.pnlStatusAssigned.Controls.Add(this.lblStatusAssignedValue);
            this.pnlStatusAssigned.Controls.Add(this.lblStatusAssigned);
            this.pnlStatusAssigned.Location = new System.Drawing.Point(220, 34);
            this.pnlStatusAssigned.Name = "pnlStatusAssigned";
            this.pnlStatusAssigned.Size = new System.Drawing.Size(200, 101);
            this.pnlStatusAssigned.TabIndex = 12;
            // 
            // lblStatusAssignedValue
            // 
            this.lblStatusAssignedValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusAssignedValue.AutoSize = true;
            this.lblStatusAssignedValue.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusAssignedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusAssignedValue.ForeColor = System.Drawing.Color.Black;
            this.lblStatusAssignedValue.Location = new System.Drawing.Point(10, 40);
            this.lblStatusAssignedValue.Name = "lblStatusAssignedValue";
            this.lblStatusAssignedValue.Size = new System.Drawing.Size(0, 24);
            this.lblStatusAssignedValue.TabIndex = 10;
            // 
            // pnlStatusEscalated
            // 
            this.pnlStatusEscalated.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pnlStatusEscalated.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlStatusEscalated.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(182)))), ((int)(((byte)(131)))));
            this.pnlStatusEscalated.Controls.Add(this.lblStatusEscalatedValue);
            this.pnlStatusEscalated.Controls.Add(this.lblStatusEscalated);
            this.pnlStatusEscalated.Location = new System.Drawing.Point(430, 34);
            this.pnlStatusEscalated.Name = "pnlStatusEscalated";
            this.pnlStatusEscalated.Size = new System.Drawing.Size(200, 101);
            this.pnlStatusEscalated.TabIndex = 13;
            // 
            // lblStatusEscalatedValue
            // 
            this.lblStatusEscalatedValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusEscalatedValue.AutoSize = true;
            this.lblStatusEscalatedValue.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusEscalatedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusEscalatedValue.ForeColor = System.Drawing.Color.Black;
            this.lblStatusEscalatedValue.Location = new System.Drawing.Point(10, 40);
            this.lblStatusEscalatedValue.Name = "lblStatusEscalatedValue";
            this.lblStatusEscalatedValue.Size = new System.Drawing.Size(0, 24);
            this.lblStatusEscalatedValue.TabIndex = 10;
            // 
            // lblStatusEscalated
            // 
            this.lblStatusEscalated.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusEscalated.AutoSize = true;
            this.lblStatusEscalated.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusEscalated.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusEscalated.ForeColor = System.Drawing.Color.Black;
            this.lblStatusEscalated.Location = new System.Drawing.Point(10, 10);
            this.lblStatusEscalated.Name = "lblStatusEscalated";
            this.lblStatusEscalated.Size = new System.Drawing.Size(127, 20);
            this.lblStatusEscalated.TabIndex = 8;
            this.lblStatusEscalated.Text = "Эскалирована: ";
            // 
            // lblStatusNewOverduedValue
            // 
            this.lblStatusNewOverduedValue.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblStatusNewOverduedValue.AutoSize = true;
            this.lblStatusNewOverduedValue.BackColor = System.Drawing.Color.Transparent;
            this.lblStatusNewOverduedValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStatusNewOverduedValue.ForeColor = System.Drawing.Color.Crimson;
            this.lblStatusNewOverduedValue.Location = new System.Drawing.Point(105, 40);
            this.lblStatusNewOverduedValue.Name = "lblStatusNewOverduedValue";
            this.lblStatusNewOverduedValue.Size = new System.Drawing.Size(0, 24);
            this.lblStatusNewOverduedValue.TabIndex = 12;
            // 
            // lblPnlStatusHeader
            // 
            this.lblPnlStatusHeader.AutoSize = true;
            this.lblPnlStatusHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(88)))), ((int)(((byte)(86)))));
            this.lblPnlStatusHeader.Location = new System.Drawing.Point(13, 7);
            this.lblPnlStatusHeader.Name = "lblPnlStatusHeader";
            this.lblPnlStatusHeader.Size = new System.Drawing.Size(81, 13);
            this.lblPnlStatusHeader.TabIndex = 14;
            this.lblPnlStatusHeader.Text = "Статусы задач";
            // 
            // pnlTopMid
            // 
            this.pnlTopMid.Controls.Add(this.pnlStatusChart);
            this.pnlTopMid.Controls.Add(this.pnlProjects);
            this.pnlTopMid.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlTopMid.Location = new System.Drawing.Point(640, 0);
            this.pnlTopMid.Name = "pnlTopMid";
            this.pnlTopMid.Size = new System.Drawing.Size(294, 324);
            this.pnlTopMid.TabIndex = 6;
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
            this.Size = new System.Drawing.Size(1200, 622);
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
            this.pnlStatusChart.ResumeLayout(false);
            this.pnlProjects.ResumeLayout(false);
            this.pnlStatusNew.ResumeLayout(false);
            this.pnlStatusNew.PerformLayout();
            this.pnlStatusAssigned.ResumeLayout(false);
            this.pnlStatusAssigned.PerformLayout();
            this.pnlStatusEscalated.ResumeLayout(false);
            this.pnlStatusEscalated.PerformLayout();
            this.pnlTopMid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlLayoutBot;
        private System.Windows.Forms.Label lblIssuesCreated;
        private System.Windows.Forms.Label lblStatusAssigned;
        private System.Windows.Forms.Label lblIssuesClosed;
        private System.Windows.Forms.Panel pnlLayoutMid;
        private System.Windows.Forms.Panel pnlLayoutTop;
        private System.Windows.Forms.Panel pnlStatusChart;
        private System.Windows.Forms.Panel pnlProjects;
        private System.Windows.Forms.Panel pnlCartesianChart;
        public LiveCharts.WinForms.CartesianChart cartesianChart;
        public LiveCharts.WinForms.PieChart pieChartStatus;
        public LiveCharts.WinForms.PieChart pieChartProjects;
        public LiveCharts.WinForms.SolidGauge sgNewIssues;
        public LiveCharts.WinForms.SolidGauge sgClosed;
        private System.Windows.Forms.Panel pnlBotRightCorner;
        private System.Windows.Forms.Button btnUpdateData;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Panel pnlUpdateBtn;
        private System.Windows.Forms.Panel pnlWeekFilter;
        private TrackerHelper.CheckedButton btnWeek;
        private System.Windows.Forms.Panel pnlMonthFilter;
        private TrackerHelper.CheckedButton btnMonth;
        private System.Windows.Forms.Panel pnlTopRight;
        private System.Windows.Forms.Label lblIssuesClosedLastYear;
        private System.Windows.Forms.Label lblIssuesCreatedLastYear;
        public LiveCharts.WinForms.SolidGauge sgClosedLastYear;
        public LiveCharts.WinForms.SolidGauge sgNewLastYear;
        private System.Windows.Forms.Panel pnlHorizDividerBot;
        private System.Windows.Forms.Label lblStatusNew;
        private System.Windows.Forms.Panel pnlStatusNew;
        private System.Windows.Forms.Label lblStatusNewValue;
        private System.Windows.Forms.Panel pnlStatusAssigned;
        private System.Windows.Forms.Label lblStatusAssignedValue;
        private System.Windows.Forms.Panel pnlStatusEscalated;
        private System.Windows.Forms.Label lblStatusEscalatedValue;
        private System.Windows.Forms.Label lblStatusEscalated;
        private System.Windows.Forms.Label lblStatusNewOverduedValue;
        private System.Windows.Forms.Label lblPnlStatusHeader;
        private System.Windows.Forms.Panel pnlTopMid;
    }
}
