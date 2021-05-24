using System;
using System.Collections.Generic;
using System.Linq;

namespace _11KeyRevolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int bulletPrice = int.Parse(Console.ReadLine());
            int barrelSize = int.Parse(Console.ReadLine());
            int[] bullets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] locks = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int prise = int.Parse(Console.ReadLine());

            Stack<int> theGun = new Stack<int>(bullets);
            Queue<int> theSafe = new Queue<int>(locks);
            int currentBarrelSize = barrelSize;
            int bulletsFired = 0;

            while (theGun.Count > 0 && theSafe.Count > 0)
            {
                int currentBullet = theGun.Pop();
                bulletsFired++;
                currentBarrelSize--;
                if (currentBullet <= theSafe.Peek())
                {
                    Console.WriteLine("Bang!");
                    theSafe.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }
                if (currentBarrelSize == 0 && theGun.Count > 0)
                {
                    Console.WriteLine("Reloading!");
                    currentBarrelSize = barrelSize;
                }
            }

            if (theSafe.Count == 0)
            {
                Console.WriteLine($"{theGun.Count} bullets left. Earned ${prise - bulletsFired * bulletPrice}");
            }
            else
            {
                Console.WriteLine($"Couldn't get through. Locks left: {theSafe.Count}");
            }
        }
    }
}
