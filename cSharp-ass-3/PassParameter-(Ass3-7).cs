//7) To demonstrate different ways of passing parameter to a method.

using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_3
{
    class PassParameter
    {
        static void Main(String[] args)
        {
            int num = 10;

            Console.WriteLine("Before passing value using ref: "+num);
            refParametr(ref num);
            Console.WriteLine("After passing value using ref: " + num);

            int a;
            outParametr(out a);
            Console.WriteLine("After passing value using out: " + a);

            paramParametr(1, 5, 8, 3, 7, 9);
        }

        static void refParametr(ref int num)
        {
            num += num;
        }

        static void outParametr(out int a)
        {
            a = 50;
        }

        static void paramParametr(params int []arr)
        {
            Console.Write("Using Params keyword: ");

            foreach (int nums in arr)
            {
                Console.Write(nums + " ");
            }
        }
    }
}
