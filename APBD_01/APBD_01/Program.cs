// See https://aka.ms/new-console-template for more information

using System;

namespace PalindromeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word to check if it's a palindrome: ");
            string input = Console.ReadLine();
            
        }

        
        static bool IsPalindrome(string word)
        {
            string processedWord = word.Replace(" ", "").ToLower();
            int length = processedWord.Length;
            
            for (int i = 0; i < length / 2; i++)
            {
                if (processedWord[i] != processedWord[length - i - 1])
                {
                    return false;
                }
            }
            
            return true;
        }
        
    }
}
