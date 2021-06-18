using System;

namespace _2a2SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            char[] temp = Console.ReadLine().ToCharArray();
            int m = temp.Length;

            char[,] tower = new char[n, m];
            int rowM = 0;
            int colM = 0;
            bool hasReachThePeach = false;

            for (int j = 0; j < m; j++)
            {
                tower[0, j] = temp[j];
                if (tower[0, j] == 'M')
                {
                    rowM = 0;
                    colM = j;
                }
            }

            // initialize the tower
            for (int i = 1; i < n; i++)
            {
                temp = Console.ReadLine().ToCharArray();
                for (int j = 0; j < m; j++)
                {
                    tower[i, j] = temp[j];
                    if (tower[i, j] == 'M')
                    {
                        rowM = i;
                        colM = j;
                    }
                }
            }

            while (lives > 0)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string direction = tokens[0];
                int rowB = int.Parse(tokens[1]);
                int colB = int.Parse(tokens[2]);
                tower[rowB, colB] = 'B';
                lives--;

                tower[rowM, colM] = '-';

                switch (direction)
                {
                    case "W":
                        rowM = rowM == 0 ? 0 : rowM - 1;
                        break;

                    case "S":
                        rowM = rowM == n - 1 ? n - 1 : rowM + 1;
                        break;

                    case "A":
                        colM = colM == 0 ? 0 : colM - 1;
                        break;

                    case "D":
                        colM = colM == m - 1 ? m - 1 : colM + 1;
                        break;
                }

                if (tower[rowM, colM] == 'B')
                {
                    lives -= 2;
                }
                else if (tower[rowM, colM] == 'P')
                {
                    hasReachThePeach = true;
                    tower[rowM, colM] = '-';
                    break;
                }

                if (lives <= 0)
                {
                    tower[rowM, colM] = 'X';
                    break;
                }

                tower[rowM, colM] = 'M';
            }

            if (hasReachThePeach)
            {
                Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
            }
            else
            {
                Console.WriteLine($"Mario died at {rowM};{colM}.");
            }


            // print the tower
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(tower[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
