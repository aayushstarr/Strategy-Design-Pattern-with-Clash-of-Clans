using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args) {
            double num1 = 2;
            double num2 = 3;
            double result = 0.0;
            string choice = "+";

            switch (choice) {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    result = num1 / num2;
                    break;
            }

            Console.WriteLine("Result is " + result);
        }
    }
}
