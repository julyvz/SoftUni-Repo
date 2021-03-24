using System;

namespace _03Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double price = 0.0;
            double totalPrice = 0.0;

            switch (groupType)
            {
                case "Students":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 8.45;
                            break;
                        case "Saturday":
                            price = 9.80;
                            break;
                        case "Sunday":
                            price = 10.46;
                            break;
                    }
                    totalPrice = num * price;
                    if (num >= 30)
                    {
                        totalPrice -= 0.15 * totalPrice;
                    }
                    break;
                case "Business":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 10.90;
                            break;
                        case "Saturday":
                            price = 15.60;
                            break;
                        case "Sunday":
                            price = 16.00;
                            break;
                    }
                    if (num >= 100)
                    {
                        num -= 10;
                    }
                    totalPrice = num * price;
                    break;
                case "Regular":
                    switch (dayOfWeek)
                    {
                        case "Friday":
                            price = 15.00;
                            break;
                        case "Saturday":
                            price = 20.00;
                            break;
                        case "Sunday":
                            price = 22.50;
                            break;
                    }
                    totalPrice = num * price;
                    if (num >= 10 && num <= 20)
                    {
                        totalPrice -= 0.05 * totalPrice;
                    }
                    break;
                default:
                    Console.WriteLine("Error!");
                    break;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
