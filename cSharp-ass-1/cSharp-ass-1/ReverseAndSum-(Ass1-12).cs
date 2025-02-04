using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_1
{
    class ReverseAndSum
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number to reverse it and to find the sum of its digits: ");
            int number = int.Parse(Console.ReadLine());           

            int rversedNumber = 0;
            int sumOfDigits = 0;
            int temp = number;

            for (int i = number; i > 0; i /= 10)
            {
                int digit = temp % 10;
                rversedNumber = rversedNumber * 10 + digit;
                sumOfDigits = sumOfDigits + digit;
                temp = temp / 10;
            }
            Console.WriteLine("Reversed number: "+rversedNumber);
            Console.WriteLine("Sum of digits: "+sumOfDigits);
        }
    }
}
