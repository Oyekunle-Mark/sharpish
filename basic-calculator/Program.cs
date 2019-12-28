using System;

namespace basic_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Calculator 1.0\n");

            // get first operand
            Console.Write("Enter first number: ");
            string firstOperandString = Console.ReadLine();
            double firstOperand = Convert.ToDouble(firstOperandString);

            // get second operand
            Console.Write("Enter second number: ");
            string secondOperandString = Console.ReadLine();
            double secondOperand = Convert.ToDouble(secondOperandString);

            // get the operator
            Console.Write("Enter operator: ");
            char operation = (char)Console.Read();

            // result will hold the result of the operation
            double result;

            switch (operation)
            {
                case '+':
                    result = firstOperand + secondOperand;
                    break;
                case '-':
                    result = firstOperand - secondOperand;
                    break;
                case '*':
                    result = firstOperand * secondOperand;
                    break;
                case '/':
                    result = firstOperand / secondOperand;
                    break;
                case '%':
                    result = firstOperand % secondOperand;
                    break;
                case '^':
                    result = Math.Pow(firstOperand, secondOperand);
                    break;
                default:
                    Console.WriteLine($"Invalid operator {operation}");
                    return;
            }

            // print result
            Console.WriteLine($"The value of {firstOperand} {operation} {secondOperand} is {result}");
        }
    }
}
