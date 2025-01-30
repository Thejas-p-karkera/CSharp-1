using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_4
{

    class Matrix
    {
        private int[,] data;
        private int rows, cols;

        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            data = new int[rows, cols];
        }

        public int this[int i, int j]
        {
            get { return data[i, j]; }
            set { data[i, j] = value; }
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.rows, a.cols);
            for (int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < a.cols; j++)
                {
                    result[i, j] = a[i, j] + b[i, j];
                }
            }        
            return result;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            Matrix result = new Matrix(a.rows, a.cols);
            for (int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < a.cols; j++)
                {
                    result[i, j] = a[i, j] - b[i, j];
                }
            }     
            return result;
        }

        public static Matrix operator ++(Matrix a)
        {
            for (int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < a.cols; j++)
                {
                    a[i, j]++;
                }
            }
            return a;
        }

        public static Matrix operator --(Matrix a)
        {
            for (int i = 0; i < a.rows; i++)
            {
                for (int j = 0; j < a.cols; j++)
                {
                    a[i, j]--;
                }
            }   
            return a;
        }

        public void Display()
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(data[i, j] + " ");
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Matrix mat1 = new Matrix(2, 2);
            Matrix mat2 = new Matrix(2, 2);

            mat1[0, 0] = 1; mat1[0, 1] = 2;
            mat1[1, 0] = 3; mat1[1, 1] = 4;

            mat2[0, 0] = 5; mat2[0, 1] = 6;
            mat2[1, 0] = 7; mat2[1, 1] = 8;

            Matrix matAdd = mat1 + mat2;
            Matrix matSub = mat1 - mat2;

            Console.WriteLine("Matrix Addition:");
            matAdd.Display();

            Console.WriteLine("Matrix Subtraction:");
            matSub.Display();

            mat1++;
            Console.WriteLine("Matrix 1 after Increment:");
            mat1.Display();

            mat2--;
            Console.WriteLine("Matrix 2 after Decrement:");
            mat2.Display();
        }
    }
}