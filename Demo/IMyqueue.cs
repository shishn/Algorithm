using System;
using System.Collections;

namespace Demo
{
    public interface IMyQueue
    {
        public void Init(char[] source);
        void EnQueue(object o);
        object DeQueue();
        bool IsEmpty();
        int Size();
    }
}
