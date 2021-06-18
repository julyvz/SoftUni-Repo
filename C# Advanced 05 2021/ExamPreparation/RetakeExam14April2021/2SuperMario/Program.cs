using System;

namespace _2SuperMario
{
    class Program
    {
        static void Main(string[] args)
        {
            int lives = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            char[,] tower = new char[n, n];

            int rowP = 0;
            int colP = 0;
            int rowM = 0;
            int colM = 0;
            int rowB = 0;
            int colB = 0;

            bool end = false;

            // initialize the tower
            for (int i = 0; i < n; i++)
            {
                char[] temp = Console.ReadLine().ToCharArray();
                for (int j = 0; j < n; j++)
                {
                    tower[i, j] = temp[j];
                    if (tower[i, j] == 'M')
                    {
                        rowM = i;
                        colM = j;
                    }
                    if (tower[i, j] == 'P')
                    {
                        rowP = i;
                        colP = j;
                    }

                }
            }

            while (lives > 0 && !end)
            {
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string direction = tokens[0];
                rowB = int.Parse(tokens[1]);
                colB = int.Parse(tokens[2]);
                tower[rowB, colB] = 'B';

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
                        colM = colM == n - 1 ? n - 1 : colM + 1;
                        break;

                    default:
                        Console.WriteLine("Wrong input!");
                        break;
                }

                lives--;

                switch (tower[rowM, colM])
                {
                    case '-':
                        tower[rowM, colM] = 'M';
                        break;

                    case 'M':
                        tower[rowM, colM] = 'M';
                        break;

                    case 'B':
                        lives = lives - 2;
                        tower[rowM, colM] = 'M'; // Here!
                        break;

                    case 'P':
                        tower[rowM, colM] = '-';
                        Console.WriteLine($"Mario has successfully saved the princess! Lives left: {lives}");
                        end = true;
                        break;
                }
            }

            if (lives <= 0)
            {
                Console.WriteLine($"Mario died at {rowM};{colM}.");
                tower[rowM, colM] = 'X';
            }

            // print the tower
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(tower[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
