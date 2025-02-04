using System;
using System.Collections.Generic;
using System.Text;

namespace MyLibraryClient
{
    class Program
    {
        static void Main(string[] args)
        {
            StringOperatons str = new StringOperatons();
            Console.WriteLine(str.RemoveSpaces("M G G"));
            Console.ReadLine();
        }

    }
}
