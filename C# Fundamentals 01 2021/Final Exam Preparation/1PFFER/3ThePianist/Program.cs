using System;
using System.Linq;
using System.Collections.Generic;

namespace _3ThePianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string[]> favorites = new Dictionary<string, string[]>();
            string input;

            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();
                string[] tokens = input.Split('|');
                string piece = tokens[0];
                favorites.Add(piece, new[] { tokens[1], tokens[2] });
            }

            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] tokens = input.Split('|');
                string piece = tokens[1];
                switch (tokens[0])
                {
                    case "Add":
                        if (favorites.ContainsKey(piece))
                        {
                            Console.WriteLine($"{piece} is already in the collection!");
                        }
                        else
                        {
                            favorites.Add(piece, new[] { tokens[2], tokens[3] });
                            Console.WriteLine($"{piece} by {tokens[2]} in {tokens[3]} added to the collection!");
                        }
                        break;
                    case "Remove":
                        if (favorites.ContainsKey(piece))
                        {
                            favorites.Remove(piece);
                            Console.WriteLine($"Successfully removed {piece}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                    case "ChangeKey":
                        if (favorites.ContainsKey(piece))
                        {
                            favorites[piece][1] = tokens[2];
                            Console.WriteLine($"Changed the key of {piece} to {tokens[2]}!");
                        }
                        else
                        {
                            Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                        }
                        break;
                }
            }
            foreach (var piece in favorites.OrderBy(x => x.Key).ThenBy(x => x.Value[0]))
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value[0]}, Key: {piece.Value[1]}");
            }
        }
    }
}
