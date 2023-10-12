using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public static string CountOff(int orderNumber)
        {
            if (orderNumber % 3 == 0)
            {
                return "Fizz";
            }

            return orderNumber.ToString();
        }
    }
}
