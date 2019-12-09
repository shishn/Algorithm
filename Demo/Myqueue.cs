using System;
using System.Collections;

namespace Demo
{
    public class MyQueue:IMyQueue
    {
        private ArrayList list = new ArrayList();
        public MyQueue()
        {
        }

        public object DeQueue()
        {
            object result=null;
            if (!this.IsEmpty())
            {
                result = list[0];
                list.RemoveAt(0);
            }
            return result;
        }

        public void EnQueue(object o)
        {
            list.Add(o);
        }

        public void Init(char[] source)
        {
            for (int i = 0; i < source.Length; i++)
            {
                list.Add(source[i]);
            }
        }

        public bool IsEmpty()
        {
            return this.list.Count == 0;
        }

        public int Size()
        {
            return list.Count;
        }
    }
}