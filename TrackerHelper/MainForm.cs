using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;
using System.Linq;

namespace TrackerHelper
{
    public partial class MainForm : Form
    {

        Form repform;
        private StickyWindow stickyWindow;

        public MainForm()
        {
            InitializeComponent();
            stickyWindow = new StickyWindow(this);
            DBman.CreateDatabase();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settings = new Settings();
            settings.MdiParent = this;
            settings.WindowState = FormWindowState.Maximized;
            settings.Show();
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form workForm = new WorkForm();
            workForm.MdiParent = this;
            workForm.WindowState = FormWindowState.Maximized;
            workForm.Show();
        }


       
        private void techSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form repform = new Form
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
        }

        private void onCheckedChange(object obj, EventArgs e)
        {
            if (obj is CheckBox cb)
            {
                Control cnt = repform.Controls.Find("pieChart", true).FirstOrDefault();
                
                if (cnt is LiveCharts.WinForms.PieChart pieChart)
                {
                    if (cb.Checked)
                    {
                        pieChart.Series.Add(cb.Tag as PieSeries);                        
                    }
                    else
                    {
                        pieChart.Series.Remove(cb.Tag as PieSeries);
                    }
                }
            }
        }

        private void groupedByStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (repform != null)
                MessageBox.Show("Close previous  report");
            else
            {
                Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
                repform = new Form
                    { WindowState = FormWindowState.Maximized, AutoScaleDimensions = new SizeF(6F, 13F), Name = "Charts", Text = "Charts" };

                Panel pnlChart = new Panel
                    { Parent = repform, Dock = DockStyle.Fill, Name = "pnlChart" };
                Panel pnlFilter = new Panel
                    { Parent = repform, Dock = DockStyle.Right, Width = 200, Name = "pnlFilter" };
                LiveCharts.WinForms.PieChart pieChart = new LiveCharts.WinForms.PieChart
                    { Parent = pnlChart, Dock = DockStyle.Fill, LegendLocation = LegendLocation.Bottom, Name = "pieChart" };

                Dictionary<string, int> Dict = DBman.GetGroupedData("StatusId", "StatusName");
                int others = 0;
                SeriesCollection seriesColection = new SeriesCollection();

                foreach (var item in Dict)
                {
                    if (item.Value < 15)
                    {
                        others += item.Value;
                        continue;
                    }

                    PieSeries pieSeries = new PieSeries()
                        { DataLabels = true, Values = new ChartValues<int>() { item.Value }, LabelPoint = labelPoint, Title = item.Key };
                    Panel pnl = new Panel
                        { Parent = pnlFilter, Name = item.Key, Dock = DockStyle.Top, Height = 25 };
                    CheckBox checkBox = new CheckBox
                        { Parent = pnl, Dock = DockStyle.Fill, Name = item.Key, Text = item.Key, Tag = pieSeries, Checked = true };

                    checkBox.CheckedChanged += new EventHandler(onCheckedChange);

                    pieChart.Series.Add(checkBox.Tag as PieSeries);
                }

                PieSeries OthersSeries = new PieSeries()
                    { DataLabels = true, Values = new ChartValues<int>() { others }, LabelPoint = labelPoint, Title = "Другие" };
                Panel panel = new Panel
                    { Parent = pnlFilter, Name = "pnlOthers", Dock = DockStyle.Top, Height = 25 };
                CheckBox cBox = new CheckBox
                    { Parent = panel, Dock = DockStyle.Fill, Name = "cbOthers", Text = "Другие", Tag = OthersSeries, Checked = true };
                cBox.CheckedChanged += new EventHandler(onCheckedChange);

                pieChart.Series.Add(OthersSeries); ;
                repform.ShowDialog();
            }
        }

        private void newClosedLastYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (repform != null)
                repform = null;
            else
            {
                Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

                repform = new Form { WindowState = FormWindowState.Maximized, AutoScaleDimensions = new SizeF(6F, 13F), Name = "Charts", Text = "Charts" };

                Panel pnlChart = new Panel
                    { Parent = repform, Dock = DockStyle.Fill, Name = "pnlChart" };
                Panel pnlFilter = new Panel
                    { Parent = repform, Dock = DockStyle.Right, Width = 200, Name = "pnlFilter" };
                LiveCharts.WinForms.CartesianChart cartesianChart = new LiveCharts.WinForms.CartesianChart
                    { Parent = pnlChart, Dock = DockStyle.Fill, LegendLocation = LegendLocation.Bottom, Name = "cartesianChart" };

                Panel pnlRadioButton = new Panel
                    { Parent = pnlFilter, Dock = DockStyle.Top, Name = "pnlRadioButton", Height = 150 };
                RadioButton rbYear = new RadioButton
                    { Parent = pnlRadioButton, Dock = DockStyle.Top, Name = "rbYear", Text = "Год", Tag = DBman.GroupFormat.Year };
                RadioButton rbMonth = new RadioButton
                    { Parent = pnlRadioButton, Dock = DockStyle.Top, Name = "rbMonth", Text = "Месяц", Checked = true, Tag = DBman.GroupFormat.Month };
                RadioButton rbDay = new RadioButton
                    { Parent = pnlRadioButton, Dock = DockStyle.Top, Name = "rbDay", Text = "День", Tag = DBman.GroupFormat.Day };
                Label lblrbGroup = new Label
                { Parent = pnlRadioButton, Dock = DockStyle.Top, Name = "lblrbGroup", Text = "Группировка" };


                Panel pnldtpTo = new Panel
                    { Parent = pnlFilter, Dock = DockStyle.Top, Name = "pnldtpTo", Height = 50 };
                DateTimePicker dtpTo = new DateTimePicker
                    { Parent = pnldtpTo, Format = DateTimePickerFormat.Short, Dock = DockStyle.Top, Name = "dtpTo" };
                Label lblTo = new Label
                    { Parent = pnldtpTo, Dock = DockStyle.Top, Name = "lblFrom", Text = "Дата по:" };
                

                Panel pnldtpFrom = new Panel
                    { Parent = pnlFilter, Dock = DockStyle.Top, Name = "pnldtpFrom", Height = 50 };
                DateTimePicker dtpFrom = new DateTimePicker
                    { Parent = pnldtpFrom, Format = DateTimePickerFormat.Short, Dock = DockStyle.Top, Name = "dtpFrom" };
                Label lblFrom = new Label
                    { Parent = pnldtpFrom, Dock = DockStyle.Top, Name = "lblFrom", Text = "Дата с:" };                
                

                Button btnFilter = new Button
                    { Parent = pnlFilter, Name = "btnFilter", Text = "FilterIt!", Dock = DockStyle.Top };

                btnFilter.Click += btnFilterOnClick;
                cartesianChart.DataClick += CartesianChartOnDataClick;

                repform.ShowDialog();
            }
        }

        private void btnFilterOnClick(object sender, EventArgs e)
        {
            DateTimePicker dtpFrom = repform.Controls.Find("dtpFrom", true).FirstOrDefault() as DateTimePicker;
            DateTimePicker dtpTo = repform.Controls.Find("dtpTo", true).FirstOrDefault() as DateTimePicker;
            DBman.GroupFormat groupFormat = DBman.GroupFormat.Month;

            List<RadioButton> rbList = new List<RadioButton>
            {
                repform.Controls.Find("rbDay", true).FirstOrDefault() as RadioButton,
                repform.Controls.Find("rbMonth", true).FirstOrDefault() as RadioButton,
                repform.Controls.Find("rbYear", true).FirstOrDefault() as RadioButton
            };
            
            foreach (var rb in rbList)
            {
                if (rb.Checked == true)
                    groupFormat = (DBman.GroupFormat)rb.Tag;
            }                       

            List<string[]> createdList = DBman.GetIssuesCountGroupedByDay(
                dtpFrom.Value.ToString("yyyy-MM-dd hh:mm:ss:fff"), 
                dtpTo.Value.ToString("yyyy-MM-dd hh:mm:ss:fff"), 
                "26",
                groupFormat, 
                DBman.IssueType.Created);
            List<string[]> closedList = DBman.GetIssuesCountGroupedByDay(
                dtpFrom.Value.ToString("yyyy-MM-dd hh:mm:ss:fff"), 
                dtpTo.Value.ToString("yyyy-MM-dd hh:mm:ss:fff"), 
                "26", 
                groupFormat, 
                DBman.IssueType.Closed);
            
            Control cnt = repform.Controls.Find("cartesianChart", true).FirstOrDefault();

            if (cnt is LiveCharts.WinForms.CartesianChart cartesianChart)
            {
                cartesianChart.Series.Clear();
                cartesianChart.AxisX.Clear();
                cartesianChart.AxisY.Clear();

                Axis ax = new Axis { Labels = new List<string>(), Separator = new Separator { Step = 1, IsEnabled = false } };
                Axis ay = new Axis { LabelFormatter = value => value.ToString(), Separator = new Separator() };

                
                ColumnSeries csCreated = new ColumnSeries { Title = "Создано: " + createdList.Sum(p => Convert.ToInt32(p[1])).ToString(),
                    Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString(), DataLabels = true, Fill = System.Windows.Media.Brushes.Red };

                ColumnSeries csClosed = new ColumnSeries { Title = "Закрыто: " + closedList.Sum(p => Convert.ToInt32(p[1])).ToString(),
                    Values = new ChartValues<int>(), LabelPoint = point => point.Y.ToString(), DataLabels = true, Fill = System.Windows.Media.Brushes.Gray };

                foreach (var c in createdList)
                {
                    csCreated.Values.Add(Convert.ToInt32(c[1]));
                    ax.Labels.Add(c[0]);
                }

                foreach (var c in closedList)
                {
                    csClosed.Values.Add(Convert.ToInt32(c[1]));
                    ax.Labels.Add(c[0]);
                }

                cartesianChart.AxisX.Add(ax);
                cartesianChart.AxisY.Add(ay);
                cartesianChart.Series.Add(csCreated);
                cartesianChart.Series.Add(csClosed);
                cartesianChart.LegendLocation = LegendLocation.Left;
            }
        }
        private void CartesianChartOnDataClick(object sender, ChartPoint chartPoint)
        {
            
        }

        private void rbOnCheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            
        }
    }
}
