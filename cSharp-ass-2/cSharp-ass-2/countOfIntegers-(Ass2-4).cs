using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_2
{
    class countOfIntegers
    {
        static void Main(String[] args)
        {
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int negCount = 0;
            int posCount = 0;
            int zeroCount = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter " + (i + 1) + " element: ");
                int ele = int.Parse(Console.ReadLine());

                arr[i] = ele;

                if (ele < 0)
                {
                    negCount++;
                }
                else if (ele > 0)
                {
                    posCount++;
                }
                else
                {
                    zeroCount++;
                }
            }

            Console.Write("The number of +ve integers: " + posCount);
            Console.Write("\nThe number of -ve integers: " + negCount);
            Console.Write("\nThe number of zero's: " + zeroCount);
        }
    }
}
