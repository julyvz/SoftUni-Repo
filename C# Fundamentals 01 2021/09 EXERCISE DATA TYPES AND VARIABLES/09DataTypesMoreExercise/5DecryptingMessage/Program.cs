using System;

namespace _5DecryptingMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            char[] output = new char[n];
            for (int i = 0; i < n; i++)
            {
                output[i] = char.Parse(Console.ReadLine());
                output[i] = (char)(output[i] + key);
            }                
            
            Console.WriteLine(output);
        }
    }
}
