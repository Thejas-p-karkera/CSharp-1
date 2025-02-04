using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_1
{
    class Practise
    {
        static void Main()
        {
            Console.Write("Enter a number to reverse and to sund its sum of digits: ");
            int num = int.Parse(Console.ReadLine());

            if (isPrime(num))
            {
                Console.WriteLine("It is a prime number");
            }
            else
            {
                Console.WriteLine("It is not a prime number");
                Console.WriteLine("The factors of number "+num+" are: ");
                factors(num);
            }


            //Console.WriteLine("");
        }

        static void reverse(int num)
        {
            int sum=0;
            int reveredNumber = 0;

            int digit = num % 10;
            reveredNumber = reveredNumber * 10 + digit;
            sum = sum + digit;

            Console.Write(reveredNumber);
        }

        static void factors(int num)
        {
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    Console.Write(i+" ");
                }
            }
        }
    }
}
