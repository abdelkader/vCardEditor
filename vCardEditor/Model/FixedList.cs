using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vCardEditor.Model
{
    [Serializable]
    public class FixedList 
    {
        public List<string> _innerList { get; set; }

        private int _size;
        public int Size 
        {
            get { return _size; }
            set { _size = value; } 
        }
        public FixedList() : this(5)
        {

        }
        public FixedList(int size)
        {
            this._size = size;
            this._innerList = new List<string>(size);
        }

        public void Enqueue(string elem)
        {
            _innerList.Insert(_innerList.Count, elem);

            if (_innerList.Count > _size)
                _innerList.RemoveAt(0);
        }

        public string this[int index]
        {
            get { return _innerList[index]; }
            set { _innerList[index] = value; }
        }

        public bool Contains(string elem)
        {
            return _innerList.Any(x => string.Compare(x, elem, StringComparison.OrdinalIgnoreCase) == 0);
        }

        public bool IsEmpty()
        {
            return (this._innerList.Count == 0);
        }
    }
}
