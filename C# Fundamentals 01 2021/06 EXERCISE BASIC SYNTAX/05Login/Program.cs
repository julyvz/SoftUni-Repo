using System;

namespace _05Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            string password = "";
            int attempt = 1;
            bool correctpassword = false;
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = username.Length - 1; i >= 0; i--)
            {
                sb.Append(username[i]);
            }
            string reverseUsername = sb.ToString();
            while (attempt <= 4)
            {
                password = Console.ReadLine();
                if (password == reverseUsername)
                {
                    correctpassword = true;
                    break;
                }
                else
                {
                    if (attempt == 4)
                    {
                        break;
                    }
                }
                Console.WriteLine("Incorrect password. Try again.");
                attempt++;
            }
            if (correctpassword)
            {
                Console.WriteLine($"User {username} logged in.");
            }
            else
            {
                Console.WriteLine($"User {username} blocked!");
            }
        }
    }
}
