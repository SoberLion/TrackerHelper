using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerHelper
{
    public static class Test
    {
        private static string NameField = "Name";
        private static string SurnameField = "Surname";

        public static string Name
        {
            get { return NameField; }
            set { NameField = value; }
        }
        public static string Surname
        {
            get { return SurnameField; }
            set { SurnameField = value; }
        }
    }
}
