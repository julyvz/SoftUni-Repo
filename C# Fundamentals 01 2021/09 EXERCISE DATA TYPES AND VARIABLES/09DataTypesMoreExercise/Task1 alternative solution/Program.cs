using System;

namespace DataTypeFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string dataType = "string";

            while (input != "END")
            {
                bool integerChek = int.TryParse(input, out int integer);
                bool doubleChek = double.TryParse(input, out double floating);
                bool charChek = char.TryParse(input, out char mychar);
                bool boolChek = bool.TryParse(input, out bool boolean);
                dataType = "string";
                if (integerChek)
                {
                    dataType = "integer";
                }
                else if (doubleChek)
                {
                    dataType = "floating point";
                }
                else if (charChek)
                {
                    dataType = "character";
                }
                else if (boolChek)
                {
                    dataType = "boolean";
                }
                Console.WriteLine($"{input} is {dataType} type");
                input = Console.ReadLine();
            }
        }
    }
}