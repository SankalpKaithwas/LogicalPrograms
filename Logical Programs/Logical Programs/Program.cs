using System;

namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose 1: Fibonacci series");
            Console.WriteLine("Choose 2: Perfect Number");
            Console.WriteLine("Choose 3: Prime Number");
            Console.WriteLine("Choose 4: Reverse Number");
            Console.WriteLine("Choose 5: Coupon Number");
            Console.WriteLine("Choose 6: StopWatch");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.FibonacciSeries();
                    break;
                case 2:
                    Perfect perfect = new Perfect();
                    perfect.PerfectNumber();
                    break;
                case 3:
                    Prime prime = new Prime();
                    prime.IsPrime();
                    break;
                case 4:
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.Reverse();
                    break;
                case 5:
                    Coupon coupon = new Coupon();
                    coupon.GetCoupon();
                    break;
                case 6:
                    StopWatch stopwatch = new StopWatch();
                    stopwatch.Run();
                    break;
                default:
                    Console.WriteLine("Enter valid option");
                    break;
            }
        }
    }
}
