using System;

namespace _01_Calculator
{
    public class Calculator
    {
        public static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        public static int Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

        public static int Sum(int[] numbers)
        {
            int allsum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                allsum = allsum + numbers[i];

            }
            return allsum;
        }

        public static int Multiply(int v1, int v2)
        {
            return v1 * v2;
        }

        public static object Multiply(int v1, int v2, int v3)
        {
            return v1 * v2 * v3;
        }

        public static double Power(int v1, int v2)
        {
            return Math.Pow(v1, v2);
        }

        public static int Factorial(int v)
        {
            int result = 1;
            for (int i = 2; i <= v; i++)
            {
                result = result * i;
            }
            return result;
        }
    }
}