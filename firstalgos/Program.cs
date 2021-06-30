using System;

namespace firstalgos
{

    // Given a string, write a method to check if it is palindrome or not. A string is said to be palindrome if the 
    // reverse of the string is the same as string. For example, “radar” 
    // is a palindrome, but “radix” is not a palindrome.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to check my string for palindromeness!!!!!");
            Console.WriteLine("Please enter your string and I will test it: ");
            var _testThis = Console.ReadLine();

            // create a palindrome object and call testforpalindrome
            IPalindrome _palindrome = new Palindrome();
            var _result = _palindrome.TestForPalindromeless(_testThis);

            if (_result)
            {
                Console.WriteLine($"{_testThis} is a palindrome");
            }
            else
            {
                Console.WriteLine($"{_testThis} is not a palindrome");
            }
        }
    }
}
