using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vCardEditor.Repository
{
    public interface IConfigDao
    {
        string ConfigFileName { get; set; }
        string GetConfigKey(string key);
        void SaveConfigFile(string Key, string value);
    }
}
