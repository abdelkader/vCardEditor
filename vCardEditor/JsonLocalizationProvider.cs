using System.Collections.Generic;
using System.Linq;
using vCardEditor.Libs.TinyJson;

namespace vCardEditor
{
    public class JsonLocalizationProvider : ILocalizationProvider
    {
        private readonly LocalizationFile _localization;
        private string _currentLanguage;
        
        public JsonLocalizationProvider(LocalizationFile localization, string defaultLanguage = "en")
        {
            _localization = localization;
            _currentLanguage = defaultLanguage;
        }

        public void SetLanguage(string langCode)
        {
            if (_localization.languages.ContainsKey(langCode))
                _currentLanguage = langCode;
        }

        public string this[string key]
        {
            get
            {
                if (_localization.languages.TryGetValue(_currentLanguage, out LanguageData lang))
                {
                    if (lang.messages.TryGetValue(key, out string value))
                        return value;
                }

                if (_localization.languages.TryGetValue("en", out LanguageData fallbackLang))
                {
                    if (fallbackLang.messages.TryGetValue(key, out string fallbackMsg))
                        return fallbackMsg;
                }

                return $"!{key}!";
            }
        }

        public IReadOnlyDictionary<string, string> CurrentMessages =>
            _localization.languages.TryGetValue(_currentLanguage, out LanguageData lang)
            ? lang.messages
            : new Dictionary<string, string>();

        public IEnumerable<string> AvailableLanguages => _localization.languages.Keys;

        public IEnumerable<string> AvailableLanguageNames => _localization.languages?.Values != null
                    ? _localization.languages.Values.Select(l => l?.name).Where(n => !string.IsNullOrEmpty(n))
                    : new List<string>();

        public string CurrentLanguage => _currentLanguage;
    }
}
