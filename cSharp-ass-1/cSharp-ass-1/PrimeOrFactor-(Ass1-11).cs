using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_1
{
    class PrimeOrFactor
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if (IsPrime(num))
            {
                Console.WriteLine(num + " is a prime number");
            }
            else
            {
                Console.WriteLine(num + " is not a prime number");
                Console.Write("The factors of " + num + " are: ");
                DisplayFactors(num);
            }

        }

        static bool IsPrime(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void DisplayFactors(int num)
        {
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(i + " ");
                }                
            }
            Console.WriteLine(" ");
        }
    }
}
