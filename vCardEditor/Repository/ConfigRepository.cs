using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.ComponentModel;
using vCardEditor.Model;
using System.Runtime.Serialization;

namespace vCardEditor.Repository
{
    [XmlRoot("Config")]
    [Serializable]
    public class ConfigRepository
    {
        private static string ConfigFileName
        {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.xml"); }
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

        [Description("Overwrite the file when saving")]
        public bool OverWrite { get; set; }
        [Description("Maximum entries for MRU ")]
        public int Maximum { get; set; }

        [Browsable(false)]
        public FixedList Paths { get; set;}

        private ConfigRepository() { }



        /// <summary>
        /// save config file
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
        /// Load config file.
        /// </summary>
        /// <returns></returns>
        private static ConfigRepository LoadConfig()
        {
            ConfigRepository obj;

            try
            {
                if (!File.Exists(ConfigFileName))
                    throw new Exception();

                XmlSerializer deserializer = new XmlSerializer(typeof(ConfigRepository));
                using (TextReader reader = new StreamReader(ConfigFileName))
                {
                    obj = (ConfigRepository)deserializer.Deserialize(reader);
                    obj.Paths.Size = obj.Maximum;
                }

            }
            catch (Exception)
            {
                obj = new ConfigRepository();
                obj.Paths = new FixedList(5);
            }


            return obj;
        }

       
    }
}
