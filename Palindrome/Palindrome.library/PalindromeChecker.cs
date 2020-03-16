using System;
using System.Text;

namespace Palindrome.library
{
    public class PalindromeChecker : IIsPalindrome
    {
        public bool IsPalindrome(string palindrome)
        {
            //lower case for comparison
            palindrome = palindrome.ToLower();

            var sb = new StringBuilder();
            foreach (char c in palindrome)
            {
                if (!char.IsPunctuation(c))
                    sb.Append(c);
            }

            string s = sb.ToString();


            string first = s.Substring(0, s.Length / 2);
            char[] arr = s.ToCharArray();

            Array.Reverse(arr);

            string reversed = new string(arr);
            string second = reversed.Substring(0, reversed.Length / 2);

            return first.Equals(second);
        }
    }
}
