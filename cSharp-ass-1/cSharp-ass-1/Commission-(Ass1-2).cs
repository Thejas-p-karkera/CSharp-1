using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_1
{
    class Commission
    {
        static void Main()
        {
            Console.Write("Enter the amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            double Commission = 0;
            if (amount > 20000)
            {
                Commission = amount * 0.03;
            }

            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("Commission: " + Commission);
        }
    }
}
