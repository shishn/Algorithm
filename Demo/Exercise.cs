using System;
using System.Collections;

namespace Demo
{
    public class Exercise
    {
        public ArrayList FindPerfectNumber(int end)
        {
            var result=new ArrayList();
            for (int i = 1; i <= end; i++)
            {
                if (IsPerfectNumber(i))
                {
                    result.Add(i);
                }
            }
            return result;
        }

        private bool IsPerfectNumber(int num)
        {
            var result=false;
            int sum=0;
            var sqrt=Math.Sqrt(num);
            for(int i=1;i<=sqrt;i++)
            {
                if(i!=1)
                {
                   if(0==num%i)
                    {
                        sum+=i;
                        sum+=num/i;
                    } 
                }
                else
                {
                    sum+=1;
                }
            }
            if(sum==num && num!=1)
            {
                result=true;
            }
            
            return result;
        }

        public bool IsPalindrome(string s)
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
                    return false;
                }
            }
            return true;
        }
        public string DecryptQQ(string qq)
        {
            string result="";
            char[] source = qq.ToCharArray();
            var queue = new MyQueue();
            queue.Init(source);
            while (!queue.IsEmpty())
            {
                char c = (char)queue.DeQueue();
                result += c.ToString();
                if (!queue.IsEmpty())
                {
                    queue.EnQueue(queue.DeQueue());
                }
            }
            return result;
        }

        public int Factrial(int number)
        {
            int result=1;
            if(number==0)
            {
                return 1;
            }
            else 
            {
                result=number*Factrial(number-1);
            }
            return result;

        }

        public int Fabonacci(int num)
        {
            if(num<=1)
            {
                return 1;
            }
            return Fabonacci(num-1)+Fabonacci(num-2);
        }
    }
}