using vCardEditor.Model;

namespace vCardEditor.Repository
{
    public interface IConfigRepository
    {
        int Maximum { get; set; }
        bool OverWrite { get; set; }
        FixedList Paths { get; set; }

        void SaveConfig();
    }
}