//8) Demonstrate members of object class

using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_3
{
    class ObjectClass
    {
        public int id;
        public string name;

        static void Main(string[] args)
        {
            ObjectClass obj1 = new ObjectClass();
            obj1.id = 1;
            obj1.name = "Demo1";

            Console.WriteLine("Type : "+obj1.GetType());
            Console.WriteLine("To string : "+obj1.ToString());
            Console.WriteLine("Hash code : "+obj1.GetHashCode());

            ObjectClass obj2 = new ObjectClass();
            obj2.id = 2;
            obj2.name = "Demo2";

            Console.WriteLine("Equals? : "+obj1.Equals(obj2));

            ObjectClass obj3 = (ObjectClass)obj2.MemberwiseClone();
            Console.WriteLine("Cloned object: id = "+obj3.id+", name = "+obj2.name);
        }
    }
}
