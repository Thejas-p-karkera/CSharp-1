using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_1
{
    class EmpDetails
    {
        static void Main()
        {
            Console.Write("Enter Employee name: ");
            string empName = Console.ReadLine();

            int empNo;
            while (true)
            {
                Console.Write("Enter Employee number(Between 100 & 200): ");
                empNo = Convert.ToInt32(Console.ReadLine());

                if (empNo >= 100 && empNo <= 200)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Employee number! Employee number should be between 100 & 200.");
                }
            }


            char empGrade;
            while (true)
            {
                Console.Write("Enter Employee grade (A,B or C): ");
                empGrade = Convert.ToChar(Console.ReadLine().ToUpper());

                if (empGrade == 'A' || empGrade == 'B' || empGrade=='C')
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Error! Invalid Grade. Please enter a correct garde(A,B or C).");
                }
            }


            double salary;
            while (true)
            {
                Console.WriteLine("Enter Employee salary (Between 2000 & 7000): ");
                salary = Convert.ToDouble(Console.ReadLine());

                if (salary >= 2000 && salary <= 7000)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid salary! salary should be between 2000 & 7000.");
                }
            }

            double da = salary * 0.10;
            double hra = salary * 0.05;
            double net = salary + da + hra;

            Console.WriteLine("\n Employee Details:");
            Console.WriteLine("Employee Name: " + empName);
            Console.WriteLine("Employee Number: " + empNo);
            Console.WriteLine("Employee Grade: " + empGrade);
            Console.WriteLine("Employee salary: " + salary);
            Console.WriteLine("DA: " + da);
            Console.WriteLine("HRA: " + hra);
            Console.WriteLine("Net Salary: " + net);
        }

    }
}
