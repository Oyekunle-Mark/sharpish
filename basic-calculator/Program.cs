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
            string operation = Console.ReadLine();
            
            Console.WriteLine("Operation is " + firstOperand + operation + secondOperand);
        }
    }
}
