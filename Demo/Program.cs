using System;
using System.Collections;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestPerfectNum();
            TestDecryptQQ();
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
