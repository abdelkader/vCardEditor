using System.IO;

namespace vCardEditor.Repository
{
    public interface IFileHandler
    {
        void MoveFile(string newFilename, string oldFilename);
        bool FileExist(string filename);
        string[] ReadAllLines(string filename);
        void WriteAllText(string fileName, string contents);
        string GetExtension(string path);
        string ChangeExtension(string path, string extension);
        void WriteBytesToFile(string imageFile, byte[] image);
        string GetVcfFileName(string folderPath, string familyName);
        string GetFileNameWithExtension(string fileName, int index, string extension);
        string LoadJsonFromAssembly(string EmbeddedResourceName);
        string[] GetFiles(string path, string ext);

        Stream OpenRead(string filename);
    }
}
