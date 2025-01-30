//2)	To explore different methods of System.Enum class.

using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_3
{
    enum Days
    {
        sunday = 2,
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday
    }

    class EnumClass
    {
        static void Main(string[] args)
        {
            bool isdef = Enum.IsDefined(typeof(Days),8);
            Console.WriteLine(isdef);

            bool isdef2 = Enum.IsDefined(typeof(Days), "saturday");
            Console.WriteLine(isdef2);

            string Name = Enum.GetName(typeof(Days), 4);
            Console.WriteLine(Name);
            Console.WriteLine();

            string []names = Enum.GetNames(typeof(Days));
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine();
            Array values = Enum.GetValues(typeof(Days));
            foreach (int value in values)
            {
                Console.WriteLine(value);
            }
        }
    }
}


//-------------------------------------------

/*
namespace c2program
{
    enum Day
    {
        sunday=2, monday, tuesday, wednesday, thursday, friday, saturday
    }
    class enum1
    {
        static void Main(string[] args)
        {
            bool isdef = Enum.IsDefined(typeof(Day), 9);
            bool isdef2 = Enum.IsDefined(typeof(Day), "friday");
            Console.WriteLine(isdef);
            Console.WriteLine(isdef2);
            Array names = Enum.GetNames(typeof(Day));
            string na = Enum.GetName(typeof(Day), 4);
            Console.WriteLine("names is: " + na);
            Array val = Enum.GetValues(typeof(Day));
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            foreach (int value in val)
            {
                Console.WriteLine(value);
            }
        }
    }
}
*/