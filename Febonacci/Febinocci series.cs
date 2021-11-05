using System;
using System.Collections.Generic;
using System.Text;

namespace Febonacci
{
    public class Febinocci_series
    {
        public void printSeries()
        {
            Console.WriteLine("Enter the number:");
            int num = int.Parse(Console.ReadLine());
            int a = 0, b = 1, c, i;
            for(i=2;i<=num;i++)
            {
                c = a + b;
                Console.WriteLine("The febinocci_Series is:"+c);
                a = b;
                b = c;
            }
        }
    }
}
