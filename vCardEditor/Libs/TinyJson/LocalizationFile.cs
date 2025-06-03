using System.Collections.Generic;

namespace vCardEditor.Libs.TinyJson
{
    public class LocalizationFile
    {
        public string version;
        public Dictionary<string, LanguageData> languages = new Dictionary<string, LanguageData>();
    }

    public class LanguageData
    {
        public string name;
        public Dictionary<string, string> messages = new Dictionary<string, string>();
    }
}
