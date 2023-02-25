using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Linq;

namespace Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring arrays
            int[] array1 = new int[] { 1, 2, 10, 50, 5 };
            int[] array2;

            //Other excercises
            Console.WriteLine(AddAndMultiply(5, 4, 3));
            Console.WriteLine(CelsiusToFar(-30));
            Console.WriteLine(convertToSec(5));
            Console.WriteLine(Addition(5));
            Console.WriteLine(LessThanOrEqualToZero(0));
            Console.WriteLine(MonthName(12));
            Console.WriteLine(CalculateExponent(10, 10));
            Console.WriteLine(Factorial(5));
            Console.WriteLine(HammingDistance("abcde", "abcdd"));

            //Array Sorting exercise;
            array2 = SortNumsAscending(array1);
            Console.Write("Sorted array: ");
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(Sum(2, 3));
            Console.WriteLine(ElementaryOperation(23, 4));
            Console.WriteLine(isResultTheSame(3 * 3, 10 - 1));
            Console.WriteLine(ModuloOperations(8, 5, 2));
            Console.WriteLine(CubeOf(-5.5));
            Console.WriteLine(SwapTwoNumbers(5, 15));
            Console.WriteLine(AbsoluteValue(-50));
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

        //Check if number is less than or equal to zero
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

        public static int triArea(int b, int h)
        {
            return (b * h) / 2;
        }

        //Convert number to month name
        public static string MonthName(int num)
        {
            DateTime date = new DateTime(2020, num, 1);

            return date.ToString("MMMM");
        }

        //Calculate exponent
        public static long CalculateExponent(long number, long exponent)
        {
            return (long)Math.Pow(number, exponent);
        }
        
        //Calculate factorial
        public static int Factorial(int num)
        {
            int f = 1;
            for(int i = 1; i <= num; i++)
            {
                f *= i;
            }
            return f;
        }

        //Hamming distance
        public static int HammingDistance(string str1, string str2)
        {
            int num = 0;
            var StrArray1 = str1.ToCharArray();
            var StrArray2 = str2.ToCharArray();

            for (int i = 0; i < StrArray1.Length; i++)
            {
                if (StrArray1[i] != StrArray2[i])
                {
                    num++;
                }
            }

            return num;
        }

        //Sort array in ascending order
        public static int[] SortNumsAscending(int[] arr)
        {
            return arr.OrderBy((a) => a).ToArray();
        }

        //Sum of 2 numbers
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        //Elementary operation
        public static String ElementaryOperation(int a, int b)
        {
            int addition = a + b;
            int subtraction = a - b;
            int multiplication = a * b;
            double division;

            if(b != 0)
            {
                division = a / (double)b;
            }
            else
            {
                division = 0;
            }

            return String.Format($"a + b = {addition}, a - b = {subtraction}, a * b = {multiplication}, a / b = {division}");
        }

        //Check wether the result is the same
        public static bool isResultTheSame(double a, double b)
        {
            return a == b;
        }

        public static int ModuloOperations(int a, int b, int c)
        {
            return (a % b) % c;
        }

        //Cube calculation
        public static double CubeOf(double a)
        {
            return Math.Pow(a, 3);
        }

        //Swap two numbers
        public static string SwapTwoNumbers(int a, int b)
        {
            String before = $"Before: a = {a}, b = {b} ";

            int c = a;
            a = b;
            b = c;

            String after = $"After: a = {a}, b = {b} ";

            return before + after;
        }

        //Absolute value
        public static int AbsoluteValue(int a)
        {
            if(a >= 0)
            {
                return a;
            }
            else
            {
                return a * -1;
            }
        }
    }
}
