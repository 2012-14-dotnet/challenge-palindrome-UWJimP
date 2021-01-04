using System;

namespace PalindromeChecker.Checker
{
    public class Checker
    {
        public static bool CheckPalindrome(string sentence)
        {
            var modifyString = sentence.Trim().ToLower();
            var cleanString = string.Concat(modifyString.Where(c => !char.IsWhiteSpace(c)));
            var charArray = cleanString.ToCharArray();
            for(int index = 0; index < charArray.Count() / 2; index++)
            {
                if(charArray[index] != charArray[charArray.Count() - (index + 1)])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
