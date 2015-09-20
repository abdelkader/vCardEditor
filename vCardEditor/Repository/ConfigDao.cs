using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.IO;

namespace vCardEditor.Repository
{
    public class ConfigDao : IConfigDao
    {
        public string ConfigFileName { get; set; }
        string minimalConfigFile = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>" + Environment.NewLine +
                                    "<configuration>" + Environment.NewLine +
                                     " <appSettings>" + Environment.NewLine +
                                      "</appSettings>" + Environment.NewLine +
                                    "</configuration>";

        private static ConfigDao instance = null;

        public static ConfigDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new ConfigDao();
                
                return instance;
            }
        }

        private ConfigDao()
        {
            ConfigFileName = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None).FilePath;
         
            //if config not found, create one.
            if (!File.Exists(ConfigFileName))
                File.WriteAllText(ConfigFileName, minimalConfigFile);
        }


        public string GetConfigKey(string key)
        {
            string returnValue = null;

            if (ConfigurationManager.AppSettings[key] != null)
                returnValue = ConfigurationManager.AppSettings[key];

            return returnValue;


        }

        public void SaveConfigFile(string Key, string value)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings.Remove(Key);
            config.AppSettings.Settings.Add(Key, value);
            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

       
    }
}
