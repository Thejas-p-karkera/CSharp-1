//1.Write a program to generate the temperature conversion

using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_Ass__1
{
    class TempConv
    {
        static void Main(string[] args)
        {
            TempConv t1 = new TempConv();

            Console.WriteLine("Enter temperature to convert");
            string temp = Console.ReadLine();

            double temp1;

            if (!double.TryParse(temp, out temp1))
            {
                Console.WriteLine("Enter a valid temperature");
                return;
            }

            Console.WriteLine("1. Convert Celcuis to fahrenheit.");
            Console.WriteLine("2. Convert fahrenheit to Celcuis.");
            Console.WriteLine("3. Exit.");
            Console.WriteLine("Enter your choice: ");

            string input = Console.ReadLine();
            int choice;

            if (!int.TryParse(input, out choice))
            {
                Console.WriteLine("Enter a valid number");
                return;
            }

            switch (choice)
            {
                case 1:
                    t1.celToFar(temp1);
                    Console.ReadLine();
                    break;

                case 2:
                    t1.farToCel(temp1);
                    Console.ReadLine();
                    break;

                case 3:
                    return;

                default:
                    Console.WriteLine("Enter a valid choice");
                    break;
            }
        }

        void celToFar(double temp1)
        {
            double far = (temp1 * 9 / 5) + 32;
            Console.WriteLine("Fahreinheit value of " + temp1 + " is: " + far);
        }

        void farToCel(double temp1)
        {
            double cel = (temp1 - 32) * 5 / 9;
            Console.WriteLine("Celcuis value of " + temp1 + " is: " + cel);
        }
    }
}