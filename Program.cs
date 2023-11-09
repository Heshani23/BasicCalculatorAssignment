using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculatorAssignment
{
    internal class Program
    {
        // The goal of this assignment is to learn how to create and use methods in our code
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Exit");

                Console.Write("Choose an operation: ");
                int choice = int.Parse(Console.ReadLine());

                if (choice == 5)
                {
                    break;
                }

                Console.Write("Enter first number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                double num2 = double.Parse(Console.ReadLine());

                double result = 0;

                switch (choice)
                {
                    case 1:
                        result = Add(num1, num2);
                        break;
                    case 2:
                        result = Subtract(num1, num2);
                        break;
                    case 3:
                        result = Multiply(num1, num2);
                        break;
                    case 4:
                        result = Divide(num1, num2);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please choose a valid operation.");
                        break;
                }

                Console.WriteLine($"Result: {result}");
            }
        }

        private static double Add(double a, double b)
        {
            return a + b;
        }

        private static double Subtract(double a, double b)
        {
            return a - b;
        }

        private static double Multiply(double a, double b)
        {
            return a * b;
        }

        private static double Divide(double a, double b)
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero. Please enter a non-zero divisor.");
                return 0;
            }
        }
    }
}
