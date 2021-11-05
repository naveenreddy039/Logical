using System;
using System.Collections.Generic;
using System.Text;

namespace Febonacci
{
    public class PerfectNumber
    {
        public void printPerfect()
        {
            Console.WriteLine("Enter the number:");
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int i = 1;
            while(i<=n/2)
            {
               if(n%i==0)
                {
                    sum = sum + i;
                }
                i++;
            }
            if(sum==n)
            {
                Console.WriteLine(n + "is perfect number");
            }
            else
            {
                Console.WriteLine(n + "is not a perfect number");
            }
        }
    }
}
