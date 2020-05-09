using System;

namespace SimpleCalculator
{
    class Operations
    {
        private double num1, num2;
        public Operations(double num1, double num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public void Addition()
        {
            Console.WriteLine($"Addition of {num1} and {num2} is {num1 + num2}");
        }

        public void Substraction()
        {
            Console.WriteLine($"Substraction of {num1} and {num2} is {num1 - num2}");
        }

        public void Multiplication()
        {
            Console.WriteLine($"Multiplication of {num1} and {num2} is {num1 * num2}");
        }

        public void Division()
        {
            try
            {
                Console.WriteLine($"Division of {num1} and {num2} is {num1 / num2}");
            } catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot perform division. Denominator should not be zero." + ex);
            }
        }
    }
}
