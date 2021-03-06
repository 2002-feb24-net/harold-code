﻿using System;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            // here in the Program class,
            // you can write code to test out your
            // Matrix class

            Matrix matrix = new Matrix();

            // | 0 0 |
            // | 0 0 |
            matrix.ClearAndSetDimension(2, 2);

            matrix.SetData(row: 0, col: 0, value: 2);
            matrix.SetData(row: 0, col: 1, value: 5);
            matrix.SetData(row: 1, col: 0, value: -1);
            matrix.SetData(row: 1, col: 1, value: 0);
            // |  2  5 |
            // | -1  0 |

            Matrix matrix2 = new Matrix();
            matrix2.ClearAndSetDimension(2, 2);
            matrix2.SetData(row: 0, col: 0, value: 1);
            matrix2.SetData(row: 0, col: 1, value: 1);
            matrix2.SetData(row: 1, col: 0, value: 1);
            matrix2.SetData(row: 1, col: 1, value: 1);

            // | 1 1 |
            // | 1 1 |
            matrix.Display("Matrix 1");
            matrix2.Display("Matrix 2");
            matrix.Add(matrix2);
            System.Console.WriteLine("Adding...");

            System.Console.WriteLine("Result: ");
            matrix.Display("Matrix 1");

            //subtract
            System.Console.WriteLine("==========================");
            matrix.Display("Matrix 1");

            matrix.Subtract(matrix2);
            matrix2.Display("Matrix 2");
            System.Console.WriteLine("Subtracting...");

            System.Console.WriteLine("Result: \n" + matrix.ToString());
            // | 3 6 |
            // | 0 1 |


            //negate all
            matrix.Display("Matrix 1");

            System.Console.WriteLine("Negating...");
            matrix.Negate();

            System.Console.WriteLine("Result: ");
            matrix.Display("Matrix 1");

            //transpose
            matrix.Display("Matrix 1");
            System.Console.WriteLine("Transpose...");
            matrix.Transpose();
            matrix.Display("Matrix 1:");
        }
    }
}
