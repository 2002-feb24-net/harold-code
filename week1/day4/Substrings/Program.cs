using System;

namespace Substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            GetSubstring();
        }

        static void Substring(string str, int num)
        {
            // for loop
            for (int i = 0; i < (str.Length - num + 1); i++)    // loop stops one too early without + 1 on num
                                                                // (index starts at 0, not 1)
            {
                Console.WriteLine(str.Substring(i, num));

            }
        }

        static void GetSubstring()
        {
            System.Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            System.Console.WriteLine("Enter a whole number:");
            int num = Convert.ToInt32(Console.ReadLine());

            Substring(str, num);
        }


    }
}
