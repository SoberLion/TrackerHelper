using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TrackerHelper.RedmineEntities
{
    [XmlRoot("users", IsNullable = false)]
    class Users
    {       
        private int _total_count = 0;
        private int _offset = 0;
        private int _limit = 100;
        private string _type = string.Empty;
        private List<Issue> issueField = new List<Issue>();

        [XmlAttribute]
        public int total_count
        {
            get { return _total_count; }
            set { _total_count = value; }
        }

        [XmlAttribute]
        public int offset
        {
            get { return _offset; }
            set { _offset = value; }
        }

        [XmlAttribute]
        public int limit
        {
            get { return _limit; }
            set { _limit = value; }
        }

        [XmlAttribute]
        public string type
        {
            get { return _type; }
            set { _type = value; }
        }

        [XmlElement(IsNullable = false)]
        public List<Issue> issue
        {
            get { return issueField; }
            set { issueField = value; }
        }

        public void IncOffset() => offset = total_count - offset < limit ? total_count : offset + limit;
    }

    public class user
    {
        private int _id = 0;
        private int _login = 0;
        private string _firstname = string.Empty;
        private string _lastname = string.Empty;
        private string _mail = string.Empty;
        private string _created_on = string.Empty;
        private string _last_login_on = string.Empty;
    //    private List<custom_field> custom_fieldsField = new List<custom_field>();




        /*

	<custom_fields type="array">
		<custom_field id="17" name="Компания">
			<value>ЦТО Торгмонтаж</value>
		</custom_field>
		<custom_field id="18" name="Город">
			<value>Не определен</value>
		</custom_field>
		<custom_field id="56" name="Офис">
			<value>
			</value>
		</custom_field>
		<custom_field id="29" name="Номер кабинета">
			<value>
			</value>
		</custom_field>
		<custom_field id="28" name="Внутренний номер">
			<value>
			</value>
		</custom_field>
		<custom_field id="55" name="Отдел (список)">
			<value>
			</value>
		</custom_field>
		<custom_field id="33" name="Отдел">
			<value>
			</value>
		</custom_field>
		<custom_field id="57" name="Должность (список)">
			<value>
			</value>
		</custom_field>
		<custom_field id="30" name="Должность">
			<value>
			</value>
		</custom_field>
		<custom_field id="58" name="Мобильный телефон">
			<value>
			</value>
		</custom_field>
		<custom_field id="59" name="Проекты">
			<value/>
		</custom_field>
		<custom_field id="61" name="Аттестация по RK7">
			<value>
			</value>
		</custom_field>
	</custom_fields>
         */

    }

}
