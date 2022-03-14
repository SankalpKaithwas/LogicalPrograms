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
                default:
                    Console.WriteLine("Enter valid option");
                    break;
            }
        }
    }
}
