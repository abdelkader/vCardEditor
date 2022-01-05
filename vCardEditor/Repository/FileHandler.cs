using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace vCardEditor.Repository
{
    public class FileHandler : IFileHandler
    {
        public bool FileExist(string filename)
        {
            return File.Exists(filename);
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
