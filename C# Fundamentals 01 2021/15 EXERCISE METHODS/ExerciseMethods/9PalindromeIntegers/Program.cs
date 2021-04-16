using System;

namespace _9PalindromeIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                if (NumIsPalindrome(input))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
                
                input = Console.ReadLine();
            }            
        }

        private static bool NumIsPalindrome(string num)
        {
            bool isPalindrome = true;
            for (int i = 0; i < num.Length; i++)
            {
                if (num[i] != num[num.Length - 1 - i])
                {
                    
                    isPalindrome = false;
                    break;
                }
            }
            return isPalindrome;
        }
    }
}
