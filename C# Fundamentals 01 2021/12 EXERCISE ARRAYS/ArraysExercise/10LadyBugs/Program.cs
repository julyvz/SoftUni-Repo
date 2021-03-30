using System;
using System.Linq;

namespace _10LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[] initialState = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            int[] field = new int[size];

            foreach (var bug in initialState)
            {
                if (bug >= 0 && bug <size)
                {
                    field[bug] = 1;
                }
            }

            while (command != "end")
            {
                string[] com = command.Split();
                int index = int.Parse(com[0]);
                string direction = com[1];
                int mod = 0;
                if (direction == "right") mod = 1;
                else mod = -1;
                int flyLength = int.Parse(com[2]);

                if (index >= 0 && index < size && field[index] == 1)
                {
                    field[index] = 0;
                    index +=flyLength * (mod);
                    while (index >= 0 && index < size)
                    {
                        if (field[index] == 0)
                        {
                            field[index] = 1;
                            break;
                        }
                        index += flyLength * (mod);
                    }
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(String.Join(' ', field));
        }
    }
}
