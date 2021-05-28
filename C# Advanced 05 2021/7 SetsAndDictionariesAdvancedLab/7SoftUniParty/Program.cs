using System;
using System.Collections.Generic;

namespace _7SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();
            bool partyIsStarted = false;

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                if (input == "PARTY")
                {
                    partyIsStarted = true;
                    continue;
                }

                if (char.IsDigit(input[0]))
                {
                    if (partyIsStarted)
                    {
                        vipGuests.Remove(input);
                    }
                    else
                    {
                        vipGuests.Add(input);
                    }
                }
                else
                {
                    if (partyIsStarted)
                    {
                        regularGuests.Remove(input);
                    }
                    else
                    {
                        regularGuests.Add(input);
                    }
                }
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);
            foreach (var guest in vipGuests)
            {
                Console.WriteLine(guest);
            }
            foreach (var guest in regularGuests)
            {
                Console.WriteLine(guest);
            }
        }
 
}
}
