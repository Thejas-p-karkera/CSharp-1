//9) Write a program to demonstrate array members.

using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_3
{
    class ArrayMembers
    {
        static void Main(string[] args)
        {
            // 1D Array
            int[] arr1 = {9,3,8,0,4,7,5};

            // 2D Array
            int [,] arr2 = {  {1,2,3},
                              {4,5,6},
                              {7,8,9} };

            //length, rank, getvalue, setvalue

            // 1D array members
            Console.WriteLine("*** 1D Array ***");
            Console.WriteLine("The Lenght of the array: "+arr1.Length);
            Console.WriteLine("The Rank of the array: "+arr1.Rank);
            Console.WriteLine("The value at position 2 is: "+arr1.GetValue(2));
            arr1.SetValue(10,2);
            Console.WriteLine("The updated value at position 2 is: " + arr1.GetValue(2));

            Console.WriteLine();
            Console.WriteLine("1D Arraye elements: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                    Console.Write(arr1[i] + " ");
            }

            Array.Reverse(arr1);

            Console.WriteLine("\n1D Arraye elements after Reversing: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }

            Array.Sort(arr1);

            Console.WriteLine("\n1D Arraye elements after Sorting: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }

            // 2D array members
            Console.WriteLine("\n");
            Console.WriteLine("*** 2D Array ***");
            Console.WriteLine("The Lenght of the array: " + arr2.Length);
            Console.WriteLine("The Rank of the array: " + arr2.Rank);
            Console.WriteLine("The value at position 2 is: " + arr2.GetValue(0,2));
            arr2.SetValue(10, 0, 2);
            Console.WriteLine("The updated value at position 2 is: " + arr2.GetValue(0,2));
            
            Console.WriteLine("");
            Console.WriteLine("2D Arraye elements: ");
            for (int i = 0; i < arr2.GetLength(0); i++)
            {
                for (int j = 0; j < arr2.GetLength(1); j++)
                {
                    Console.Write(arr2[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
