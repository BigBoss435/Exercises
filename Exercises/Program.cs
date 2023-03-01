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
            double[] array3 = new double[] { 0.5, 0.6, 5, 7, 9 };
            double[] array4;

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
            Console.WriteLine(CircuitPower(50, 5) + " W");
            array4 = FindMinMax(array3);
            Console.Write("Min Max: ");
            for (int i = 0; i < array4.Length; i++)
            {
                Console.Write(array4[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(CountClaps("ClaClaClaClap"));
            Console.WriteLine(NSidedShape(5));
            Console.WriteLine(DivisibleBy2Or3(6, 11));

            //Find numbers which added up equate to target
            int[] arr = { 1, 2, 3, 9 };
            int[] arr1;
            int target = 12;
            arr1 = TwoSum(arr, target);
            Console.WriteLine($"Numbers that added up equal target of {target} ");
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine(IfConsistsOfUppercaseLetters("drY"));
            Console.WriteLine(IfGreaterThanThirdOne(new int[] { 2, 8, 12 }));
            Console.WriteLine(IfNumberIsEven(51));
            Console.WriteLine(IfSortedAscending(new int[] { 1, 4, 5 }));
            Console.WriteLine(IsLonelyIsland("DCA"));
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
        
        //Circuit power
        public static int CircuitPower(int voltage, int current)
        {
            return voltage * current;
        }

        //Find min max numbers
        public static double[] FindMinMax(double[] values)
        {
            double maxValue = values.Max();
            double minValue = values.Min();
            double[] arr = { minValue, maxValue };
            return arr;
        }

        //Count Claps(words that start with C)
        public static int CountClaps(string txt)
        {
            char[] arr = txt.ToCharArray();
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 'C')
                {
                    count++;
                }
            }
            return count;
        }

        //Return name of polygon based on number of sides
        public static string NSidedShape(int n)
        {
            String nameOfPolygon = "";
            switch (n)
            {
                case 1:
                    nameOfPolygon = "circle";
                    break;
                case 2:
                    nameOfPolygon = "semi-circle";
                    break;
                case 3:
                    nameOfPolygon = "triangle";
                    break;
                case 4:
                    nameOfPolygon = "square";
                    break;
                case 5:
                    nameOfPolygon = "pentagon";
                    break;
                case 6:
                    nameOfPolygon = "hexagon";
                    break;
                case 7:
                    nameOfPolygon = "heptagon";
                    break;
                case 8:
                    nameOfPolygon = "octagon";
                    break;
                case 9:
                    nameOfPolygon = "nonagon";
                    break;
                case 10:
                    nameOfPolygon = "decagon";
                    break;
            }
            return nameOfPolygon;
        }

        //Divisible by 2 or 3
        public static int DivisibleBy2Or3(int a, int b)
        {
            if(a % 2 == 0 && b % 2 == 0 && a % 3 == 0 && b % 3 == 0)
            {
                return a * b;
            }
            else
            {
                return a + b;
            }
        }

        //Find two numbers indexes from array that give desired result
        public static int[] TwoSum(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[j] == target - nums[i])
                    {
                        return new int[] { i, j };
                    }
                }
            }
            return null;
        }

        //Check if string consists of uppercase letters using ascii table
        public static bool IfConsistsOfUppercaseLetters(string str)
        {
            return (str[0] >= 65 && str[1] >= 65 && str[2] >= 65) && (str[0] <= 90 && str[1] <= 90 && str[2] <= 90);
        }

        //Check if multiplication of first two elements is greater than third one
        public static bool IfGreaterThanThirdOne(int[] arr)
        {
            if ((arr[0] * arr[1] > arr[2]) || (arr[0] + arr[1] > arr[2]))
            {
                return true;
            }
            else { return false; }
        }

        //Check if number is even
        public static bool IfNumberIsEven(int x)
        {
            return x % 2 == 0;
        }

        //Check if array is sorted in ascensing order
        public static bool IfSortedAscending(int[] arr)
        {
            return (arr[0] <= arr[1] && arr[1] <= arr[2]);
        }

        //Check wether letter has neighbour in alphabet
        public static bool IsLonelyIsland(string str)
        {
            return str[0] == str[1] + 1 || str[0] == str[1] - 1 || str[2] == str[1] - 1 || str[2] == str[1] + 1; 
        }
    }
}
