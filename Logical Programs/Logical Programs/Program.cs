using System;

namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose 1: Fibonacci series");
            int option = int.Parse(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.FibonacciSeries();
                    break;
                default:
                    Console.WriteLine("Enter valid option");
                    break;
            }
        }
    }
}
