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

        public string DecryptQQ(string qq)
        {
            string result="";

            return result;
        }
    }
}