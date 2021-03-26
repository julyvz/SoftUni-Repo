using System;

namespace _6BalancedBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool isBalanced = false;
            bool haveDouble = false;
            int openingBrackets = 0;
            for (int i = 0; i < n; i++)
            {
                if (openingBrackets > 1 || openingBrackets < 0)
                {
                    haveDouble = true;
                }
                string input = Console.ReadLine();
                if (input == "(")
                {
                    openingBrackets++;
                }
                else if (input == ")")
                {
                    openingBrackets--;
                }
            }

            if (openingBrackets == 0 && !haveDouble)
            {
                isBalanced = true;
            }

            if (isBalanced)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
