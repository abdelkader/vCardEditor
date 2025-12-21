using System.IO;
using System.Reflection;

namespace vCardEditor.Repository
{
    public class FileHandler : IFileHandler
    {
        public bool FileExist(string filename)
        {
            return File.Exists(filename);
        }

        public string GetExtension(string path)
        {
            return Path.GetExtension(path);
        }

        public string ChangeExtension(string path, string extension)
        {
            return Path.ChangeExtension(path, extension);
        }

        public void MoveFile(string newFilename, string oldFilename)
        {
            if (File.Exists(newFilename))
                File.Move(newFilename, oldFilename);
        }

        public string[] ReadAllLines(string filename)
        {
            return File.ReadAllLines(filename);
        }

        public void WriteAllText(string filename, string contents)
        {
            File.WriteAllText(filename, contents);
        }

        public void WriteBytesToFile(string imageFile, byte[] image)
        {
            using (MemoryStream ms = new MemoryStream(image))
            {
                using (FileStream fs = new FileStream(imageFile, FileMode.Create))
                    ms.WriteTo(fs);
            }
        }

        public string GetVcfFileName(string folderPath, string filename)
        {
            return Path.Combine(folderPath, filename + ".vcf");
        }

        public string GetFileNameWithExtension(string fileName, int index, string extension)
        {
            return Path.Combine(Path.GetDirectoryName(fileName), index.ToString() + "." + extension);
        }

        public string[] GetFiles(string path, string ext)
        {
            return Directory.GetFiles(path, ext, SearchOption.TopDirectoryOnly);
        }

        public string LoadJsonFromAssembly(string EmbeddedResourceName)
        {
            string json;
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream(EmbeddedResourceName))
            {
                if (stream == null)
                    throw new FileNotFoundException($"Embedded resource '{EmbeddedResourceName}' not found.");

                using (StreamReader reader = new StreamReader(stream))
                    json = reader.ReadToEnd();
            }
            return json;
        }

        public Stream OpenRead(string filename)
        {
            return new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
        }
    }
}
