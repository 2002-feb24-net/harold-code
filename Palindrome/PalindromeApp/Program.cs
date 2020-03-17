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

            PalindromeCheckOutput(input, palindromeCheckGeneral);
        }

         static void PalindromeCheckOutput(string input, IIsPalindrome generalIsPalindrome)
        {
            bool isPalindrome = generalIsPalindrome.IsPalindrome(input);

            if (isPalindrome == true)
            {
                Console.WriteLine($"{input} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{input} is NOT a palindrome");
            }

        }
    }
    }

