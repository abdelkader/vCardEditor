using System.IO;
using System.Reflection;
using TinyJson;

namespace vCardEditor.Libs.TinyJson
{
    public static class LocalizationLoader
    {
        private const string EmbeddedResourceName = "vCardEditor.i18n.lang.json";

        public static LocalizationFile LoadEmbedded()
        {
            var assembly = Assembly.GetExecutingAssembly();
            
            using (var stream = assembly.GetManifestResourceStream(EmbeddedResourceName))
            {
                if (stream == null)
                    throw new FileNotFoundException($"Ressource embarquée '{EmbeddedResourceName}' introuvable.");

                using (var reader = new StreamReader(stream))
                {
                    var json = reader.ReadToEnd();
                    return Deserialize(json);
                }
            }
        }

        //public static LocalizationFile LoadFromFile(string filePath)
        //{
        //    if (!File.Exists(filePath))
        //        return new LocalizationFile(); // fichier inexistant, retourne un fichier vide

        //    var json = File.ReadAllText(filePath);
        //    return Deserialize(json);
        //}

        private static LocalizationFile Deserialize(string json)
        {
            var result = JSONParser.FromJson<LocalizationFile>(json);
            return result ?? new LocalizationFile();
        }

    }
}
