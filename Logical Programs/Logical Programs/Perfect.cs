using System;

namespace Logical_Programs
{
    internal class Perfect
    {
        public void PerfectNumber()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            int temp = number;
            int div = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    div += i;
                }
            }
            if (temp == div)
            {
                Console.WriteLine($"{temp} is a perfect number");
            }
            else
            {
                Console.WriteLine($"{temp} is not a perfect number");
            }
        }
    }
}