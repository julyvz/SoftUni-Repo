using System;

namespace _4SymbolInMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                char[] arr = Console.ReadLine().ToCharArray();
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = arr[col];                    
                }
            }

            char theSymbol = Console.ReadLine().ToCharArray()[0];

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == theSymbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }                    
                }                
            }

            Console.WriteLine($"{theSymbol} does not occur in the matrix");
        }
    }
}
