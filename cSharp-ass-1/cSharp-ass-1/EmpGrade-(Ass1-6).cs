using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_1
{
    class EmpGrade
    {
        static void Main()
        {
            string ans;

            do
            {
                Console.Write("\nEnter Employee number: ");
                int empNo = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Employee name: ");
                string empName = Console.ReadLine();

                Console.WriteLine("Enter Employee salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());

                char empGrade;
                while (true)
                {
                    Console.Write("Enter Employee grade (A,B or C): ");
                    empGrade = Convert.ToChar(Console.ReadLine().ToUpper());

                    if (empGrade == 'A')
                    {
                        salary += 300;
                        break;
                    }
                    else if (empGrade == 'B')
                    {
                        salary += 200;
                        break;
                    }
                    else if (empGrade == 'C')
                    {
                        salary += 100;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error! Invalid Grade. Please enter a correct garde(A,B or C).");
                    }
                }

                Console.WriteLine("\n Employee Details:");
                Console.WriteLine("Employee Name: " + empName);
                Console.WriteLine("Employee Number: " + empNo);
                Console.WriteLine("Employee Grade: " + empGrade);
                Console.WriteLine("Employee salary: " + salary);
                Console.WriteLine("\nDo yo want to continue?(Yes/No): ");
                ans = Console.ReadLine().ToLower();
            }
            while (ans == "yes");

            Console.WriteLine("Program Ended.");            
        }
    }
}
