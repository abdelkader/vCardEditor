using TinyJson;

namespace vCardEditor.Libs.TinyJson
{
    public class TinyJsonParser : IParser
    {
        public T Deserialize<T>(string json)
        {
            return JSONParser.FromJson<T>(json);
        }
    }
}
