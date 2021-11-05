using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Febonacci
{
    public class StopWatch
    {
        public void printWatch()
        {
            Console.WriteLine("Enter the start to start the stopwatch:");
            String str1 = Console.ReadLine();
            StopWatch watch= null;

            if(str1.Equals("start"))
            {
                new StopWatch();
                //watch.Start();
            }
            Console.WriteLine("enter the end to end the stopwatch");
            String str2 = Console.ReadLine();
            if(str2.Equals("stop"))
            {
                //watch.Stop();
            }
        }
    }
}
