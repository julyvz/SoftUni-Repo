using System;
using System.Collections.Generic;

namespace _6SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>(input);

            while (songs.Count > 0)
            {
                string command = Console.ReadLine();
                string[] tokens = command.Split();
                switch (tokens[0])
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string song = command.Substring(4);
                        if (songs.Contains(song))
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        else
                        {
                            songs.Enqueue(song);
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                    default:
                        Console.WriteLine("Wrong input");
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
