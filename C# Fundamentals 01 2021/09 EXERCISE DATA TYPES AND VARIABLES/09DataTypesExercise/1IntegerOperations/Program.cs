using System;

namespace _1IntegerOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());

            long result = ((long)firstNumber + secondNumber)/thirdNumber*fourthNumber;

            Console.WriteLine(result);
        }
    }
}
