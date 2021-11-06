using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace Febonacci
{
    public class StopWatch
    {
        public void printWatch()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("enter number:");
            for(int i=0;i<1000;i++)
            {
                Thread.Sleep(12);
            }
            stopwatch.Stop();
            Console.WriteLine("elast time:{0:hh\\:mm\\:ss}",stopwatch.Elapsed);
            ////Console.WriteLine("Enter the start to start the stopwatch:");
            //String str1 = Console.ReadLine();
            //StopWatch watch= null;

            //if(str1.Equals("start"))
            //{
            //    new StopWatch();
            //    watch.Start();
            //}
            //Console.WriteLine("enter the end to end the stopwatch");
            //String str2 = Console.ReadLine();
            //if(str2.Equals("stop"))
            //{
            //    watch.Stop();
            ////}
        }
    }
}
