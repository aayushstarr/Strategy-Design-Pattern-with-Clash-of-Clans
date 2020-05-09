namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 2;
            double num2 = 3;
            string choice = "+";
            Operations operate = new Operations(num1, num2);

            switch (choice)
            {
                case "+":
                    operate.Addition();
                    break;
                case "-":
                    operate.Substraction();
                    break;
                case "*":
                    operate.Multiplication();
                    break;
                case "/":
                    operate.Division();
                    break;
            }
        }
    }
}
