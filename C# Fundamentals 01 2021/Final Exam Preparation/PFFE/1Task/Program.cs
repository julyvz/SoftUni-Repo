using System;

namespace _1Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Complete")
            {
                string[] tokens = command.Split(' ');

                switch (tokens[0])
                {
                    case "Make":
                        if (tokens[1] == "Upper")
                        {
                            input = input.ToUpper();
                        }
                        else // Lower
                        {
                            input = input.ToLower();
                        }
                        Console.WriteLine(input);
                        break;

                    case "GetDomain":
                        int count = int.Parse(tokens[1]);
                        string domain = input.Substring(input.Length - count);
                        Console.WriteLine(domain);
                        break;

                    case "GetUsername":
                        int idx = input.IndexOf('@');
                        if (idx == -1)
                        {
                            Console.WriteLine($"The email {input} doesn't contain the @ symbol.");
                        }
                        else
                        {
                            string userName = input.Substring(0, idx);
                            Console.WriteLine(userName);
                        }
                        break;

                    case "Replace":
                        input = input.Replace(tokens[1], "-");
                        Console.WriteLine(input);
                        break;

                    case "Encrypt":
                        foreach (var symbol in input)
                        {
                            int a = 0;
                            Console.Write($"{a + symbol} ");
                        }
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
