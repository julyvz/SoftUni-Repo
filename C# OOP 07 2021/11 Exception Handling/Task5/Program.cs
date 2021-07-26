using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;

            try
            {
                a = Convert.ToDouble(Console.ReadLine());
                a *= double.MaxValue;
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
                throw;
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
                throw;
            }

            Console.WriteLine(a);
        }
    }
}
