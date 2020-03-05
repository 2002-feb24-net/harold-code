using System;
using System.Text;

namespace Matrices
{
    class Matrix
    {
        // field(s)
        // how will we store the data of this matrix
        int[,] _matrix;
        int _rows;
        int _cols;

        // methods
        // 1. some way to fill in the data

        // erase the current data and make a new
        // matrix with all zeroes
        public void ClearAndSetDimension(int rows, int cols)
        {
            _matrix = new int[rows, cols];
            _rows = rows;
            _cols = cols;
        }

        public void SetData(int row, int col, int value)
        {
            _matrix[row, col] = value;
        }

        public void Add(Matrix other)
        {

            // print an error if the sizes aren't the same.
            if (_rows != other._rows || _cols != other._cols)
            {
                Console.WriteLine("Incompatible matrix sizes");
                return;
            }
            else
            {
                for (int i = 0; i < _rows; i++)
                {
                    // for each row...
                    for (int j = 0; j < _cols; j++)
                    {
                        // for each column in that row
                        _matrix[i, j] += other._matrix[i, j];
                    }
                }
            }
        }

        public void Display(string name)
        {
            System.Console.WriteLine(name + ": ");
            System.Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            string str = "";

            for (int r = 0; r < _rows; r++)
            {
                str += ("|\t");  // new row

                for (int c = 0; c < _cols; c++)
                {
                    str += Convert.ToString(_matrix[r, c]);
                    str += "\t";
                }
                str += ("|\n");


            }
            str = str.TrimEnd();
            return str;
        }

        public void Subtract(Matrix other)
        {
            // print an error if the sizes aren't the same.
            if (_rows != other._rows || _cols != other._cols)
            {
                Console.WriteLine("Incompatible matrix sizes");
                return;
            }
            else
            {
                for (int r = 0; r < _rows; r++)
                {
                    for (int c = 0; c < _cols; c++)
                    {
                        _matrix[r, c] = _matrix[r, c] - other._matrix[r, c];
                    }
                }
            }
        }

        public void Negate()
        {
            for (int r = 0; r < _rows; r++)
            {
                for (int c = 0; c < _cols; c++)
                {
                    _matrix[r, c] = -(_matrix[r, c]);
                }
            }
        }

        public void Multiply(Matrix other)
        {

        }
        // 2. some common matrix operations
        //    (matrix addition, matrix negation,
        //     multiplication, transpose)

        public void Transpose()
        {
            for (int r = 0; r < _rows; r++)
            {
                for (int c = 0; c < _cols; c++)
                {
                    if (r == 0 && c > 0)
                    {
                        var temp = _matrix[1,0];
                        _matrix[1,0] = _matrix[0, 1];
                        _matrix[0, 1] = temp;


                    }     
                }
            }
        }
    }
}
