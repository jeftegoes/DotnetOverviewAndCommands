using System;
using System.Collections.Generic;

namespace ExampleIEnumrableYield
{
    class Program
    {
        public static IEnumerable<int> Potency(int number, int exponent)
        {
            int result = 1;

            for (var i = 0; i < exponent; i++)
            {
                result = result * number;
                yield return result;
            }
        }

        public static void Print(IEnumerable<int> enumerable)
        {
            foreach (var number in enumerable)
            {
                Console.Write($" { number } ");
            }
        }

        static void Main(string[] args)
        {
            Print(Potency(2, 3));
        }
    }
}
