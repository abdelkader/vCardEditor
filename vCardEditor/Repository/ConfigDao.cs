using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

namespace vCardEditor.Repository
{
    [XmlRoot("Config")]
    public class ConfigDao
    {
        private static string ConfigFileName 
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory + "config.xml";
            }
        }

        private static ConfigDao instance = null;
        [XmlIgnore]
        public static ConfigDao Instance
        {
            get
            {
                if (instance == null)
                    instance = LoadConfig();

                return instance;
            }
        }

        public bool OverWrite;
        public List<Folder> Paths;

        private ConfigDao()
        {
           
        }

        /// <summary>
        /// 
        /// </summary>
        public void SaveConfig()
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add("", ""); 

            XmlSerializer xsSubmit = new XmlSerializer(typeof(ConfigDao));
            using (StringWriter sww = new StringWriter())
            using (TextWriter writer = new StreamWriter(ConfigFileName))
            {
                xsSubmit.Serialize(writer, instance, ns);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static ConfigDao LoadConfig()
        {
            if (!File.Exists(ConfigFileName))
                return new ConfigDao();

            XmlSerializer deserializer = new XmlSerializer(typeof(ConfigDao));
            TextReader reader = new StreamReader(ConfigFileName);
            ConfigDao obj = (ConfigDao)deserializer.Deserialize(reader);
            
            reader.Close();

            return obj;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class Folder
    {
        [XmlIgnore]
        public string DisplayedName { get; set; }

        [XmlAttribute]
        public string Value { get; set; }
    }
}
