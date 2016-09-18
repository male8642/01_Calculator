using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _01_Calculator;

namespace CalculatorApplication
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Write a number for x");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Write a number for y");
            int y = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Choose a option");
            
            Console.WriteLine("1 - add");
            Console.WriteLine("2 - subtract");
            Console.WriteLine("3 - multiply");
            Console.WriteLine("4 - Factorial");
            Console.WriteLine("5 - Power");
            Console.WriteLine("6 - Divide");
            
            int z = Convert.ToInt32(Console.ReadLine());
            switch (z)
            {

                case 1:

                    Console.WriteLine(Calculator.Add(y, x));

                break;

                case 2:

                    Console.WriteLine(Calculator.Subtract(x, y));

                break;

                case 3:

                    Console.WriteLine(Calculator.Multiply(x, y));

                break;

                case 4:
                    //It takes the value of x. 
                    Console.WriteLine(Calculator.Factorial(x));

                break;

                case 5:

                    Console.WriteLine(Calculator.Power(y, x));

                break;

                case 6:

                    Console.WriteLine(Calculator.Divide(x, y));

                 break;


            }
            Console.ReadKey();





        }
    }
}
