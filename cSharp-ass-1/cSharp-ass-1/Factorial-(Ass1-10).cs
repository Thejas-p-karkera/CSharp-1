using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_1
{
    class Factorial
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a numbr to find its factorial: ");
            string num = Console.ReadLine();

            int num1;
            if(!int.TryParse(num, out num1))
            {
                Console.WriteLine("Enter a valid number.");
            }

            Factorial f = new Factorial();
            Console.WriteLine("The Factorial of "+num1+" is: "+f.fact(num1));
        }

        int fact(int num1)
        {
            if (num1 == 0 || num1 == 1)
            {
                return 1;
            }
            else
            {
                return num1 * fact(num1 - 1);
            }
        }
    }
}
