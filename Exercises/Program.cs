using System;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddAndMultiply(5, 4, 3));
            Console.WriteLine(CelsiusToFar(-30));
        }

        //Add and multiply exercise
        public static double AddAndMultiply(int x, int y, int z)
        {
            return (x + y) * z;
        }

        //Celsius to farenheit exercise
        public static string CelsiusToFar(double celsius)
        {
            double farenheit = 0;
            if (celsius > -271.15)
            {
                farenheit = celsius * 1.8 + 32;
                return $"T = {farenheit}F";
            }
            else
            {
                return "Temperature does not exist";
            }
        }
    }
}
