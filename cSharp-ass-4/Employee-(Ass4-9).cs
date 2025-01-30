//9) Write a program for above class hierarchy for the Employee where the 
//    base class is Employee and derived class and Programmer and Manager.
//    Here make display function virtual which is common for all and which will 
//    display information of Programmer and Manager interactively.


//             +------------+
//             | Employee   |
//             +------------+
//                   |
//            ---------------
//           |               |
//           ↓               ↓
//    +------------+ +------------+
//    | Programmer | | Manager    |
//    +------------+ +------------+



using System;
using System.Collections.Generic;
using System.Text;

namespace C_programs
{
    // Base class
    class Employee
    {
        public string name;
        public int id;

        public Employee(string name, int id)
        {
            this.name = name;
            this.id = id;
        }
        public virtual void Display()
        {
            Console.WriteLine("Name: "+name+", ID: "+id);
        }
    }

    // Derived class: Programmer
    class Programmer : Employee
    {
        public string programmingLanguage;

        public Programmer(string name, int id, string programmingLanguage) : base(name, id) 
        {
            this.programmingLanguage = programmingLanguage;
        }
        public override void Display()
        {
            Console.WriteLine("\nProgrammer Information:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Programming Language: " + programmingLanguage);
        }
    }

    // Derived class: Manager
    class Manager : Employee
    {
        public int teamSize;

        public Manager(string name, int id, int teamSize) : base(name, id)
        {
            this.teamSize = teamSize;
        }

        public override void Display()
        {
            Console.WriteLine("Manager Information:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Team Size: " + teamSize);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee ID: ");
            int id = int.Parse(Console.ReadLine());

            Employee employee = new Employee(name, id);

            Console.Write("Enter Programming Language: ");
            string programmingLanguage = Console.ReadLine();

            Programmer programmer = new Programmer(name, id,programmingLanguage);

            Console.Write("Team Size: ");
            int teamSize = int.Parse(Console.ReadLine());

            Manager manager = new Manager(name, id, teamSize);
            
            programmer.Display();
            Console.WriteLine();
            manager.Display();
        }
    }
}