//8) Write a program to implement single inheritance from following figure.
//   Accept and display data for one table.

//      +-----------------------------------+
//      |  Class Furniture                  |
//      |                                   |
//      | Data Members : material , price   |
//      +-----------------------------------+
//                      |
//                      ↓
//    +---------------------------------------+
//    | Class Table                           |
//    |                                       |
//    | Data Members: Height , surface_area   |
//    +---------------------------------------+


using System;
using System.Collections.Generic;
using System.Text;

namespace C_programs
{
    class Furniture
    {
        public string Material;
        public double Price;

        public void AcceptData()
        {
            Console.Write("Enter furniture material: ");
            Material = Console.ReadLine();

            Console.Write("Enter furniture price: ");
            Price = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayData()
        {
            Console.WriteLine("Furniture Material: " + Material);
            Console.WriteLine("Furniture Price: " + Price);
        }
    }

    class Table : Furniture
    {
        public double Height;
        public double SurfaceArea;

        public void AcceptTableData()
        {
            AcceptData(); // Accept data for furniture
            Console.Write("Enter table height: ");
            Height = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter table surface area: ");
            SurfaceArea = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayTableData()
        {
            DisplayData(); // Display data for furniture
            Console.WriteLine("Table Height: " + Height);
            Console.WriteLine("Table Surface Area: " + SurfaceArea);
        }
    }

    class SingInherit
    {
        static void Main()
        {
            Table table = new Table();

            Console.WriteLine("Enter details of the table:");
            table.AcceptTableData();

            Console.WriteLine("\nTable details:");
            table.DisplayTableData();
        }
    }
}