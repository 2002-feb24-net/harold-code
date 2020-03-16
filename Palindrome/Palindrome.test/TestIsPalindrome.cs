using Palindrome.library;
using System;
using System.Collections.Generic;
using Xunit;

namespace Palindrome.test
{
    public class TestIsPalindrome
    {
        PalindromeChecker palindromeCheckSpecific = new PalindromeChecker();

        // IIsPalindrome palindromeCheckGeneral = palindromeCheckSpecific; // upcasting

        readonly List<string> _truePalindromes = new List<String>
        {
            "nurses run", "racecaR", "1221", "never odd, or even."
        };

        readonly List<string> _falsePalindromes = new List<String>
        {
            "one two one", "123abccba123"
        };

        [Fact]
        private void EmptyStringTest()
        {
            string empty = "";
           Assert.False(palindromeCheckSpecific.IsPalindrome(empty));
        }

        [Fact]
        private void NotPalindrome()
        {
            foreach (var item in _falsePalindromes)
            {
                Assert.False(palindromeCheckSpecific.IsPalindrome(item));
            }
    

        }
        [Fact]
        private void YesPalindrome()
        {
            foreach (var item in _truePalindromes)
            {
                Assert.True(palindromeCheckSpecific.IsPalindrome(item));
            }
        }
    }
}
