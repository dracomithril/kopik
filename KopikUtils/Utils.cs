using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace KopikUtils
{
    public class Utils
    {
        public static void SerializeXML(object obj, string path)
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(KopikUtils.BasicSettings));
            using (var wr = new StreamWriter(path))
            {
                ser.Serialize(wr, obj);
            }
        }
        public static object DeserlializeXML(string path)
        {
            XmlSerializer ser = new XmlSerializer(typeof(KopikUtils.BasicSettings));
            using (var rd = new StreamReader(path))
            {
                return ser.Deserialize(rd);
            }
        }
    }
}
