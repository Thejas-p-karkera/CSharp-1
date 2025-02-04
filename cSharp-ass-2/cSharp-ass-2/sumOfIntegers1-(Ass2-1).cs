using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_2
{
    class sumOfIntegers1
    {
        static void Main(String[] args)
        {
            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int []arr = new int[n];
            //for-loop to insert elements into the array
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter " + (i + 1) + " element: ");
                arr[i] = int.Parse(Console.ReadLine());                              
            }

            Console.Write("Enter  lower limit: ");
            int low = int.Parse(Console.ReadLine());

            Console.Write("Enter  upper limit: ");
            int up = int.Parse(Console.ReadLine());

            int inclusive = 0;
            int exclusive = 0;
            //fo-loop to get sum of the elements
            for (int i = 0; i < n; i++)
            {
                if (arr[i] >= low && arr[i] <= up)
                {
                    inclusive += arr[i];
                }
                else
                {
                    exclusive += arr[i];
                }
            }

            Console.Write("The sum of elements inside the range " + low + " & " + up + " is: " + inclusive);
            Console.Write("\nThe sum of elements outside the range " + low + " & " + up + " is: " + exclusive);

        }
    }
}
