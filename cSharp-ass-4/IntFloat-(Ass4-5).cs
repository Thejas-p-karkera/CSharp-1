//5) Enter a number. If the number is an integer value then throw the exception.
//    If the number is floating point number then round the number to an indicated decimal number.

using System;
using System.Collections.Generic;
using System.Text;

namespace C_programs
{
    class IntFloat
    {
        static void Main()
        {
            try
            {
                Console.Write("Enter a number: ");
                string input = Console.ReadLine();

                // Check if the input is an integer
                int intNumber;
                if (int.TryParse(input, out intNumber))
                {
                    throw new Exception("Input is an integer. Exception thrown.");
                }

                // Check if the input is a floating-point number
                double floatingNumber;
                if (double.TryParse(input, out floatingNumber))
                {
                    Console.Write("Enter decimal places to round: ");
                    int decimals = int.Parse(Console.ReadLine());

                    // Round the floating-point number
                    double rounded = Math.Round(floatingNumber, decimals);
                    Console.WriteLine("Rounded number: " +rounded);
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}