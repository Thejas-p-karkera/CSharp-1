//2)	Illustrate shallow copy and deep copy .

using System;
using System.Collections.Generic;
using System.Text;

namespace C_programs
{
    class ShlwDpCopy
    {
        static void Main(string[] args)
        {
            // Creating an array of integers
            int[] arr = {1, 2, 3};

            // Shallow copy: Copy the reference (both refer to the same array)
            int[] shallowCopy = arr;

            // Deep copy: Create a new array and copy the values from the original array
            int[] deepCopy = (int[])arr.Clone();

            // Modify the original array
            arr[0] = 100;

            // Display all arrays to show the difference
            Console.WriteLine("Original array:");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nShallow copy:");
            foreach (int item in shallowCopy)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.WriteLine("\nDeep copy:");
            foreach (int item in deepCopy)
            {
                Console.Write(item + " ");
            }
        }
    }
}