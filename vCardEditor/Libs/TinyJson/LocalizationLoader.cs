using vCardEditor.Repository;

namespace vCardEditor.Libs.TinyJson
{
    public class LocalizationLoader
    {
        private readonly IParser _parser;
        private readonly IFileHandler _fileHandler;

        public LocalizationLoader(IParser parser, IFileHandler fileHandler)
        {
            _parser = parser;
            _fileHandler = fileHandler;
        }

        public LocalizationFile LoadEmbedded(string EmbeddedResourceName = "vCardEditor.i18n.lang.json")
        {
            string json = _fileHandler.LoadJsonFromAssembly(EmbeddedResourceName);
            return Deserialize(json);
        }


        private LocalizationFile Deserialize(string json)
        {
            var result = _parser.Deserialize<LocalizationFile>(json);
            return result ?? new LocalizationFile();
        }

    }
}
