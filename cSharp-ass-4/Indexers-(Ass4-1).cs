//1)	Overload +, and - to perform addition and subtraction of 2 matrices and 
//    also overload unary operators ++ and -- to increment and decrement all the values of a matrix by 1.
//    (use indexers)

using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_4
{
    class Matrix
    {
        private int[,] matrix;

        // Constructor to initialize the matrix
        public Matrix(int rows, int cols)
        {
            matrix = new int[rows, cols];
        }

        // Indexer to access matrix elements
        public int this[int row, int col]
        {
            get { return matrix[row, col]; }
            set { matrix[row, col] = value; }
        }

        // Overload + operator for matrix addition
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix(2, 2);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return result;
        }

        // Overload - operator for matrix subtraction
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix(2, 2);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = m1[i, j] - m2[i, j];
                }
            }
            return result;
        }

        // Overload ++ operator (increment all values by 1)
        public static Matrix operator ++(Matrix m)
        {
            Matrix result = new Matrix(2, 2);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = m[i, j] + 1;
                }
            }
            return result;
        }

        // Overload -- operator (decrement all values by 1)
        public static Matrix operator --(Matrix m)
        {
            Matrix result = new Matrix(2, 2);
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    result[i, j] = m[i, j] - 1;
                }
            }
            return result;
        }

        // Method to display the matrix
        public void Display()
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }

    class Indexers
    {
        static void Main()
        {
            // Create two matrices
            Matrix m1 = new Matrix(2, 2);
            m1[0, 0] = 1;
            m1[0, 1] = 2;
            m1[1, 0] = 3;
            m1[1, 1] = 4;

            Matrix m2 = new Matrix(2, 2);
            m2[0, 0] = 5;
            m2[0, 1] = 6;
            m2[1, 0] = 7;
            m2[1, 1] = 8;

            // Display matrices
            Console.WriteLine("Matrix 1:");
            m1.Display();

            Console.WriteLine("\nMatrix 2:");
            m2.Display();

            // Matrix Addition
            Matrix resultAdd = m1 + m2;
            Console.WriteLine("\nMatrix 1 + Matrix 2:");
            resultAdd.Display();

            // Matrix Subtraction
            Matrix resultSub = m1 - m2;
            Console.WriteLine("\nMatrix 1 - Matrix 2:");
            resultSub.Display();

            // Increment Matrix
            Matrix resultInc = ++m1;
            Console.WriteLine("\nMatrix 1 after incrementing each value by 1:");
            resultInc.Display();

            // Decrement Matrix
            Matrix resultDec = --m1;
            Console.WriteLine("\nMatrix 1 after decrementing each value by 1:");
            resultDec.Display();
        }
    }
}


//------------------------------------------------------------------------------------------

//class Box
//{
//    private int[] values;

//    // Constructor to initialize the box with a fixed size
//    public Box(int size)
//    {
//        values = new int[size];
//    }

//    // Indexer to access elements like an array
//    public int this[int index]
//    {
//        get { return values[index]; }
//        set { values[index] = value; }
//    }

//    // Overloading + operator to add values of two boxes
//    public static Box operator +(Box b1, Box b2)
//    {
//        int size = Math.Min(b1.values.Length, b2.values.Length);
//        Box result = new Box(size);

//        for (int i = 0; i < size; i++)
//        {
//            result[i] = b1[i] + b2[i];
//        }

//        return result;
//    }

//    // Overloading - operator to subtract values of two boxes
//    public static Box operator -(Box b1, Box b2)
//    {
//        int size = Math.Min(b1.values.Length, b2.values.Length);
//        Box result = new Box(size);

//        for (int i = 0; i < size; i++)
//        {
//            result[i] = b1[i] - b2[i];
//        }

//        return result;
//    }

//    // Method to display the values in the box
//    public void Display()
//    {
//        foreach (var val in values)
//        {
//            Console.Write(val + " ");
//        }
//        Console.WriteLine();
//    }
//}

//class Indexers
//{
//    static void Main()
//    {
//        // Create two boxes
//        Box box1 = new Box(3);
//        box1[0] = 1;
//        box1[1] = 2;
//        box1[2] = 3;

//        Box box2 = new Box(3);
//        box2[0] = 4;
//        box2[1] = 5;
//        box2[2] = 6;

//        // Display original boxes
//        Console.WriteLine("Box 1:");
//        box1.Display();

//        Console.WriteLine("Box 2:");
//        box2.Display();

//        // Add the two boxes using overloaded + operator
//        Box resultAdd = box1 + box2;
//        Console.WriteLine("Box 1 + Box 2:");
//        resultAdd.Display();

//        // Subtract the two boxes using overloaded - operator
//        Box resultSub = box1 - box2;
//        Console.WriteLine("Box 1 - Box 2:");
//        resultSub.Display();
//    }
//}