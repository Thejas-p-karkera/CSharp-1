using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_2
{
    class sumOfRows
    {
        static void Main(string[] args)
        {
            int [,]arr = new int[3,3];

            //For-loop to insert elements into the array
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Enter "+j+"th element for row "+i+" : ");
                    arr[i,j] = int.Parse(Console.ReadLine());
                }
            }

            //For-loop to get the sum of rows
            for (int i = 0; i < 3; i++)
            {
                int rowsum = 0;

                for (int j = 0; j < 3; j++)
                {
                    rowsum += arr[i, j];
                }
                Console.WriteLine("The sum of elements in row " + i + " : " + rowsum);
            } 

        }
    }
}
