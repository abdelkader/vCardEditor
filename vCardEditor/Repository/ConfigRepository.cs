using System;
using System.Xml.Serialization;
using System.IO;
using System.ComponentModel;
using vCardEditor.Model;

namespace vCardEditor.Repository
{
    [XmlRoot("Config")]
    [Serializable]
    public class ConfigRepository : IConfigRepository
    {
        private static string ConfigFileName
        {
            get { return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "config.xml"); }
        }

        private const int MAX_RECENT_FILES = 5;
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
        public bool Overwrite { get; set; }
       
        [Description("Maximum entries for MRU ")]
        public int Maximum { get; set; }
        
        [Description("Url for checking application version")]
        public string VersionUrl { get; set; }
        
        [Browsable(false)]
        public FixedList Paths { get; set; }

        [Browsable(false)]
        public FormState FormState;

        private ConfigRepository() { }

        /// <summary>
        /// save config file
        /// </summary>
        public void SaveConfig()
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces();
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
            ConfigRepository configData = null;

            try
            {
                if (!File.Exists(ConfigFileName))
                    throw new Exception();

                XmlSerializer deserializer = new XmlSerializer(typeof(ConfigRepository));
                using (TextReader reader = new StreamReader(ConfigFileName))
                {
                    configData = (ConfigRepository)deserializer.Deserialize(reader);
                    configData.Paths.Size = configData.Maximum;
                }
            }
            catch (Exception)
            {
                configData = new ConfigRepository
                {
                    Maximum = MAX_RECENT_FILES,
                    Paths = new FixedList(MAX_RECENT_FILES),
                    VersionUrl = "https://raw.githubusercontent.com/abdelkader/vCardEditor/master/vCardEditor/Releases.txt"
                };
            }

            return configData;
        }
    }
}
