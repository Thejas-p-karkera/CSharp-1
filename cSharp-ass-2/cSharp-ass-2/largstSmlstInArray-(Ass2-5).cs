using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_2
{
    class largstSmlstInArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the size of the array: ");
            int n = int.Parse(Console.ReadLine());
            int []arr = new int[n];

            Console.WriteLine("Enter " + n + " elements into the array:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("The array elements are: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Array.Sort(arr);
            Console.Write("\nThe array elements after sorting: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }



            for (int i = n - 1; i > 0; i--)
            {
                if (arr[i] != arr[i - 1])
                {
                    Console.Write("\nThe second largest element in the array is: " + arr[i-1]);
                    break;
                }
            }

            for (int i = 0; i < n-1; i++)
            {
                if (arr[i] != arr[i + 1])
                {
                    Console.Write("\nThe second smallest element in the array is: " + arr[i + 1]);
                    break;
                }
            }

        }
    }
}
