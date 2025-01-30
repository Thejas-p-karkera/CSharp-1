//6) To demonstrate passing reference by value and passing reference by reference.

using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_3
{
    class PassValue
    {
        static void Main(String[] args)
        {
            int num = 10;

            Console.WriteLine("Before passing by value, the value is: "+num);
            passByVal(num);
            Console.WriteLine("after passing by value, the value is: " + num);

            Console.WriteLine("");

            Console.WriteLine("Before passing by referance, the value is: " + num);
            passByRef(ref num);
            Console.WriteLine("after passing by referance, the value is: " + num);
        }

        static void passByVal(int num)
        {
            num = num + num;

        }

        static void passByRef(ref int num)
        {
            num = num + num;

        }
    }
}
