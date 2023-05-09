using System.Collections.Generic;

namespace vCardEditor.Model
{
    public struct FormState
    {
        public List<Column> Columns { get; set; }
        public int X { get; set; }

        public int Y { get; set; }

        public int Height { get; set; }

        public int Width { get; set; }

        public int splitterPosition { get; set; }

    }
}
