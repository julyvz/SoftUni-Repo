using System;

namespace _1TheImitationGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string command;

            while ((command = Console.ReadLine()) != "Decode")
            {
                string[] tokens = command.Split('|');
                switch (tokens[0])
                {
                    case "Move":
                        int n = int.Parse(tokens[1]);
                        string letters = message.Substring(0, n);
                        message = message.Substring(n) + letters;
                        break;
                    case "Insert":
                        message = message.Insert(int.Parse(tokens[1]), tokens[2]);
                        break;
                    case "ChangeAll":
                        message = message.Replace(tokens[1], tokens[2]);
                        break;
                }
            }

            Console.WriteLine($"The decrypted message is: {message}");
        }
    }
}
