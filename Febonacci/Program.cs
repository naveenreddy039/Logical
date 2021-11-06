using System;

namespace Febonacci
{
    public class Program
    {
        public static void Main(string[] args)
        {
            label: Console.WriteLine("1.fibonacci series \n 2.Perfect Number \n 3.Prime Number\n 4.Reverse number \n 5.Coupen Numbers \n 6.Stop Watch");
            Console.WriteLine("Type the option");
            int i = int.Parse(Console.ReadLine());

            switch (i)
            {
                case 1:
                    Console.WriteLine("1.fibonacci series:");
                    Febinocci_series febinocciSeries = new Febinocci_series();
                    febinocciSeries.printSeries();
                    break;
                case 2:
                    Console.WriteLine("2.Perfect Number:");
                    PerfectNumber perfectNumber = new PerfectNumber();
                    perfectNumber.printPerfect();
                    break;
                case 3:
                    Console.WriteLine("3.Prime Number:");
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.printPrime();
                    break;
                case 4:
                    Console.WriteLine("4.Reverse number:");
                    ReverseNumber reverseNumber = new ReverseNumber();
                    reverseNumber.printReverse();
                    break;
                case 5:
                    Console.WriteLine("5.Coupen Numbers:");
                    CoupenNumbers coupenNumbers=new CoupenNumbers();
                    coupenNumbers.printCoupen(5);
                    break;
                case 6:
                    Console.WriteLine("6.Stop Watch:");
                    StopWatch stopWatch = new StopWatch();
                    stopWatch.printWatch();
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            Console.WriteLine("Do you want to continue...y/n");
            if (Console.ReadKey().KeyChar.ToString() == "n") 
            {
            goto label;
            }
            Console.ReadKey();

        }
    }
}
