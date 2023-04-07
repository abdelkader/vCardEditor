using System;
using System.Collections.Generic;
using System.IO;


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

        public void MoveFile(string newFilename, string oldFilename)
        {
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
    }
}
