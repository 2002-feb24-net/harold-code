using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int fizzCount = 0;
            int buzzCount= 0;
            int fizzbuzzCount = 0;
            string fizzBuzzOrNothing = "";

            for (int num = 0; num <= 1000; num++)
            {
                fizzBuzzOrNothing = GetFizz(num);
                fizzBuzzOrNothing = GetBuzz(num);
                fizzBuzzOrNothing = GetFizzbuzz(num);

                System.Console.WriteLine(fizzBuzzOrNothing);
                if (fizzBuzzOrNothing == "")
                {   // not divisible by 3 or 5
                    System.Console.WriteLine(num);
                }

                fizzbuzzCount += CountFizzbuzz(num);
                fizzCount += CountFizz(num);
                buzzCount += CountBuzz(num);




            }
            System.Console.WriteLine("Fizz: ");
            System.Console.WriteLine(fizzCount);

            System.Console.WriteLine("Buzz: ");
            System.Console.WriteLine(buzzCount);

            System.Console.WriteLine("Fizzbuzz: ");
            System.Console.WriteLine(fizzbuzzCount);
        }

        static string GetFizz(int num)
        {
            string isFizz;
            if (num % 3 == 0 && !(num % 5 == 0))
            {
                isFizz = "Fizz";
            }
            else
            {
                isFizz = "";
            }
            return isFizz; // Fizz or empty
        }

        static string GetBuzz(int num)
        {
            string isBuzz;
            if (num % 5 == 0 && !(num % 3 == 0))
            {
                isBuzz = "Buzz";
            }
            else
            {
                isBuzz = "";
            }
            return isBuzz; // buzz or empty
        }

        static string GetFizzbuzz (int num)
        {
             string isFizzbuzz;
            if (num % 5 == 0 && (num % 3 == 0))
            {
                isFizzbuzz = "Fizzbuzz";
            }
            else
            {
                isFizzbuzz = "";
            }
            return isFizzbuzz; // buzz or empty

        }


        static void PrintFizzBuzz (string FizzBuzzOrNothing)
        {
            System.Console.WriteLine(FizzBuzzOrNothing);
        }

        static int CountFizz (int num)
        {
            string fizzBuzzOrNothing = GetFizz(num);

            if (fizzBuzzOrNothing == "Fizz")
                return 1;
            else
                return 0;   // do not add
        }

        static int CountBuzz (int num)
        {
            string fizzBuzzOrNothing = GetBuzz(num);

            if (fizzBuzzOrNothing == "Buzz")
                return 1;
            else
                return 0;   // do not add
        }

        static int CountFizzbuzz (int num)
        {
            string fizzBuzzOrNothing = GetFizzbuzz(num);

            if (fizzBuzzOrNothing == "Fizzbuzz")
                return 1;
            else
                return 0;   // do not add
        }

        /*static int CountAll (string FizzBuzzOrNothing, int count)
        {
            if (CountFizzbuzz(FizzBuzzOrNothing, count) == 1)
            {
                return count++
            }
        }*/

    }
}
