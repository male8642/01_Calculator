using System;

namespace _01_Calculator
{
    internal class Calculator
    {
        internal static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        internal static int Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

        internal static int Multiply(int v1, int v2)
        {
            return v1 * v2;
        }

        internal static int Sum(int[] numbers)
        {
            int allSum = 0;
            
            for (int i = 0; i<numbers.Length; i++)

            {
                allSum = allSum + numbers[i];
            }

            return allSum;

        }

        internal static object Multiply(int v1, int v2, int v3)
        {
            return v1 * v2 * v3;
        }

        internal static double Power(int v1, int v2)
        {
            return Math.Pow(v1, v2);
        }

        internal static int Factorial(int v)
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









