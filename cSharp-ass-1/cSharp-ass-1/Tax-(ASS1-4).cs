using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_1
{
    class Tax
    {
        static void Main()
        {
            Console.Write("Enter Employee number: ");
            int empNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Employee name: ");
            string empName = Console.ReadLine();

            Console.Write("Enter basic salary: ");
            double basic = double.Parse(Console.ReadLine());

            //calculate DA(Dearness Allowance) as 10% of basic
            double da = basic * 0.10;

            //calculate HRA(House Rent Allowance) as 5% of basic
            double hra = basic * 0.05;

            //calculate Net salary(basic+DA+HRA)
            double net = basic + da + hra;

            double tax;

            if (net > 4000)
            {
                tax = net * 0.04;
            }
            else
            {
                tax = net * 0.02;
            }

            //calculate Gross salary(net salary - tax)
            double gross = net - tax;

            Console.WriteLine("\n Employee Details");
            Console.WriteLine("Employee number: " + empNo);
            Console.WriteLine("Employee name: " + empName);
            Console.WriteLine("Basic salary: " + basic);
            Console.WriteLine("DA: " + da);
            Console.WriteLine("HRA: " + hra);
            Console.WriteLine("Net salary: " + net);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Gross salary: " + gross);

        }
    }
}
