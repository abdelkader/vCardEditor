using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VCFEditor.View
{

    //public class ArgumentEventArgs : EventArgs
    //{
    //    public object argument { get; set; } 
    //}
    
    //http://stackoverflow.com/questions/3312134/does-net-have-a-built-in-eventargst
    
    public class EventArg<T> : EventArgs
    {
        // Property variable
        private T p_EventData;

        // Constructor
        public EventArg(T data)
        {
            p_EventData = data;
        }

        // Property for EventArgs argument
        public T Data
        {
            get { return p_EventData; }
            set { p_EventData = value;}
        }
    }
}
