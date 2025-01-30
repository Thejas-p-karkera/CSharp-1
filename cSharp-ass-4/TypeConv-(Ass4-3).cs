//3)	Demonstrate implicit and explicit custom type conversions,
//          (Conversion between METER and KILOMETER class types).

using System;
using System.Collections.Generic;
using System.Text;

namespace C_programs
{
    class Meter
    {
        public double meters;

        public Meter(double meters)
        {
            this.meters = meters;
        }

        // Implicit conversion: Meter to Kilometer
        public static implicit operator Kilometer(Meter m)
        {
            return new Kilometer(m.meters / 1000);
        }
    }

    class Kilometer
    {
        public double kilometers;

        public Kilometer(double kilometers)
        {
            this.kilometers = kilometers;
        }

        // Explicit conversion: Kilometer to Meter
        public static explicit operator Meter(Kilometer km)
        {
            return new Meter(km.kilometers * 1000);
        }
    }

    class TypeConv
    {
        static void Main()
        {
            // Implicit conversion: Meter to Kilometer
            Meter m = new Meter(1500); // 1500 meters
            Kilometer km = m; // Implicit conversion
            Console.WriteLine(m.meters + "meters = " + km.kilometers + " kilometers");

            // Explicit conversion: Kilometer to Meter
            Kilometer km2 = new Kilometer(2.5); // 2.5 kilometers
            Meter m2 = (Meter)km2; // Explicit conversion
            Console.WriteLine(km2.kilometers + "kilometers = " + m2.meters+" meters");
        }
    }

}