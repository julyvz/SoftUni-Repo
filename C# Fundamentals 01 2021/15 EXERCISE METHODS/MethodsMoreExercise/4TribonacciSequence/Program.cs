using System;

namespace _4TribonacciSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            PrintArr(n);
        }

        private static void PrintArr(int n)
        {
            if (n == 1)
            {
                Console.WriteLine(1);
                return;
            }
            else if (n == 2)
            {
                Console.WriteLine("1 1");
                return;
            }
            else if (n == 3)
            {
                Console.WriteLine("1 1 2");
                return;
            }
            else
            {
                int[] arr = new int[n];
                arr[0] = 1;
                arr[1] = 1;
                arr[2] = 2;

                for (int i = 3; i < n; i++)
                {
                    arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];                    
                }
                Console.WriteLine(String.Join(' ', arr));
            }
        }
    }
}
