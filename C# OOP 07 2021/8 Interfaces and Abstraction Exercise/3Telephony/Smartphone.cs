using System;

namespace _3Telephony
{
    public class Smartphone : ICallable, IBrowsable
    {
        public string Browse(string site)
        {
            foreach (char symbol in site)
            {
                if (char.IsDigit(symbol))
                {
                    return "Invalid URL!";
                }
            }
            return $"Browsing: {site}!";
        }

        public string Call(string number)
        {
            foreach (char symbol in number)
            {
                if (!char.IsDigit(symbol))
                {
                    return "Invalid number!";
                }
            }

            return $"Calling... {number}";
        }
    }
}
