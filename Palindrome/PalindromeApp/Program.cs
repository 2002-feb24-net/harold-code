using Palindrome.library;
using System;

namespace PalindromeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PalindromeChecker palindromeCheckSpecific = new PalindromeChecker();
            IIsPalindrome palindromeCheckGeneral = palindromeCheckSpecific; // upcasting

            Console.WriteLine("Enter a string to check if it's a palindrome");
            string input = Console.ReadLine();

            bool isPalindrome = palindromeCheckGeneral.IsPalindrome(input);

            if (isPalindrome == true)
            {
                Console.WriteLine($"{input} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{input} is NOT a palindrome");
            }
        }

        /* object ref error if called from main
         * void isPalindromeOutput(string input, IIsPalindrome palindromeChecker)
        {
            bool isPalindrome = palindromeChecker.IsPalindrome(input);

            if (isPalindrome == true)
            {
                Console.WriteLine($"{input} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{input} is NOT a palindrome");
            }

        }*/
    }
    }

