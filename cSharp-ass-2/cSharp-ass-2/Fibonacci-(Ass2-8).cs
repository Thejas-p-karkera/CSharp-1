using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_2
{
    class Fibonacci
    {
        static void Main(string[] args)
        {
            int []arr = new int[15];

            arr[0] = 1;
            arr[1] = 1;

            for (int i = 2; i < 15; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            Console.WriteLine("First 15 fibonacci numbers: ");
            foreach (int a in arr)
            {
                Console.Write(a + " ");
            }
        }
    }
}
