using System;

namespace _3Telephony
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();

            StationaryPhone myStationaryPhone = new StationaryPhone();
            Smartphone mySmartphone = new Smartphone();

            foreach (var number in numbers)
            {
                if (number.Length == 7)
                {
                    Console.WriteLine(myStationaryPhone.Call(number));
                }
                else
                {
                    Console.WriteLine(mySmartphone.Call(number));
                }
            }

            foreach (var site in sites)
            {
                    Console.WriteLine(mySmartphone.Browse(site));
            }
        }
    }
}
