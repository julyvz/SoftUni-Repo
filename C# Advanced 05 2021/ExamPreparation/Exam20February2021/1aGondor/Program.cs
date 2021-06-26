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
            bool losing = false;

            Queue<int> plates = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> orcs = new Stack<int>();

            for (int i = 1; i <= waves; i++)
            {
                if (losing)
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
                        plates = new Queue<int>(plates.Prepend(plates.Dequeue() - currOrc));
                        orcs.Pop();
                    }
                    else // ==
                    {
                        plates.Dequeue();
                        orcs.Pop();
                    }

                    if (plates.Count == 0)
                    {
                        losing = true;
                    }
                }
            }

            if (plates.Count > 0)
            {
                Console.WriteLine("The people successfully repulsed the orc's attack.");
                Console.WriteLine($"Plates left: { string.Join(", ", plates)}");                
            }
            else
            {
                Console.WriteLine("The orcs successfully destroyed the Gondor's defense.");
                Console.WriteLine($"Orcs left: { string.Join(", ", orcs)}");
            }
        }
    }
}
