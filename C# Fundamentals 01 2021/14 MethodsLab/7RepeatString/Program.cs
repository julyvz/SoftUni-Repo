using System;
using System.Text;

namespace _7RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(RepeatString(str, n));
        }

        static string RepeatString(string str, int n)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb = sb.Append(str);
            }
            return sb.ToString();
        }
    }
}
