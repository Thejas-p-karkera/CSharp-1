using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_1
{
    class ArthOp1
    {
        static void Main(string[] args)
        {           
            Console.WriteLine("MENU");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multilpy");
            Console.WriteLine("4. Devide");
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter 1st number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Enter 2nd number: ");
            double num2 = double.Parse(Console.ReadLine());

            ArthOp1 a = new ArthOp1();

            if (choice == 1)
            {
                a.add(num1, num2);
            }
            else if (choice == 2)
            {
                a.sub(num1, num2);         
            }
            else if (choice == 3)
            {
                a.mul(num1, num2);
            }
            else if (choice == 4)
            {
                a.div(num1, num2);
            }
            else
            {
                Console.WriteLine("Invalid choice.");            
            }
        }

        void add(double num1, double num2)
        {
            double result = num1 + num2;
            Console.WriteLine("Result : " + result);
        }

        void sub(double num1, double num2)
        {
            double result = num1 - num2;
            Console.WriteLine("Result : " + result);
        }

        void mul(double num1, double num2)
        {
            double result = num1 * num2;
            Console.WriteLine("Result : " + result);
        }

        void div(double num1, double num2)
        {
            if (num2 != 0)
            {
                double result = num1 / num2;
                Console.WriteLine("Result : " + result);
            }
            else
            {
                Console.WriteLine("Error");

            }
        }
    }
}
