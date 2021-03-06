using System;
using System.Collections;
using Demo.BookShop;
namespace Demo
{
    class Program
    {
        static Exercise ex=new Exercise();
        static void Main(string[] args) {
            //TestPerfectNum(1000000);
            //TestDecryptQQ("44724302");
            //TestPalindrome("abcdcba");
            //TestFactrial(5);
            //TestFabonacci(4);
            //TestIEnumerableBookShop();
            TestCardGame();
        }
        static void TestCardGame()
        {
            CardGame.Deck deck=new CardGame.Deck();
        }
        static void TestIEnumerableBookShop()
        {
            foreach(Book book in ex.BookStore())
            {
                Console.WriteLine("书名:{0}--作者:{1}--单价:{2}",book.Title,book.Author,book.Price);
            }
        }
        static void TestFabonacci(int num)
        {
            Console.WriteLine("第{0}位斐波那契数为：{1}",num,ex.Fabonacci(num));
        }
        static void TestFactrial(int num)
        {

            Console.WriteLine("{0}的阶乘为：{1}",num,ex.Factrial(num));
        }
        static void TestPalindrome(string s)
        {

            Console.WriteLine(ex.IsPalindrome(s) ? "是回文" : "不是回文");
        }

        static void TestDecryptQQ(string qq)
        {

            string s = ex.DecryptQQ(qq);
            
            Console.WriteLine("解密后的qq号是{0}",s);
        }
        static void TestPerfectNum(int num)
        {
            DateTime start=DateTime.Now;
            var result=ex.FindPerfectNumber(num);
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
