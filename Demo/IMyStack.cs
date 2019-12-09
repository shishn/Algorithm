using System;
using System.Collections;

namespace Demo
{
    public interface IMyStack
    {
        void Push(object o);
        object Pop();
        object Peek();
        bool IsEmpty();
        int Size();
    }
}
