using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public static string CountOff(int orderNumber)
        {
            if (orderNumber % 3 == 0 && orderNumber % 5 == 0)
            {
                return "FizzBuzz";
            }

            if (orderNumber % 3 == 0)
            {
                return "Fizz";
            }

            if (orderNumber % 5 == 0)
            {
                return "Buzz";
            }

            if (orderNumber % 7 == 0)
            {
                return "Whizz";
            }


            return orderNumber.ToString();
        }
    }
}
