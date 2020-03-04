using System;
using System.Collections.Generic;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Initializing list!");

            // var twoDMatrix = new List<List<int>>();

            // for (int i = 0; i < twoDMatrix.Count; i++)
            // {
            //     for (int j = 0; i < twoDMatrix.Count; j++)
            //     {
            //         System.Console.WriteLine("Enter number for row " + j + " of column " + i);
            //         System.Console.WriteLine("");
            //         twoDMatrix[i].Add(Console.Read());
            //     }
            // }

            System.Console.WriteLine("Initializing Matrix");
            Matrix matrix1 = new Matrix();
            System.Console.WriteLine("Displaying matrix");
            matrix1.Output();


        }
    }
}
