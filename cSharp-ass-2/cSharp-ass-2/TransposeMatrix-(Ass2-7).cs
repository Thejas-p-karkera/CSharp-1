using System;
using System.Collections.Generic;
using System.Text;

namespace cSharp_ass_2
{
    class TransposeMatrix
    {
        static void Main(String[] args)
        {
            Console.Write("Enter the value for N: ");
            int n;
            if(!int.TryParse(Console.ReadLine(),out n))
            {
                Console.WriteLine("Enter a valid number");
            }

            Console.Write("Enter the value for M: ");
            int m;
            if(!int.TryParse(Console.ReadLine(),out m))
            {
                Console.WriteLine("Enter a valid number");
            }

            int[,] arr1 = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Enter " + j + "th element for " + i + "th row: ");
                    arr1[i,j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("The original Matrix is: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(arr1[i,j]+" ");
                }
                Console.WriteLine();
            }

            //Transpose
            int[,] arr2 = new int[m,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr2[j,i] = arr1[i,j];
                }
            }

            Console.WriteLine("The Transpose of Matrix is: ");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr2[i, j] + " ");
                }
                Console.WriteLine();
            }

            if (symmetriCheck(arr1, arr2, n, m))
            {
                Console.WriteLine("The matrix is symmetric");
            }
            else
            {
                Console.WriteLine("The matrix is not symmetric");
            }
        }

        static bool symmetriCheck(int[,] arr1, int[,] arr2, int n, int m)
        {
            if (n == m)       // checking if the no. of row's and column's are equal
            {
                for (int i = 0; i < n; i++)         //to check if the diagonal elements are equal
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (arr1[i, j] != arr2[i, j])
                        {
                            return false;
                        }
                    }
                } 
            }
            return true;
        }
    }
}
