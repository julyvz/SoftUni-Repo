using System;

namespace _9GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string input1 = Console.ReadLine();
            string input2 = Console.ReadLine();

            switch (type)
            {
                case "int":
                    int n1 = int.Parse(input1);
                    int n2 = int.Parse(input2);
                    Console.WriteLine(GetMax(n1, n2));
                    break;
                case "char":
                    char c1 = char.Parse(input1);
                    char c2 = char.Parse(input2);
                    Console.WriteLine(GetMax(c1, c2));
                    break;

                default:
                    Console.WriteLine(GetMax(input1, input2));
                    break;
            }

        }

        static int GetMax(int n1, int n2)
        {
            int max = n1;
            if (n2 > n1)
            {
                max = n2;
            }
            return max;
        }

        static char GetMax(char n1, char n2)
        {
            char max = n1;
            if (n2 > n1)
            {
                max = n2;
            }
            return max;
        }

        static string GetMax(string n1, string n2)
        {
            string max = n1;

            if (String.Compare(n1, n2) < 0)
            {
                max = n2;
            }
            return max;
        }

    }
}
