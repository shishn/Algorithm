using System;
using System.Collections;

namespace Demo
{
    public class MyStack:IMyStack
    {
        private ArrayList list = new ArrayList();
        private int top
        {
            get{
                if(!this.IsEmpty())
                {
                    return list.Count-1;
                }
                else
                {
                    return -1;
                }
            }
        }
        public MyStack()
        {
        }

        public object Pop()
        {
            object result=null;
            if (!this.IsEmpty())
            {
                result = list[top];
                list.RemoveAt(top);
            }
            return result;
        }
        public object Peek()
        {
            return list[top];
        }
        public void Push(object o)
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