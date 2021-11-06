using System;
using System.Collections.Generic;
using System.Text;

namespace Febonacci
{
    public class CoupenNumbers
    {
        public void printCoupen(int n)//n=5
        {
            Random random = new Random();
            //n = random.Next(1, 9);
            int check = random.Next(1, 9);
            //Console.WriteLine("enter the coupen Limit:");
            int count = 0;
            Console.WriteLine("coupen number is:" + n);
            while(n>0)
            {
                if(check==n)
                {
                    Console.WriteLine("number is present");
                    break;
                }
                count++;
                Console.WriteLine("count:" + count);
                n--;

            }
            Console.WriteLine("to get number we need count " + count);                     
        }
    }
}
