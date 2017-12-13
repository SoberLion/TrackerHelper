using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Media;
using System.Linq;
using System.Data;
using TrackerHelper.DB;

namespace TrackerHelper
{
    public partial class MainForm : Form
    {

        Form repform;
        Form dashForm;
        private StickyWindow stickyWindow;

        public MainForm()
        {
            InitializeComponent();
            stickyWindow = new StickyWindow(this);
            DBman.CreateDatabase();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tasksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form workForm = new WorkForm();
            workForm.MdiParent = this;
            workForm.WindowState = FormWindowState.Maximized;
            workForm.Show();
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
                    { WindowState = FormWindowState.Maximized, AutoScaleDimensions = new SizeF(6F, 13F), Name = "Charts", Text = "Charts", BackColor = System.Drawing.Color.FromArgb(61, 73, 85) };
                repform.FormClosed += FormClosed;

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
                repform.Show();
            }
        }

        private void newClosedLastYearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repform?.Dispose();

            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            repform = new Form
            { WindowState = FormWindowState.Maximized, AutoScaleDimensions = new SizeF(6F, 13F), Name = "Charts", Text = "Charts", BackColor = System.Drawing.Color.White };
            repform.FormClosed += FormClosed;

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

            Panel pnlCheckBox = new Panel
            { Parent = pnlFilter, Dock = DockStyle.Top, Name = "pnlCheckBox", Height = 60 };

            CheckBox cbByTracker = new CheckBox
            { Parent = pnlCheckBox, Dock = DockStyle.Fill, Name = "cbByTracker", Text = "Разрез: Трекер" };

            cbByTracker.CheckedChanged += cbByTrackerCheckedChanged;

            Panel pnldtpTo = new Panel
            { Parent = pnlFilter, Dock = DockStyle.Top, Name = "pnldtpTo", Height = 50 };
            DateTimePicker dtpTo = new DateTimePicker
            { Parent = pnldtpTo, Format = DateTimePickerFormat.Short, Dock = DockStyle.Top, Name = "dtpTo" };

            dtpTo.CloseUp += dtpOnCloseUp;

            Label lblTo = new Label
            { Parent = pnldtpTo, Dock = DockStyle.Top, Name = "lblFrom", Text = "Дата по:" };

            Panel pnldtpFrom = new Panel
            { Parent = pnlFilter, Dock = DockStyle.Top, Name = "pnldtpFrom", Height = 50 };
            DateTimePicker dtpFrom = new DateTimePicker
            { Parent = pnldtpFrom, Format = DateTimePickerFormat.Short, Dock = DockStyle.Top, Name = "dtpFrom" };

            dtpFrom.CloseUp += dtpOnCloseUp;

            Label lblFrom = new Label
            { Parent = pnldtpFrom, Dock = DockStyle.Top, Name = "lblFrom", Text = "Дата с:" };


            Button btnFilter = new Button
            { Parent = pnlFilter, Name = "btnFilter", Text = "FILTER", Dock = DockStyle.Top, Height = 30, FlatStyle = FlatStyle.Flat };
            btnFilter.FlatAppearance.BorderSize = 0;

            btnFilter.Click += btnFilterOnClick;
            cartesianChart.DataClick += CartesianChartOnDataClick;

            repform.Show();
        }
        private new void FormClosed(object sender, FormClosedEventArgs e)
        {
            repform = null;
        }

        private void btnFilterOnClick(object sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                if (btn.Name == "btnFilter")
                    btnFilterClick();
                if (btn.Name == "btnFilterTE")
                    btnFilterTEClick();
            }
        }
        private void CartesianChartOnDataClick(object sender, ChartPoint chartPoint)
        {
        }

        private void dtpOnCloseUp(object sender, EventArgs e)
        {
            DateTimePicker dtpFrom = repform.Controls.Find("dtpFrom", true).FirstOrDefault() as DateTimePicker;
            DateTimePicker dtpTo = repform.Controls.Find("dtpTo", true).FirstOrDefault() as DateTimePicker;
            RadioButton rbDay = repform.Controls.Find("rbDay", true).FirstOrDefault() as RadioButton;
            RadioButton rbMonth = repform.Controls.Find("rbMonth", true).FirstOrDefault() as RadioButton;
            RadioButton rbYear = repform.Controls.Find("rbYear", true).FirstOrDefault() as RadioButton;

            if (dtpTo.Value < dtpFrom.Value)
            {
                dtpFrom.Value = dtpTo.Value;
            }

            TimeSpan ts = dtpTo.Value - dtpFrom.Value;
            if (Math.Abs(ts.Days) > 60)
            {
                rbDay.Enabled = false;
                rbMonth.Checked = true;
            }
            if (Math.Abs(ts.Days) > 1800)
            {
                rbDay.Enabled = false;
                rbMonth.Enabled = false;
                rbYear.Checked = true;
            }
            if (Math.Abs(ts.Days) < 60)
            {
                rbDay.Enabled = true;
                rbMonth.Enabled = true;
            }
        }

        private void newIssuesMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void timeEntriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            repform?.Dispose();
            Func<ChartPoint, string> labelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            repform = new Form
            { WindowState = FormWindowState.Maximized, AutoScaleDimensions = new SizeF(6F, 13F), Name = "Charts", Text = "Charts" };
            repform.FormClosed += FormClosed;

            Panel pnlChart = new Panel
            { Parent = repform, Dock = DockStyle.Fill, Name = "pnlChart" };
            Panel pnlFilter = new Panel
            { Parent = repform, Dock = DockStyle.Right, Width = 200, Name = "pnlFilter" };
            LiveCharts.WinForms.CartesianChart cartesianChart = new LiveCharts.WinForms.CartesianChart
            { Parent = pnlChart, Dock = DockStyle.Fill, LegendLocation = LegendLocation.Bottom, Name = "cartesianChart" };

            Panel pnlCheckBox = new Panel
            { Parent = pnlFilter, Dock = DockStyle.Top, Name = "pnlCheckBox", AutoSize = true };

            Panel pnldtpTo = new Panel
            { Parent = pnlFilter, Dock = DockStyle.Top, Name = "pnldtpTo", Height = 50 };
            DateTimePicker dtpTo = new DateTimePicker
            {
                Parent = pnldtpTo,
                Format = DateTimePickerFormat.Short,
                Dock = DockStyle.Top,
                Name = "dtpTo"
            };
            dtpTo.CloseUp += dtpOnCloseUp;
            Label lblTo = new Label
            { Parent = pnldtpTo, Dock = DockStyle.Top, Name = "lblFrom", Text = "Дата по:" };


            Panel pnldtpFrom = new Panel
            { Parent = pnlFilter, Dock = DockStyle.Top, Name = "pnldtpFrom", Height = 50 };
            DateTimePicker dtpFrom = new DateTimePicker
            {
                Parent = pnldtpFrom,
                Format = DateTimePickerFormat.Short,
                Dock = DockStyle.Top,
                Name = "dtpFrom"
            };
            dtpFrom.CloseUp += dtpOnCloseUp;
            Label lblFrom = new Label
            { Parent = pnldtpFrom, Dock = DockStyle.Top, Name = "lblFrom", Text = "Дата с:" };

            Button btnFilter = new Button
            {
                Parent = pnlFilter,
                Name = "btnFilterTE",
                Text = "FILTER",
                Dock = DockStyle.Top,
                Height = 30,
                FlatStyle = FlatStyle.Flat
            };
            btnFilter.FlatAppearance.BorderSize = 0;

            btnFilter.Click += btnFilterOnClick;
            cartesianChart.DataClick += CartesianChartOnDataClick;

            repform.Show();

        }

        private void btnFilterClick()
        {

            if ((repform.Controls.Find("cbByTracker", true).FirstOrDefault() as CheckBox).Checked == false)
            {
                cartesianChartColumns();
            }
            else
            {
                cartesianChartStackedColumns();
            }
                
        }

        private void cartesianChartStackedColumns()
        {
            DateTimePicker dtpFrom = repform.Controls.Find("dtpFrom", true).FirstOrDefault() as DateTimePicker;
            DateTimePicker dtpTo = repform.Controls.Find("dtpTo", true).FirstOrDefault() as DateTimePicker;

            List<RadioButton> rbList = new List<RadioButton>
            {
                repform.Controls.Find("rbDay", true).FirstOrDefault() as RadioButton,
                repform.Controls.Find("rbMonth", true).FirstOrDefault() as RadioButton,
                repform.Controls.Find("rbYear", true).FirstOrDefault() as RadioButton
            };

            DBman.GroupFormat groupFormat = DBman.GroupFormat.Month;

            foreach (var rb in rbList)
            {
                if (rb.Checked == true)
                    groupFormat = (DBman.GroupFormat)rb.Tag;
            }


            string GroupingFormat = "%Y";

            switch (groupFormat)
            {
                case (DBman.GroupFormat.Day):
                    {
                        GroupingFormat = "%Y-%m-%d";
                        break;
                    }
                case (DBman.GroupFormat.Month):
                    {
                        GroupingFormat = "%Y-%m";
                        break;
                    }
                case (DBman.GroupFormat.Year):
                    {
                        GroupingFormat = "%Y";
                        break;
                    }
            }

            if (repform.Controls.Find("cartesianChart2", true).FirstOrDefault() is LiveCharts.WinForms.CartesianChart cartesianChart2)
            {
                string query = $@"SELECT count(*) as number, TrackerName, strftime('{GroupingFormat}', ClosedOn) as ClosedOn FROM Issues 
                                WHERE TrackerId in (1,2,3) AND ClosedOn >= '{dtpFrom.Value.ToString("yyyy-MM-dd HH:mm:ss,fff")}' 
                                AND ClosedOn < '{dtpTo.Value.ToString("yyyy-MM-dd HH:mm:ss,fff")}' and ProjectId in (26,220) 
                                GROUP BY strftime('{GroupingFormat}', ClosedOn), TrackerId ORDER BY ClosedOn, TrackerId";
                DataTable dt = DBman.OpenQuery(query);

                FillCartesianChartStackedColumns(cartesianChart2, dt);
            }

            if (repform.Controls.Find("cartesianChart", true).FirstOrDefault() is LiveCharts.WinForms.CartesianChart cartesianChart)
            {
                string query = $@"SELECT count(*) as number, TrackerName, strftime('{GroupingFormat}', CreatedOn) as CreatedOn FROM Issues 
                                WHERE TrackerId in (1,2,3) AND CreatedOn >= '{dtpFrom.Value.ToString("yyyy-MM-dd HH:mm:ss,fff")}' 
                                AND CreatedOn < '{dtpTo.Value.ToString("yyyy-MM-dd HH:mm:ss,fff")}' and ProjectId in (26,220) 
                                GROUP BY strftime('{GroupingFormat}', CreatedOn), TrackerId ORDER BY CreatedOn, TrackerId";
                DataTable dt = DBman.OpenQuery(query);

                FillCartesianChartStackedColumns(cartesianChart, dt);
            }
        }

        private void FillCartesianChartStackedColumns(LiveCharts.WinForms.CartesianChart cartesianChart, DataTable dt)
        {
            DataRow[] dr = dt.Select("");

            SeriesCollection col = new SeriesCollection();

            List<string> ListSeries = dr.Select(p => p[1].ToString()).Distinct().ToList();
            List<string> ListLabels = dr.Select(p => p[2].ToString().Split(' ')[0]).Distinct().ToList();
            ListSeries.Sort();

            (repform.Controls.Find("pnl"+cartesianChart.Name, true).FirstOrDefault() as Panel)?.Dispose();

            Panel pnlSeriesCheckBox = new Panel
            {
                Parent = repform.Controls.Find("pnlFilter", true).FirstOrDefault() as Panel,
                Dock = DockStyle.Top,
                Height = 32 * ListSeries.Count,
                Name = "pnl" + cartesianChart.Name
            };
            

            pnlSeriesCheckBox.Controls.Clear();

            foreach (var item in ListSeries)
            {
                StackedColumnSeries columnSeries = new StackedColumnSeries
                {
                    Title = item,
                    Values = new ChartValues<int>(),
                    LabelPoint = point => point.Y.ToString(),
                    DataLabels = true,
                    Foreground = System.Windows.Media.Brushes.Black,
                    Name = cartesianChart.Text
                };
                col.Add(columnSeries);

                CheckBox cb = new CheckBox
                {
                    Parent = pnlSeriesCheckBox,
                    Text = columnSeries.Title,
                    Tag = columnSeries,
                    Dock = DockStyle.Top,
                    Checked = true
                };
                cb.CheckedChanged += SeriesCheckBoxCheckedChanged;
            }

            Label lbl = new Label
            {
                Text = cartesianChart.Text,
                Parent = pnlSeriesCheckBox,
                Dock = DockStyle.Top,
                Padding = new Padding(5),
                Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(204))),
                AutoSize = true
            };

            int rowiterator = 0;
            foreach (string Name in ListLabels)
            {
                for (int i = 0; i < col.Count; i++)
                {
                    if (col[i].Title == dr[rowiterator][1].ToString())
                    {
                        col[i].Values.Add(Convert.ToInt32(dr[rowiterator][0]));
                        if (rowiterator < dr.Length - 1)
                        {
                            rowiterator++;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        col[i].Values.Add(0);
                    }
                }
            }

            Axis ax = new Axis
            {
                Separator = new Separator { Step = 1, IsEnabled = false },
                Labels = ListLabels,
                LabelsRotation = 70,
                Foreground = System.Windows.Media.Brushes.Black,
                Name = cartesianChart.Text,           
            };

            cartesianChart.AxisX.Clear();
            cartesianChart.AxisY.Clear();

            cartesianChart.Series = col;
            cartesianChart.AxisX.Add(ax);
            cartesianChart.LegendLocation = LegendLocation.Right;

        }



        private void cbByTrackerCheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox cb)
            {
                LiveCharts.WinForms.CartesianChart cartesianChart = repform.Controls.Find("cartesianChart", true).FirstOrDefault() as LiveCharts.WinForms.CartesianChart;

                if (cb.Checked != false)
                {
                    Panel pnlChart = repform.Controls.Find("pnlChart", true).FirstOrDefault() as Panel;
                    cartesianChart.Dock = DockStyle.None;
                    cartesianChart.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom;
                    cartesianChart.Size = new Size(pnlChart.Size.Width - 5, pnlChart.Size.Height / 2 - 5);
                    cartesianChart.Top = 5;
                    cartesianChart.Left = 5;
                    cartesianChart.Text = "Открыто";

                    LiveCharts.WinForms.CartesianChart cartesianChart2 = new LiveCharts.WinForms.CartesianChart
                    {
                        Parent = pnlChart,
                        Dock = DockStyle.None,
                        Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Bottom,
                        Size = new Size(pnlChart.Size.Width - 10, pnlChart.Size.Height / 2 -10),
                        Top = pnlChart.Size.Height / 2 + 5,
                        Left = 5,
                        Name = "cartesianChart2",
                        Text = "Закрыто"
                    };
                }
                else
                {
                    LiveCharts.WinForms.CartesianChart cartesianChart2 = repform.Controls.Find("cartesianChart2", true).FirstOrDefault() as LiveCharts.WinForms.CartesianChart;
                    cartesianChart2?.Dispose();

                    cartesianChart.Dock = DockStyle.Fill;
                }
            }
        }

        private void SeriesCheckBoxCheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox cb)
            {
                StackedColumnSeries scs = cb.Tag as StackedColumnSeries;
                scs.Visibility = cb.Checked == false ? System.Windows.Visibility.Hidden : System.Windows.Visibility.Visible;
                scs.LabelPoint = point => point.Y.ToString();
                scs.DataLabels = true;
            }
        }

        private void cartesianChartColumns()
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
                "26,220",
                groupFormat,
                DBman.IssueType.Created);
            List<string[]> closedList = DBman.GetIssuesCountGroupedByDay(
                dtpFrom.Value.ToString("yyyy-MM-dd hh:mm:ss:fff"),
                dtpTo.Value.ToString("yyyy-MM-dd hh:mm:ss:fff"),
                "26,220",
                groupFormat,
                DBman.IssueType.Closed);

            Control cnt = repform.Controls.Find("cartesianChart", true).FirstOrDefault();

            if (cnt is LiveCharts.WinForms.CartesianChart cartesianChart)
            {
                cartesianChart.Series.Clear();
                cartesianChart.AxisX.Clear();
                cartesianChart.AxisY.Clear();

                Axis ax = new Axis { Labels = new List<string>(), Separator = new Separator { Step = 1, IsEnabled = false }, LabelsRotation = 50, Foreground = System.Windows.Media.Brushes.Black };
                Axis ay = new Axis { LabelFormatter = value => value.ToString(), Separator = new Separator(), MinValue = 0, Foreground = System.Windows.Media.Brushes.Black };


                ColumnSeries csCreated = new ColumnSeries
                {
                    Title = "Создано: " + createdList.Sum(p => Convert.ToInt32(p[1])).ToString(),
                    Values = new ChartValues<int>(),
                    LabelPoint = point => point.Y.ToString(),
                    DataLabels = true,
                    Foreground = System.Windows.Media.Brushes.Black,
                    Fill = System.Windows.Media.Brushes.Red
                };

                ColumnSeries csClosed = new ColumnSeries
                {
                    Title = "Закрыто: " + closedList.Sum(p => Convert.ToInt32(p[1])).ToString(),
                    Values = new ChartValues<int>(),
                    LabelPoint = point => point.Y.ToString(),
                    DataLabels = true,
                    Foreground = System.Windows.Media.Brushes.Black,
                    Fill = System.Windows.Media.Brushes.Gray
                };

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
                cartesianChart.LegendLocation = LegendLocation.Top;
            }
        }
        private void btnFilterTEClick()
        {
            DateTimePicker dtpFrom = repform.Controls.Find("dtpFrom", true).FirstOrDefault() as DateTimePicker;
            DateTimePicker dtpTo = repform.Controls.Find("dtpTo", true).FirstOrDefault() as DateTimePicker;
            Panel pnlCheckBox = repform.Controls.Find("pnlCheckBox", true).FirstOrDefault() as Panel;

            LiveCharts.WinForms.CartesianChart cartesianChart = repform.Controls.Find("cartesianChart", true).FirstOrDefault() as LiveCharts.WinForms.CartesianChart;
            
            cartesianChart.Series.Clear();
            cartesianChart.AxisX.Clear();
            cartesianChart.AxisY.Clear();
            cartesianChart.LegendLocation = LegendLocation.Top;

            Axis ax = new Axis { Labels = new List<string>(), Separator = new Separator { Step = 5, IsEnabled = false }, LabelsRotation = 25 };
            Axis ay = new Axis { LabelFormatter = value => value.ToString(), Separator = new Separator(), MinValue = 0 };

            string query = $@"SELECT sum(hours) AS Hours, UserName FROM TimeEntries WHERE userid IN (2361,2374,1830,2233,1240,1383,2886,2235,1521,2232,1537,2535,551,894,3713,328) 
                            AND spenton > '{dtpFrom.Value.ToString("yyyy-MM-dd 00:00:00,001")}' 
                            AND spenton < '{dtpTo.Value.ToString("yyyy-MM-dd  00:00:00,000")}' 
                            GROUP BY userid
                            ORDER BY Hours";
            DataTable dt = DBman.OpenQuery(query);

            DataRow[] dr = dt.Select("");
            List<string> ls = dr.Select(p => p[0].ToString()).ToList();
            for (int i = 0; i < dr.Length; i++)
            {
                ColumnSeries columnSeries = new ColumnSeries
                {
                    Title = dr[i][1].ToString(),
                    Values = new ChartValues<int> { Convert.ToInt32(dr[i][0]) },
                    LabelPoint = point => point.Y.ToString(),
                    DataLabels = true,                    
                };
                Panel pnl = new Panel
                    { Parent = pnlCheckBox, Name = "pnl" + dr[i][1].ToString(), Dock = DockStyle.Top, Height = 25 };
                CheckBox checkBox = new CheckBox
                    { Parent = pnl, Dock = DockStyle.Fill, Name = "cb"+ dr[i][1].ToString(), Text = dr[i][1].ToString(), Tag = columnSeries, Checked = true };
                checkBox.CheckedChanged += onTECheckedChange;

                cartesianChart.Series.Add(columnSeries);
            }
            cartesianChart.AxisX.Add(ax);
            cartesianChart.AxisY.Add(ay);
        }

        private void onTECheckedChange(object obj, EventArgs e)
        {
            if (obj is CheckBox cb)
            {
                if (repform.Controls.Find("cartesianChart", true).FirstOrDefault() is LiveCharts.WinForms.CartesianChart cartesianChart)
                {
                    if (cb.Checked)
                    {
                        cartesianChart.Series.Add(cb.Tag as ColumnSeries);
                    }
                    else
                    {
                        cartesianChart.Series.Remove(cb.Tag as ColumnSeries);
                    }
                }
            }
        }

        private void techSuppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dashForm = new Dashboard();
            //dashForm.WindowState = FormWindowState.Maximized;
            dashForm.Show();            
        }

        private void groupsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form GroupsForm = new Form
            {
                MdiParent = this,
                Text = "Groups",
                WindowState = FormWindowState.Maximized,
            };
            ComboBox cbGroups = new ComboBox();


            GroupsForm.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form settings = new Settings();
            settings.MdiParent = this;
            settings.WindowState = FormWindowState.Maximized;
            settings.Show();
        }
    }
}
