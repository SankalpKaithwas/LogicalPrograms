using System;

namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose 1: Fibonacci series");
            Console.WriteLine("Choose 2: Perfect Number");
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
                default:
                    Console.WriteLine("Enter valid option");
                    break;
            }
        }
    }
}
