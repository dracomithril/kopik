using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace KopikUtils
{
    [Serializable]
    public class BasicSettings
    {
        [XmlIgnore]
        const string _fileName = "settings.xml";
        [XmlIgnore]
        public static string settingsPath
        {
            get
            {
                return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, _fileName);
            }
        }
        public BasicSettings()
        {
            CopyThis = new List<string>();
        }
        [XmlElement("RepoDir")]
        public string RepoDir { get; set; }

        [XmlElement("CopyThis")]
        public List<string> CopyThis { get; set; }
    }
}