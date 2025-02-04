using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_1
{
    class First15PrimeNumbers
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("First 15 Prime Numbers: ");

            for (int number = 2; count < 15; number++)
            {
                if (IsPrime(number))
                {
                    Console.WriteLine(number);
                    count++;
                }
            }
        }        
            static bool IsPrime(int num)
            {
                for (int i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
