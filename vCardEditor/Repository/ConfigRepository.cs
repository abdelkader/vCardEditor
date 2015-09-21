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
    public class ConfigRepository
    {
        private static string ConfigFileName 
        {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.xml");  }
        }

        private static ConfigRepository instance = null;
        [XmlIgnore]
        public static ConfigRepository Instance
        {
            get
            {
                if (instance == null)
                    instance = LoadConfig();

                return instance;
            }
        }

        public bool OverWrite;
        [XmlArrayItemAttribute("Folder")]
        public List<string> Paths;

        private ConfigRepository() {}

        /// <summary>
        /// 
        /// </summary>
        public void SaveConfig()
        {
            var ns = new XmlSerializerNamespaces();
            ns.Add("", ""); 

            XmlSerializer xsSubmit = new XmlSerializer(typeof(ConfigRepository));
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
        private static ConfigRepository LoadConfig()
        {
            ConfigRepository obj;

            if (!File.Exists(ConfigFileName))
            {
                obj = new ConfigRepository();
                obj.Paths = new List<string>();
                return obj;
            }
                
            try
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(ConfigRepository));
                using (TextReader reader = new StreamReader(ConfigFileName))
                    obj = (ConfigRepository)deserializer.Deserialize(reader);
                
            }
            catch (Exception)
            {
                obj = new ConfigRepository();
                obj.Paths = new List<string>();
            }
            

            return obj;
        }
    }
    }
