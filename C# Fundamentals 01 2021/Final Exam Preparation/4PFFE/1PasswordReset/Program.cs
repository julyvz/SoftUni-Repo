using System;
using System.Collections.Generic;

namespace _1PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Done")
            {
                string[] tokens = command.Split(' ');

                switch (tokens[0])
                {
                    case "TakeOdd":
                        List<char> oddChars = new List<char>();
                        for (int i = 1; i < pass.Length; i += 2)
                        {
                            oddChars.Add(pass[i]);
                        }
                        pass = string.Join("", oddChars);
                        Console.WriteLine(pass);
                        break;
                    case "Cut":
                        pass = pass.Remove(int.Parse(tokens[1]), int.Parse(tokens[2]));
                        Console.WriteLine(pass);
                        break;
                    case "Substitute":
                        if (pass.Contains(tokens[1]))
                        {
                            pass = pass.Replace(tokens[1], tokens[2]);
                            Console.WriteLine(pass);
                        }
                        else
                        {
                            Console.WriteLine("Nothing to replace!");
                        }
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {pass}");
        }
    }
}
