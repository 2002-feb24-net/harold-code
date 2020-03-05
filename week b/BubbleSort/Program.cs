using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[]
            {
                0, 2, 23, 2, 7, 4, 4, 8, 4
            };

            array = BubbleSort(array);
            DisplayArray(array);



        }

        static int[] BubbleSort(int[] array)
        {
            bool swaps = false;
            do
            {
                int timesModified = 0; // reset for each while loop pass
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        int before = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = before;
                        swaps = true;
                        timesModified++;


                    }
                }
                if (timesModified == 0) // if nothing out of order stop while loop
                {
                    swaps = false;
                }
            } while (swaps == true);
            return array;
        }

        static void DisplayArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                System.Console.Write("element " + i + " = " + array[i] + "\t");
                if (i % 4 == 0 && i > 0) //newline to space out long list
                {
                    System.Console.WriteLine();
                }
            }
            System.Console.WriteLine();
        }
    }
}
