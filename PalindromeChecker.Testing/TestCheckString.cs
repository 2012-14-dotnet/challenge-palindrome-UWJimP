using System;
using PalindromeChecker.Checker;
using Xunit;

namespace PalindromeChecker.Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test_CheckPalindromeTrue()
        {
            var testString1 = "level";
            var testString2 = "   level       ";
            var testString3 = "nEver oR eVeN";

            Assert.True(CheckString.CheckPalindrome(testString1));
            Assert.True(CheckString.CheckPalindrome(testString2));
            Assert.True(CheckString.CheckPalindrome(testString3));
        }
        [Fact]
        public void Test_CheckPalindromeFalse()
        {
            var testString1 = "leveel"; 
            var testString2 = "  never ror even";
            var testString3 = "level is    high";

            Assert.False(CheckString.CheckPalindrome(testString1));
            Assert.False(CheckString.CheckPalindrome(testString2));
            Assert.False(CheckString.CheckPalindrome(testString3));
        }
    }
}
