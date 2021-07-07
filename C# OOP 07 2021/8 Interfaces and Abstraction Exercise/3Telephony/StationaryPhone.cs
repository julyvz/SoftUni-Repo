using System;

namespace _3Telephony
{
    public class StationaryPhone : ICallable
    {
        
        public string Call(string number)
        {
            foreach (char symbol in number)
            {
                if (!char.IsDigit(symbol))
                {
                    return "Invalid number!";
                }
            }

            return ($"Dialing... {number}"); ;
        }
    }
}
