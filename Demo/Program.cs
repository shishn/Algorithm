using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
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
