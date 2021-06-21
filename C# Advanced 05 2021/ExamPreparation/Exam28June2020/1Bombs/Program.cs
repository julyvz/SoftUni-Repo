using System;
using System.Collections.Generic;
using System.Linq;

namespace _1Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> effects = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Stack<int> casings = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));

            int daturaCount = 0;
            int cherryCount = 0;
            int smokeCount = 0;
            bool success = false;

            while (effects.Count > 0 && casings.Count > 0)
            {
                int currEffect = effects.Peek();
                int currCasing = casings.Peek();

                int sum = currEffect + currCasing;
                switch (sum)
                {
                    case 40:
                        daturaCount++;
                        effects.Dequeue();
                        casings.Pop();
                        break;

                    case 60:
                        cherryCount++;
                        effects.Dequeue();
                        casings.Pop();
                        break;

                    case 120:
                        smokeCount++;
                        effects.Dequeue();
                        casings.Pop();
                        break;

                    default:
                        casings.Push(casings.Pop() - 5);
                        break;
                }

                if (daturaCount >= 3 && cherryCount >= 3 && smokeCount >= 3)
                {
                    success = true;
                    break;
                }
            }

            if (success)
            {
                Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
            }
            else
            {
                Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            }

            if (effects.Count == 0)
            {
                Console.WriteLine("Bomb Effects: empty");
            }
            else
            {
                Console.WriteLine("Bomb Effects: " + string.Join(", ", effects));
            }

            if (casings.Count == 0)
            {
                Console.WriteLine("Bomb Casings: empty");
            }
            else
            {
                Console.WriteLine("Bomb Casings: " + string.Join(", ", casings));
            }
            Console.WriteLine($"Cherry Bombs: {cherryCount}");
            Console.WriteLine($"Datura Bombs: {daturaCount}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeCount}");
        }
    }
}
