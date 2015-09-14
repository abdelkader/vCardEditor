using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vCardEditor.Repository
{
    public interface IFileHandler
    {
        string[] ReadAllLines(string filename);
        void WriteAllText(string fileName, string contents);
    }
}
