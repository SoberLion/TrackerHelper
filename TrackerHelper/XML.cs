using System;
using System.IO;
using System.Xml.Serialization;

namespace TrackerHelper
{
    class XML
    {
        public static T Deserialize<T>(string XmlString) where T : class
        {
            try
            {
                XmlSerializer ser = new XmlSerializer(typeof(T));
                using (StringReader sr = new StringReader(XmlString))
                    return (T)ser.Deserialize(sr);
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
