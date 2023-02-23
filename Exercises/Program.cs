using System;
using System.Runtime.InteropServices;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(AddAndMultiply(5, 4, 3));
            Console.WriteLine(CelsiusToFar(-30));
            Console.WriteLine(convertToSec(5));
            Console.WriteLine(Addition(5));
            Console.WriteLine(LessThanOrEqualToZero(0));
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

        //Convert minnutes to seconds
        public static int convertToSec(int minutes)
        {
            return minutes * 60;
        }

        //Add +1 to number
        public static int Addition(int num)
        {
            return num + 1;
        }

        public static bool LessThanOrEqualToZero(double a)
        {
            if (a <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
