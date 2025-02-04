using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_1
{
    class ArthOp
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a 1st number: ");
                double num1 = double.Parse(Console.ReadLine());

                Console.Write("Enter a 2nd number: ");
                double num2 = double.Parse(Console.ReadLine());

                Console.Write("Enter an operator(+, -, *, /): ");
                char op = Console.ReadKey().KeyChar;
                Console.WriteLine();

                double result = 0;
                bool validOp = true;

                switch (op)
                {
                    case '+':
                        result = num1 = num2;
                        break;

                    case '-':
                        result = num1 - num2;
                        break;

                    case '*':
                        result = num1 * num2;
                        break;

                    case '/':
                        if (num2 == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed!");
                            validOp = false;
                            break;
                        }
                        else
                        {
                            result = num1 / num2;
                            break;
                        }

                    default:
                        Console.WriteLine("Invalid Operator.Please enter +,-,* or / .");
                        validOp = false;
                        break;
                }

                if (validOp)
                {
                    Console.WriteLine("Result = "+result);
                }

                Console.Write("Do you wish to continue? (yes/no): ");
                string ans = Console.ReadLine().ToLower();

                if(ans != "yes" && ans != "y")
                {
                    Console.WriteLine("Program terminated");
                    break;
                }
            }           
        }
    }
}
