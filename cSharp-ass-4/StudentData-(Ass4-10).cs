//10) Write a program to implement multilevel inheritance from following figure. 
//    Accept and display data for one student.

//  +------------------------------+
//  | Class student                |
//  |                              |
//  | Data Members: Roll_no , name |
//  +------------------------------+
//          |
//          ↓
//  +-------------------------------+
//  | Class Test                    |
//  |                               |
//  | Data Members: marks1 , marks2 |
//  +-------------------------------+
//          |
//          ↓
//  +-------------------------------+
//  | Class Result                  |
//  |                               |
//  | Data Members: total           |
//  +-------------------------------+


using System;
using System.Collections.Generic;
using System.Text;

namespace C_programs
{
    // Base class: Student
    class Student
    {
        public int Roll_no;
        public string Name;

        public void AcceptStudentData()
        {
            Console.Write("Enter Roll Number: ");
            Roll_no = int.Parse(Console.ReadLine());
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
        }

        public void DisplayStudentData()
        {
            Console.WriteLine("Roll Number: "+Roll_no);
            Console.WriteLine("Name: "+Name);
        }
    }

    // Derived class: Test (inherits from Student)
    class Test : Student
    {
        public int Marks1;
        public int Marks2;

        public void AcceptTestMarks()
        {
            Console.Write("Enter Marks for Subject 1: ");
            Marks1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Marks for Subject 2: ");
            Marks2 = int.Parse(Console.ReadLine());
        }

        public void DisplayTestMarks()
        {
            Console.WriteLine("Marks1: "+Marks1);
            Console.WriteLine("Marks2: "+Marks2);
        }
    }

    // Derived class: Result (inherits from Test)
    class Result : Test
    {
        public int Total;

        public void CalculateTotal()
        {
            Total = Marks1 + Marks2;
        }

        public void DisplayResult()
        {
            Console.WriteLine("Total Marks: "+Total);
        }
    }

    class StudentData
    {
        static void Main(string[] args)
        {
            // Create an object of the Result class
            Result result = new Result();

            // Accept and display student data
            result.AcceptStudentData();
            result.AcceptTestMarks();
            result.CalculateTotal();

            Console.WriteLine("\n--- Student Details ---");
            result.DisplayStudentData();
            result.DisplayTestMarks();
            result.DisplayResult();

            Console.ReadKey();
        }
    }
}
