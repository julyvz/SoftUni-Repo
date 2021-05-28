using System;
using System.Collections.Generic;

namespace _6ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();

            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split(", ");
                string direction = tokens[0];
                string plate = tokens[1];

                if (direction == "IN")
                {
                    parkingLot.Add(plate);
                }
                else
                {
                    parkingLot.Remove(plate);
                }

            }

            if (parkingLot.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parkingLot)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
