using System;

namespace _01DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string dataType = "string";
            int a = 0;
            double b = 0;
            bool hasPoint = false;
            while (input != "END")
            {
                dataType = "string";
                hasPoint = false;
                if (input == "true" || input == "false" || input == "True" || input == "False")
                {
                    dataType = "boolean";
                }
                else if (input.Length == 1 && !(input[0] >= 48 && input[0] <= 57))
                {
                    dataType = "character";
                }
                else
                {
                    if (Int32.TryParse(input, out a))
                    {
                        dataType = "integer";
                    }
                    for (int i = 1; i < input.Length - 1; i++)
                    {
                        if (input[i] == '.')
                        {
                            hasPoint = true;
                        }
                    }
                    if (double.TryParse(input, out b) && hasPoint)
                    {
                        dataType = "floating point";
                    }
                }
                Console.WriteLine($"{input} is {dataType} type");
                input = Console.ReadLine();
            }
        }
    }
}

