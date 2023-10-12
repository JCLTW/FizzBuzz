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

            if (orderNumber % 5 == 0)
            {
                return "Buzz";
            }

            return orderNumber.ToString();
        }
    }
}
