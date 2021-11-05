using System;
using System.Collections.Generic;
using System.Text;

namespace Febonacci
{
    public class PrimeNumber
    {
        public void printPrime()
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int i, a = 0, flag = 0;
            a = num / 2;
            if(num==0||num==1)
            {
                Console.WriteLine(num+"is not prime Number");
            }
            else
            {
                for(i=2;i<a;i++)
                {
                    if(num%i==0)
                    {
                        Console.WriteLine(num + "is not a prime Number");
                        flag = 1;
                        break;
                    }
                }
                if(flag==0)
                {
                    Console.WriteLine(num + "is prime number");
                }
            }
        }
    }
}
