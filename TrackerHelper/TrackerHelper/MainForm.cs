using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.IO;

namespace TrackerHelper
{
    public partial class MainForm : Form
    {
       // private User _User;
       // private Issue _Issue;
        private Http_Methods _HM;
       // private XmlDocument _doc = null;
        private XmlMethods _xmeth = null;
        private List<Issue> _List = null;
        private List<TimeEntry> _TE = null;
        private SetForm setform = new SetForm();
        // 
        private string BaseUrl = "http://tracker.ucs.ru/";
        private string issuesxml = "issues.xml?";
        private string TExml = "time_entries.xml?";


        //
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void getToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _HM = new Http_Methods();            
            _xmeth = new XmlMethods();
            _TE = new List<TimeEntry>();
            //setform.dateTPFrom.Value
            int cnt=0;
            string tst = BaseUrl + TExml + "user_id=2232&key=" + setform.tbApiKey.Text + "&limit=100&from=" + setform.dateTPFrom.Value.ToString("yyyy-MM-dd") + "&to=" + setform.dateTPTo.Value.ToString("yyyy-MM-dd");
            string tempstr = _HM.get_http(tst);
            if(tempstr!="")
            {
                _xmeth.FillTEColl(_TE, tempstr);
                cnt = int.Parse(_xmeth.GetXmlValue("time_entries", "", "total_count", tempstr)) / 100;
            }
            if (cnt>0)
                for (int i =1; i<=cnt ;i++)
                {
                    tempstr = _HM.get_http(BaseUrl + TExml + "user_id=2232&key=" + setform.tbApiKey.Text + "&limit=100&from=" + setform.dateTPFrom.Value.ToString("yyyy-MM-dd") + "&to=" + setform.dateTPTo.Value.ToString("yyyy-MM-dd") + "&offset="+(100*i).ToString());
                    _xmeth.FillTEColl(_TE, tempstr);
                }
            if (_TE != null)
            {
                foreach (TimeEntry TE in _TE)
                    rtb_ROut.AppendText(String.Format("{0}{1}{2}", TE.ToString(), Environment.NewLine, Environment.NewLine));
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            _HM = new Http_Methods();
            _xmeth = new XmlMethods();
            _List = new List<Issue>();
            string tempstr;
            tempstr = _HM.get_http(BaseUrl +issuesxml+ "key=" + setform.tbApiKey.Text + "&assigned_to_id=me");
            _List = _xmeth.getIssuesProps(tempstr);
            populateTreeView(_List);
            xmlTreeView.Sort();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setform.ShowDialog();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (_List != null)
            {
                // выводим в текст бокс данные по каждой задач в коллекции задач
                foreach (Issue issue in _List)
                {
                    rtb_ROut.AppendText(String.Format("{0}{1}{2}", issue.ToString(), Environment.NewLine, Environment.NewLine));
                }
            }
            else
                MessageBox.Show("Use Tickets button");
        }

        private void postToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(setform.dateTPFrom.Value.ToString("yyyy-MM-dd"));
        }

        //сборка url строки для запроса
        private string MakeUrl(params string[] values)
        {
            return String.Format("{0}{1}{2}", values.ToString(), Environment.NewLine, Environment.NewLine);
        }

        #region TreeView functions

        // Очищаем Treeview, Создаём узлы, раскрываем
        private void populateTreeView(List<Issue> issues)
        {
            xmlTreeView.Nodes.Clear();
            addTreeNodes(issues, xmlTreeView);
            xmlTreeView.ExpandAll();
        }

        // Добавляем узлы на основе данных из коллекции задач, узлы первого уровня - статусы, в них входят задачи
        private void addTreeNodes(List<Issue> issues, TreeView treeView)
        {
            foreach (Issue issue in issues)
            {
                bool exist = false;
                if (issues.Count>0)
                {
                    // проверяем есть ли уже узлы с текстом = названию статуса
                    foreach (TreeNode node in xmlTreeView.Nodes)
                    {
                        if (node.Text == issue.Status) 
                        {
                            //нашли - выходим
                            exist=true;
                            break;
                        }                        
                    }
                    // Если не существует 
                    if (exist == false)
                        treeView.Nodes.Add(issue.Status);
                    // Ищем узел с названием статуса задачи, и создаём в нём новый узел с номером задачи.
                    xmlTreeView.SelectedNode = SearchNode(issue.Status, xmlTreeView.Nodes[0]);
                    xmlTreeView.SelectedNode.Nodes.Add(issue.ID);
                }
            }
        }
        private TreeNode SearchNode(string SearchText, TreeNode StartNode)
        {
            TreeNode node = null;
            while (StartNode != null)
            {
                if (StartNode.Text.ToLower().Contains(SearchText.ToLower()))
                {
                    //нашли - выходим
                    node = StartNode; 
                    break;
                };
                //у узла есть дочерние элементы
                if (StartNode.Nodes.Count != 0) 
                {
                    //ищем рекурсивно в дочерних
                    node = SearchNode(SearchText, StartNode.Nodes[0]);
                    if (node != null)
                    {
                        //нашли - выходим
                        break;
                    };
                };
                StartNode = StartNode.NextNode;
            };
            //вернули результат поиска
            return node;
        }
        #endregion

    }
}
