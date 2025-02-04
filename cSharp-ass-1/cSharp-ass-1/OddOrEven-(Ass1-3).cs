using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_1
{
    class OddOrEven
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to check if it is Odd or Even: ");
            string num = Console.ReadLine();
            int num1;

            if(!int.TryParse(num, out num1))
            {
                Console.WriteLine("Enter a valid number");
                return;
            }

            if(num1 % 2 == 0)
            {
                Console.WriteLine("it is Even number");
            }
            else
            {
                Console.WriteLine("it is odd number");
            }

            Console.ReadLine();
        }
    }
}
