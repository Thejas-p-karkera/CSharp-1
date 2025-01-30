//6) Write a program to handle both System and Custom exceptions using try and catch block.

using System;
using System.Collections.Generic;
using System.Text;

namespace C_programs
{
    //Step 1: Create a custom exception class
    public class AgeException : Exception
    {
        public string CustomMessage;  // Directly using a field

        public AgeException(string message)
        {
            CustomMessage = message;  // Assign the message to the field
        }

        public override string ToString()
        {
            return CustomMessage;  // Override ToString to return the custom message
        }
    }

    class Exceptions
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your age:");
                int age = int.Parse(Console.ReadLine());

                // Step 2: Check if the age is valid
                if (age < 18)
                {
                    // Step 3: Throw a custom exception if age is less than 18
                    throw new AgeException("Age must be 18 or older.");
                }

                Console.WriteLine("You are eligible.");
            }
            catch (AgeException ex)
            {
                // Step 4: Catch and handle the custom exception
                Console.WriteLine("Error: " + ex.ToString());  // Use ToString() to get the message
            }
            catch (Exception ex)
            {
                // Handle other exceptions
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
    }
}


//--------------------------------------------------------------------------------

//    using System;

//namespace CustomExceptionExample
//{
//    // Step 1: Create a custom exception class
//    public class AgeException : Exception
//    {
//        public AgeException(string message) : base(message)
//        {
//        }
//    }

//    class Program
//    {
//        static void Main(string[] args)
//        {
//            try
//            {
//                Console.WriteLine("Enter your age:");
//                int age = int.Parse(Console.ReadLine());

//                // Step 2: Check if the age is valid
//                if (age < 18)
//                {
//                    // Step 3: Throw a custom exception if age is less than 18
//                    throw new AgeException("Age must be 18 or older.");
//                }

//                Console.WriteLine("You are eligible.");
//            }
//            catch (AgeException ex)
//            {
//                // Step 4: Catch and handle the custom exception
//                Console.WriteLine("Error: " + ex.Message);
//            }
//            catch (Exception ex)
//            {
//                // Handle other exceptions
//                Console.WriteLine("An unexpected error occurred: " + ex.Message);
//            }
//        }
//    }
//}
