using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var ex=new Exercise();
            var result=ex.FindPerfectNumber(10000);
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
            
        }
    }
}
