using System;

namespace VCFEditor.View
{
    //http://stackoverflow.com/questions/3312134/does-net-have-a-built-in-eventargst
    
    public class EventArg<T> : EventArgs
    {
        public EventArg(T data)
        {
            Data = data;
        }

        public T Data { get; set; }
    }
}
