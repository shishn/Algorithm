using System;
using System.Collections;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestPerfectNum();
            // TestDecryptQQ();
            TestPalindrome("abcdcba");
        }
        static void TestPalindrome(string s)
        {
            var queue = new MyQueue();
            queue.Init(s.ToCharArray());
            int length=queue.Size();
            int mid=length/2;
            var stack=new MyStack();
            for(int i=0;i<mid;i++)
            {
                stack.Push(queue.DeQueue());
            }
            if(length%2!=0)
            {
                queue.DeQueue();
            }
            while (!queue.IsEmpty())
            {
                if((char)stack.Pop()!=(char)queue.DeQueue())
                {
                    Console.WriteLine("不是回文");
                    return;
                }
            }
            Console.WriteLine("是回文");
        }

        static void TestDecryptQQ()
        {
            string qq = "44724302";
            string s = "";
            ArrayList result = new ArrayList();
            char[] source = qq.ToCharArray();
            var queue = new MyQueue();
            queue.Init(source);
            while (!queue.IsEmpty())
            {
                char c = (char)queue.DeQueue();
                s += c.ToString();
                if (!queue.IsEmpty())
                {
                    queue.EnQueue(queue.DeQueue());
                }
            }
            Console.WriteLine(s);
        }
        static void TestPerfectNum()
        {
            DateTime start=DateTime.Now;
            var ex=new Exercise();
            var result=ex.FindPerfectNumber(1000000);
            if(result!=null)
            {
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
                
            }
            else
            {
                Console.WriteLine("Nothing!");
            }
            DateTime end=DateTime.Now;
            Console.WriteLine("操作用时：{0}",end-start);
        }
    }
}
