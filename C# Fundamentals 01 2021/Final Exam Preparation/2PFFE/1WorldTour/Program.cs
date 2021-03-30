using System;

namespace _1WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();

            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] tokens = command.Split(':', StringSplitOptions.RemoveEmptyEntries);

                switch (tokens[0])
                {
                    case "Add Stop":
                        int idx = int.Parse(tokens[1]);
                        if (idx >= 0 && idx < stops.Length)
                        {
                        stops = stops.Insert(idx, tokens[2]);
                        }
                        break;

                    case "Remove Stop":
                        idx = int.Parse(tokens[1]);
                        int endIdx = int.Parse(tokens[2]);
                        if (idx >= 0 && idx < stops.Length && endIdx >= 0 && endIdx < stops.Length)
                        {
                            stops = stops.Remove(idx, endIdx - idx + 1);
                        }
                        break;

                    case "Switch":                        
                        stops = stops.Replace(tokens[1], tokens[2]);                        
                        break;
                }

                Console.WriteLine(stops);
                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
