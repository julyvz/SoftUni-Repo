using System;
using System.Linq;

namespace _1SecretChat
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();

            string input = Console.ReadLine();

            while (input != "Reveal")
            {
                string[] tokens = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "InsertSpace":
                        message = message.Insert(int.Parse(tokens[1]), " ");
                        Console.WriteLine(message);
                        break;

                    case "Reverse":
                        if (message.Contains(tokens[1]))
                        {
                            int idx = message.IndexOf(tokens[1]);
                            message = message.Remove(idx, tokens[1].Length);
                            string reversed = new string(tokens[1].ToCharArray().Reverse().ToArray());
                            message = message + reversed;
                            Console.WriteLine(message);

                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;

                    case "ChangeAll":
                        while (message.Contains(tokens[1]))
                        {
                            message = message.Replace(tokens[1], tokens[2]);
                        }
                        Console.WriteLine(message);
                        break;
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"You have a new text message: {message}");
        }
    }
}
