//1)    Create class MyUtils which has static methods to calculate the areas of a 
//      triangle, square and circle (area function overloaded), also to find the maximum and minimum of 2 numbers. 
//      To Store the pai value have a static readonly variable and set the value through static constructor.
//      Use these static functions in an executable class.
//      (Program to demonstrate Static constructors, static methods, read only fields)

using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_3
{
    class MyUtils
    {
        static readonly double pi;

        static MyUtils()
        {
            pi = 3.14159;
        }

        public static void area(double height, double breadth)
        {
            double area = 0.5 * height * breadth;
            Console.WriteLine("Area of the Triangle is: "+area);
        }

        public static void area(int length)
        {
            int area = length * length;
            Console.WriteLine("Area of the Square is: " + area);
        }

        public static void area(double r)
        {
            double area = pi * r * r;
            Console.WriteLine("Area of the Circle is: " + area);
        }

        public static void maxMin(int a, int b)
        {
            if (a > b)
            {
                Console.WriteLine("The maximum value is: "+ a);
                Console.WriteLine("The minimum value is: " + b);
            }
            else if (a < b)
            {
                Console.WriteLine("The maximum value is: " + b);
                Console.WriteLine("The minimum value is: " + a);
            }
            else
            {
                Console.WriteLine("Both the values " + a+" and "+b+" are equal");
            }
        }
    }

    class Abc
    {
        static void Main(String[] args)
        {
            MyUtils myUtils = new MyUtils();
            while (true)
            {
                Console.WriteLine("\n1. Area of the Triangle");
                Console.WriteLine("2. Area of the Square");
                Console.WriteLine("3. Area of the Circle");
                Console.WriteLine("4. Maximum/ MInimum of 2 numbers");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Enter your choice");

                int ch = int.Parse(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Console.Write("Enter the height of the Triangle: ");
                        double height = double.Parse(Console.ReadLine());
                        Console.Write("Enter the breadth of the Triangle: ");
                        double breadth = double.Parse(Console.ReadLine());

                        MyUtils.area(height, breadth);
                        break;

                    case 2:
                        Console.Write("Enter the length of the Square: ");
                        int length = int.Parse(Console.ReadLine());

                        MyUtils.area(length);
                        break;

                    case 3:
                        Console.Write("Enter the radius of the Circle: ");
                        double radius = double.Parse(Console.ReadLine());

                        MyUtils.area(radius);
                        break;

                    case 4:
                        Console.WriteLine("Enter two numbers to Compare: ");
                        Console.Write("1st number: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("2nd number: ");
                        int b = int.Parse(Console.ReadLine());

                        MyUtils.maxMin(a, b);
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Enter a valid choice");
                        break;
                }
            }
        }
    }
}
