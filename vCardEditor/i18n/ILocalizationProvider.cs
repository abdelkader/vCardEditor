using System.Collections.Generic;


namespace vCardEditor
{
    public interface ILocalizationProvider
    {
        string this[string key] { get; }

        void SetLanguage(string langCode);

      
        string CurrentLanguage { get; }

        IReadOnlyDictionary<string, string> CurrentMessages { get; }

        IEnumerable<string> AvailableLanguages { get; }

        
        IEnumerable<string> AvailableLanguageNames { get; }
    }
}
