using System;

namespace Palindrome.library
{
    public class PalindromeChecker : IIsPalindrome
    {
        public bool IsPalindrome(string palindrome)
        {
            //lower case for comparison
            palindrome.ToLower();

            string first = palindrome.Substring(0, palindrome.Length / 2);
            char[] arr = palindrome.ToCharArray();

            Array.Reverse(arr);

            string reversed = new string(arr);
            string second = reversed.Substring(0, reversed.Length / 2);

            return first.Equals(second);
        }
    }
}
