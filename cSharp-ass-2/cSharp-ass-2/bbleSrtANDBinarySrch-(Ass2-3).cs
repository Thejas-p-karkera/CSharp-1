using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_2
{
    class bbleSrtANDBinarySrch
    {
        static void Main(String[] args)
        {
            int []arr = new int[args.Length];

            for (int i = 0; i < args.Length; i++)
            {
                if (!int.TryParse(args[i], out arr[i]))
                {
                    Console.WriteLine("Enter a valid number in command line arguments.");
                    return;
                }
                //arr[i] = args[i];
            }

            Console.Write("The numbers in the array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }

            bubbleSort(arr);

            int ele;
            Console.Write("\nEnter the element to search: ");
            if (!int.TryParse(Console.ReadLine(), out ele))
            {
                Console.WriteLine("Enter a valid number.");
                return;
            }

            
            binarySearch(arr, ele);
        }

      
        static void bubbleSort(int[] arr)
        {
            //sorting
            int count = 1;
            while (count < arr.Length)
            {
                for (int i = 0; i < arr.Length - count; i++)
                {
                    if(arr[i+1] < arr[i])
                    {
                        int temp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = temp;
                    }
                }
                count++;
            }
            
            
            Console.Write("\nThe array after sorting: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }

        static void binarySearch(int[] arr, int ele)
        {
            int st = 0;
            int end = arr.Length - 1;

            while (st <= end)
            {
                int mid = (st + end) / 2;

                if (ele > arr[mid])
                {
                    st = mid + 1;
                }
                else if (ele < arr[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    Console.WriteLine(ele + " is present in the array at " + mid);
                    return;
                }
            }
            Console.WriteLine(ele + " is not present in the array");
        }
    }
}
