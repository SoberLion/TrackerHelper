using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Xml;


namespace TrackerHelper
{
    class XmlMethods
    {
        // возвращается значение запрашиваемого элемента или аттрибута
        public string GetXmlValue(string starttag, string tagname, string attribute, string XmlString)
        {
            string ret="";
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XmlString);
            doc.PreserveWhitespace = true;
            XmlNodeList elemlist = doc.GetElementsByTagName(starttag);
            foreach (XmlNode elements in elemlist)
            {
                if (elements.NodeType == XmlNodeType.Element)
                {
                    XmlElement element = (XmlElement)elements;
                    //если не передаётся имя тега то считаем что считываются аттрибуты root element
                    if (tagname == "" || tagname == starttag)
                    {
                        ret = elements.Attributes[attribute].Value;
                        break;
                    }
                    // если аттрибут пустой считаем что считывается значение элемента
                    if (attribute != "")
                        ret = element[tagname].Attributes.GetNamedItem(attribute).Value;
                    else
                        ret = element[tagname].InnerText;
                }
            }
            return ret;        
        }

        // метод заполняет указанную коллекцию TimeEntry свойствами.
        public void FillTEColl(List<TimeEntry> TEList, string XmlString)
        {
            XmlDocument doc = new XmlDocument();
            TimeEntry TE;
            doc.LoadXml(XmlString);
            doc.PreserveWhitespace = true;
            XmlNodeList elemlist = doc.GetElementsByTagName("time_entry");
            foreach (XmlNode elements in elemlist)
            {
                TE = new TimeEntry();
                if (elements.NodeType == XmlNodeType.Element)
                {
                    XmlElement element = (XmlElement)elements;
                    TE.Id = elements["id"].InnerText;
                    TE.ProjectId = element["project"].Attributes.GetNamedItem("id").Value;
                    TE.ProjectName = element["project"].Attributes.GetNamedItem("name").Value;
                    TE.IssueId = element["issue"].Attributes.GetNamedItem("id").Value;
                    TE.UserId = element["user"].Attributes.GetNamedItem("id").Value;
                    TE.UserName = element["user"].Attributes.GetNamedItem("name").Value;
                    TE.ActivityId = element["activity"].Attributes.GetNamedItem("id").Value;
                    TE.ActivityName = element["activity"].Attributes.GetNamedItem("name").Value;
                    TE.Comment = elements["comments"].InnerText;
                    TE.CreatedOn = elements["created_on"].InnerText;
                }
                TEList.Add(TE);
            }
            //return TEList;
        }

        // метод создаёт коллекцию задач, заполняет свойства из xml.
        public List<Issue> getIssuesProps(string XmlString)
        {
            XmlDocument doc = new XmlDocument();
            List<Issue> Issues = new List<Issue>();
            Issue _Issue;
            doc.LoadXml(XmlString);
            doc.PreserveWhitespace = true;
            XmlNodeList elemlist = doc.GetElementsByTagName("issue");
            foreach (XmlNode elements in elemlist)
            {
                _Issue = new Issue();
                if (elements.NodeType == XmlNodeType.Element)
                {
                    XmlElement element = (XmlElement)elements;
                    _Issue.ID = elements["id"].InnerText;
                    _Issue.Priority = element["priority"].Attributes.GetNamedItem("name").Value;
                    _Issue.Project = element["project"].Attributes.GetNamedItem("name").Value;
                    _Issue.Assigned = element["assigned_to"].Attributes.GetNamedItem("name").Value;
                    _Issue.Category = element["category"].Attributes.GetNamedItem("name").Value;
                    _Issue.StartDate = elements["start_date"].InnerText;
                    _Issue.Status = element["status"].Attributes.GetNamedItem("name").Value;
                    _Issue.Subject = elements["subject"].InnerText;
                }
                Issues.Add(_Issue);
            }
            return Issues;
        }
    }
}
