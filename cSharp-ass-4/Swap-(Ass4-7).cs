//7) Write a program using function overloading to swap two integer numbers and swap two float numbers.

using System;
using System.Collections.Generic;
using System.Text;

namespace C_programs
{
    class Swap
    {
        public static void swap(int a, int b)
        {
            Console.WriteLine("Before swap: a = "+a+", b = "+b);
            int temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swap: a = " + a + ", b = " + b);
        }

        // Function to swap two float numbers
        public static void swap(float a, float b)
        {
            Console.WriteLine("Before swap: a = "+a+", b = "+b);
            float temp = a;
            a = b;
            b = temp;
            Console.WriteLine("After swap: a = " + a + ", b = " + b);
        }

        static void Main()
        {
            // Swapping integers
            Console.WriteLine("Swapping integers:");
            swap(5, 10);

            // Swapping floats
            Console.WriteLine("\nSwapping floats:");
            swap(5.5f, 10.5f);
        }
    }
}