using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] toSort = {5, 3, 4, 1, 5, 9, 4, 8, 1};
            // for (int i = 0; i < unsorted.Length; i++)
            // {
                
            // Tuple<int[], int[]> arrayPack = SplitArray(unsorted);
            // arrayPack = SplitArray(arrayPack.Item1);
            //     System.Console.WriteLine("start");

            //  foreach (var item in arrayPack.Item1)
            // {
            //  System.Console.WriteLine(item);   
            // }
            // }
         Console.WriteLine("Before sorting [" + string.Join(",", toSort) + "]");
         MergeSort(toSort);
         Console.WriteLine("After sorting [" + string.Join(",", toSort) + "]");




           
        }

        static int[] SubArray(int[] original, int start, int end)
        {
            int length = end - start;
            int[] result = new int[length];
            Array.Copy(original, start, result, 0, length);
            // Array.Copy(original, top.Length, bottom, 0, top.Length);
            // // destination index of bottom == 0


            // var tuple = new Tuple<int[], int[]>(top, bottom);
            // return tuple;

            return result;

        }

        static void MergeSort(int[] array)
        {
            if (array.Length < 2)
            return;


            int middle = array.Length / 2;
            int[] left = SubArray(array, 0, middle);
            int [] right = SubArray(array, middle, array.Length);

            MergeSort(left);
            MergeSort(right);

            // combine them
            int l = 0;
            int r = 0;
            for (int i = 0; i < array.Length; i++)
            {
                //either l or r will become too big for bounds
                if (l >= left.Length)
                {
                    array[i] = right[r];
                    r++;
                }
                else if (r >= right.Length)
                {
                    array[i] = left[l];
                    l++;
                }
                // if neither are too big then compatr left and right
                else if (left[l] <= right[r])
                {
                    array[i] = left[l];
                    l++;
                }
                else    // if (right[r] <= left[l])
                {
                    array[i] = right[r];
                    r++;
                }
            }
        }


    }
}
