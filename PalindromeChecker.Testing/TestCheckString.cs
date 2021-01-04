using System;
using PalindromeChecker.Checker;
using Xunit;

namespace PalindromeChecker.Testing
{
    public class UnitTest1
    {
        [Fact]
        public void Test_CheckPalindrome()
        {
            var testString1 = "level";
            var testString2 = "   level       ";
            var testString3 = "level is high";
            var testString4 = "nEver oR eVeN";

            Assert.True(CheckString.CheckPalindrome(testString1));
            Assert.True(CheckString.CheckPalindrome(testString2));
            Assert.False(CheckString.CheckPalindrome(testString3));
            Assert.True(CheckString.CheckPalindrome(testString4));
        }
    }
}
