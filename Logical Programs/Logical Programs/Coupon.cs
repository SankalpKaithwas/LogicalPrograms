using System;

namespace Logical_Programs
{
    internal class Coupon
    {
        public void GetCoupon()
        {
            Console.WriteLine("Enter number of coupons");
            int number = int.Parse(Console.ReadLine());
            string coupons = string.Empty;
            while (number > 0)
            {
                int random = new Random().Next(1, 123);
                coupons += (char)random;
                number--;
            }
            Console.Write("Your coupon number is " + coupons);

        }
    }
}
