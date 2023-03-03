using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Calculator!");

            // Prompt the user for the first number
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());

            // Prompt the user for the second number
            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());

            // Prompt the user for the operator
            Console.Write("Enter the operator (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine());

            // Calculate the result based on the operator
            double result;
            switch (op)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    return;
            }

            // Print the result
            Console.WriteLine("Result: " + result);
            Console.ReadLine();
        }
    }
}