using System;

namespace _09PadawanEquipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            double priceOfLightsaber = double.Parse(Console.ReadLine());
            double priceOfRobe = double.Parse(Console.ReadLine());
            double priceOfBelt = double.Parse(Console.ReadLine());

            double totalPrice = 0;
            double numberOfLightsabers = Math.Ceiling(numberOfStudents * 1.1);
            totalPrice = numberOfLightsabers * priceOfLightsaber + numberOfStudents * priceOfRobe + (numberOfStudents - numberOfStudents / 6) * priceOfBelt;

            if (budget - totalPrice >= 0)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {totalPrice - budget:F2}lv more.");
            }
        }
    }
}
