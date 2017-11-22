using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Text;
using System.Threading.Tasks;

namespace TrackerHelper
{
    public class TreeViewMethods
    {
        #region TreeView methods

        // Очищаем Treeview, Создаём узлы, раскрываем
        public static void populateTreeView(List<Issue> issues, TreeView treeView)
        {
            treeView.BeginUpdate();
            treeView.Nodes.Clear();
            addTreeNodes(issues, treeView);
            treeView.CollapseAll();
            treeView.EndUpdate();
        }

        // Добавляем узлы на основе данных из коллекции задач, узлы первого уровня - статусы, в них входят задачи
        private static void addTreeNodes(List<Issue> issues, TreeView treeView)
        {
            foreach (Issue issue in issues)
            {
                bool exist = false;
                if (issues.Count > 0)
                {
                    // проверяем есть ли уже узлы с текстом = названию статуса
                    foreach (TreeNode node in treeView.Nodes)
                    {
                        //if (node.Text == issue.status.name)
                        if (node.Text.Contains(issue.status.name))
                        {
                            //нашли - выходим
                            exist = true;
                            break;
                        }
                    }
                    // Если не существует 
                    if (exist == false)
                        treeView.Nodes.Add(issue.status.name);
                    // Ищем узел с названием статуса задачи, и создаём в нём новый узел с номером задачи.
                    treeView.SelectedNode = SearchNode(issue.status.name, treeView.Nodes[0]);
                    treeView.SelectedNode.Text = issue.status.name + " : " + (treeView.SelectedNode.Nodes.Count+1).ToString();
                    treeView.SelectedNode.Nodes.Add(issue.id);
                }
            }
        }
        private static TreeNode SearchNode(string SearchText, TreeNode StartNode)
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
                    }
                }
                StartNode = StartNode.NextNode;
            }
            //вернули результат поиска
            return node;
        }
        #endregion
    }
}
