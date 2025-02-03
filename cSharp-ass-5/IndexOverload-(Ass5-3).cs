using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_programs
{
    class IndexOverload
    {
        string []name = new string [3];

        public string this[int i]
        {
            get { return name[i]; }
            set { name[i] = value; }
        }

        public string this[float i]
        {
            get { return name[1];  }
            set { name[1] = value; }
        }

        public string this[double i]
        {
            get { return name[2]; }
            set { name[2] = value; }
        }

        static void Main()
        {
            IndexOverload s = new IndexOverload();

            s[0] = "C#";
            s[1.0] = "Programming";
            s[2.0f] = "Language";

            Console.WriteLine("1: " + s[0]);
            Console.WriteLine("2: " + s[1.0]);
            Console.WriteLine("3: " + s[2.0f]);
        }
    }
}
