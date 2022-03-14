using System;

namespace Logical_Programs
{
    internal class Prime
    {
        public void IsPrime()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 1; i <= number; i++)
            {
                if(number%i== 0)
                {
                    count++;
                }
            }
            if(count == 2)
            {
                Console.WriteLine($"{number} is a Prime Number");
            }
            else
            {
                Console.WriteLine($"{number} is Not a Prime Number");
            }


        }
    }
}