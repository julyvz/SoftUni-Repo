using System;

namespace _4PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool a = CheckLength(password);
            bool b = CheckSymbols(password);
            bool c = CheckForDigits(password);
            if (a && b && c)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CheckLength(string str)
        {
            if (str.Length < 6 || str.Length > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                return false;
            }
            return true;
        }

        static bool CheckSymbols(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!((str[i] >= 48 && str[i] <= 57) || (str[i] >= 65 && str[i] <= 90) || (str[i] >= 97 && str[i] <= 122)))
                {
                    Console.WriteLine("Password must consist only of letters and digits");
                    return false;                    
                }
            }
                return true;
        }

        static bool CheckForDigits(string str)
        {
            int numOfDigits = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 48 && str[i] <= 57)
                {
                    numOfDigits++;
                }
            }
            if (numOfDigits < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                return false;
            }
            return true;
        }
    }
}
