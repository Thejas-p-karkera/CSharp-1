using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_2
{
    class sumOfIntegers
    {
        static void Main(String[] args)
        {
            Console.Write("Enter  lower limit: ");
            int low = int.Parse(Console.ReadLine());

            Console.Write("Enter  upper limit: ");
            int up = int.Parse(Console.ReadLine());

            Console.Write("Enter the number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int inclusive = 0;
            int exclusive = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter " + (i+1) + " element: ");
                int ele = int.Parse(Console.ReadLine());

                if (ele >= low && ele <= up)
                {
                    inclusive += ele;
                }
                else
                {
                    exclusive += ele;
                }
            }

            Console.Write("The sum of elements inside the range " + low + " & " + up + " is: " + inclusive);
            Console.Write("\nThe sum of elements outside the range " + low + " & " + up + " is: " + exclusive);

        }
    }
}
