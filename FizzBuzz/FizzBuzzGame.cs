using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public static string CountOff(int orderNumber)
        {
            var result = string.Empty;
            if (orderNumber % 3 == 0)
            {
                result += "Fizz";
            }

            if (orderNumber % 5 == 0)
            {
                result += "Buzz";
            }

            if (orderNumber % 7 == 0)
            {
                result += "Whizz";
            }

            return string.IsNullOrEmpty(result) ? orderNumber.ToString() : result;
        }
    }
}
