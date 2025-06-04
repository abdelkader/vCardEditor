namespace vCardEditor.Libs.TinyJson
{
    public interface IParser
    {
        T Deserialize<T>(string json);
    }
}
