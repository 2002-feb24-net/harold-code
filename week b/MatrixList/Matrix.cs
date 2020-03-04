using System;
using System.Collections.Generic;

namespace Matrices
{
    class Matrix
    {
        // store data
        List<int> emptyRow = new List<int>()
        {
            {0}, {0}
        };
        List<List<int>> matrix = new List<List<int>>();


        public Matrix()
        {
            //System.Console.WriteLine("Enter the number of rows for a 2 dimensional matrix");
            // int rows = Console.Read() + 1;
            
            // 2 rows, 2x2 matrix
            matrix.Add(emptyRow);
            matrix.Add(emptyRow);

            for (int i = 0; i < matrix.Count; i++) // 2 dimensional matrix
            {
                
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    System.Console.WriteLine("Enter number for row " + j + " of column " + i);
                    System.Console.WriteLine("");
                    int inputNum = Convert.ToInt32(Console.ReadLine());
                    matrix[i][j] = inputNum;
                }
            }

        }

        public void Output()
        {
            System.Console.Write("[");

            for (int i = 0; i < matrix.Count; i++)
            {
                for (int j = 0; j < matrix[i].Count; j++)
                {
                    System.Console.Write(matrix[i][j]);
                }
            }
            System.Console.Write("]");

        }

        public bool Add(List<List<int>> matrix1, List<List<int>> matrix2)
        {
            if (matrix1.Count == matrix2.Count)
            {
                for (int i = 0; i < matrix1.Count; i++)
                {
                    for (int j = 0; j < matrix2.Count; j++)
                    {
                     matrix[i][j] = matrix1[i][j] + matrix2[i][j];  
                    }
                }
                return true;
            }
            else
                return false;
        }

        public bool Subtract(List<List<int>> matrix1, List<List<int>> matrix2)
        {
            if (matrix1.Count == matrix2.Count)
            {
                for (int i = 0; i < matrix1.Count; i++)
                {
                    for (int j = 0; j < matrix2.Count; j++)
                    {
                     matrix[i][j] = matrix2[i][j] - matrix1[i][j];  
                    }
                }
                return true;
            }
            else
                return false;
        }







    }
}