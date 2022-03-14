using System;

namespace Logical_Programs
{
    internal class Fibonacci
    {
        public void FibonacciSeries()
        {
            Console.WriteLine("Enter a number to get fibonacci series: ");
            int number = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int secondNumber = 1;
            int result;
            if (number <= 1)
            {
                Console.WriteLine(firstNumber + "  " + secondNumber + " ");
            }
            else
            {
                Console.Write(firstNumber + " " + secondNumber + " ");
                for (int i = 2; i < number; i++)
                {
                    result = firstNumber + secondNumber;
                    Console.Write(result + " ");
                    firstNumber = secondNumber;
                    secondNumber = result;
                }
            }
        }
    }
}