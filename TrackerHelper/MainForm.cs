using LiveCharts;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;

using System.Drawing;

using System.Windows.Forms;

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
            SQLiteClass.CreateDatabase();
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
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);
            repform = new Form
            {
                //MdiParent = this,
                WindowState = FormWindowState.Maximized,
                AutoScaleDimensions = new SizeF(6F, 13F),
                Name = "Charts",
                Text = "Charts"
            };
            Panel pnlChart = new Panel
            {
                Parent = repform,
                Dock = DockStyle.Fill,
            };
            Panel pnlFilter = new Panel
            {
                Parent = repform,
                Dock = DockStyle.Right,
                Width = 200
            };
            var pieChart = new LiveCharts.WinForms.PieChart
            {
                Parent = pnlChart,
                Dock = DockStyle.Fill,
                LegendLocation = LegendLocation.Bottom,

            };

            Dictionary<string, int> Dict = SQLiteClass.GetGroupedData("StatusId", "StatusName");
            int others = 0;
            SeriesCollection seriesColection = new SeriesCollection();
            foreach (var item in Dict)
            {
                if (item.Value < 15)
                {
                    others += item.Value;
                    continue;
                }

                Panel pnl = new Panel
                {
                    Parent = pnlFilter,
                    Name = item.Key,
                    Dock = DockStyle.Top,
                    Height = 25
                };
                CheckBox checkBox = new CheckBox
                {
                    Parent = pnl,
                    Dock = DockStyle.Fill,
                    Name = item.Key,
                    Text = item.Key,
                    Tag = item
                };
                //checkBox.CheckedChanged += CheckBox_CheckedChanged;

                PieSeries pieSeries = new PieSeries()
                {
                    DataLabels = true,
                    Values = new ChartValues<int>() { item.Value },
                    LabelPoint = labelPoint,
                    Title = item.Key

                };
                pieChart.Series.Add(pieSeries);
            }
            PieSeries OthersSeries = new PieSeries()
            {
                DataLabels = true,
                Values = new ChartValues<int>() { others },
                LabelPoint = labelPoint,
                Title = "Другие"
            };
            pieChart.Series.Add(OthersSeries);

            repform.Show();
        }

        private void settingsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form repform = new Form
            {
                MdiParent = this,
                WindowState = FormWindowState.Maximized
            };
        }

    }
}
