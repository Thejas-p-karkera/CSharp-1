//10) Write a program to illustrate 5 different access specifier.

using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_3
{
    public class BaseClass
    {
        public string publicVrbl = "This is a Public Field";

        private string privateVrbl = "This is a Private Field";

        protected string protectedVrbl = "This is a Protected Field";

        internal string internalVrbl = "This is a Internal Field";

        protected internal string protectedInternalVrbl = "This is a Protected Internal Field";

        public void test()
        {
            Console.WriteLine();
            Console.WriteLine("***Accessing properties from Public class***");
            Console.WriteLine(publicVrbl);
            Console.WriteLine(privateVrbl);
            Console.WriteLine(protectedVrbl);
            Console.WriteLine(internalVrbl);
            Console.WriteLine(protectedInternalVrbl);
        }
    }

    public class DerivedClass : BaseClass
    {
        public void derivedTest()
        {
            Console.WriteLine();
            Console.WriteLine("***Accessing properties from Derived class***");
            Console.WriteLine(publicVrbl);
            //Console.WriteLine(privateVrbl);   Not Accesible
            Console.WriteLine(protectedVrbl);
            Console.WriteLine(internalVrbl);
            Console.WriteLine(protectedInternalVrbl);
        }
    }

    internal class InternalClass
    {
        public void internalTest()
        {
            BaseClass baseClass = new BaseClass();

            Console.WriteLine();
            Console.WriteLine("***Accessing properties from Internal class***");
            Console.WriteLine(baseClass.publicVrbl);
            //Console.WriteLine(baseClass.privateVrbl);   Not Accesible
            //Console.WriteLine(baseClass.protectedVrbl);   Not Accesible
            Console.WriteLine(baseClass.internalVrbl);
            Console.WriteLine(baseClass.protectedInternalVrbl);
        }
    }

    class AccessMod
    {
        static void Main(String[] args)
        {
            BaseClass baseClass = new BaseClass();
            baseClass.test();

            DerivedClass derivedClass = new DerivedClass();
            derivedClass.derivedTest();

            InternalClass internalClass = new InternalClass();
            internalClass.internalTest();
        }
    }
}
