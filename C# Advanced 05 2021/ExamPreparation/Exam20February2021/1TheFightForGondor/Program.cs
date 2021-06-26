using System;
using System.Collections.Generic;
using System.Linq;

namespace _1TheFightForGondor
{
    class Program
    {
        static void Main(string[] args)
        {
            int waves = int.Parse(Console.ReadLine());
            bool loose = false;

            Queue<int> plates = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> orcs = new Stack<int>();

            for (int i = 1; i <= waves; i++)
            {
                if (loose)
                {
                    break;
                }

                orcs = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

                if (i % 3 == 0)
                {
                    plates.Enqueue(int.Parse(Console.ReadLine()));
                }

                while (plates.Count > 0 && orcs.Count > 0)
                {
                    int currPlate = plates.Peek();
                    int currOrc = orcs.Peek();
                    if (currOrc > currPlate)
                    {
                        orcs.Push(orcs.Pop() - currPlate);
                        plates.Dequeue();
                    }
                    else if (currOrc < currPlate)
                    {
                        currPlate -= currOrc;
                        plates.Dequeue();
                        plates.Enqueue(currPlate);
                        for (int j = 0; j < plates.Count - 1; j++)
                        {
                            plates.Enqueue(plates.Dequeue());
                        }
                        orcs.Pop();
                    }
                    else // ==
                    {
                        plates.Dequeue();
                        orcs.Pop();
                    }
                    if (plates.Count == 0)
                    {
                        loose = true;
                    }
                }
            }

            if (plates.Count > 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                if (plates.Count > 0)
                {
                    Console.WriteLine($"Plates left: { string.Join(", ", plates)}");
                }
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                if (orcs.Count > 0)
                {
                    Console.WriteLine($"Orcs left: { string.Join(", ", orcs)}");
                }
            }
        }
    }
}
