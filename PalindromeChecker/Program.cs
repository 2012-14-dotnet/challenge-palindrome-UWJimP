using System;
using PalindromeChecker.Checker;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            UserView();
        }

        private static void UserView()
        {
            Console.WriteLine("Welcome to the Palindrome Checker: ");
            GetUserInput();
            Console.WriteLine("Thank you, have a nice day");
        }
        private static void GetUserInput()
        {
            bool confirmationInput = true;
            while(confirmationInput)
            {
                Console.WriteLine("Enter a word or sentence to check: ");
                var userInput = Console.ReadLine();
                bool result = CheckString.CheckPalindrome(userInput);
                if(result)
                {
                    Console.WriteLine($"{userInput} is a Palindrome.");
                }
                else
                {
                    Console.WriteLine($"{userInput} is NOT a Palindrome.");
                }
                confirmationInput = ConfirmationInput();
            }
        }
        private static bool ConfirmationInput()
        {
            while(true) 
            {
                Console.WriteLine($"Would you like to input another sentence?: y/n");
                var input = Console.ReadLine();
                if(input.ToLower().Equals("y"))
                {
                    return true;
                }
                else if(input.ToLower().Equals("n"))
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}
