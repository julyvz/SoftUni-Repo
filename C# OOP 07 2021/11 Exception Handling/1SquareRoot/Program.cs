using System;

namespace _1SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int n = int.Parse(Console.ReadLine());
                if (n < 0)
                    throw new System.ArgumentOutOfRangeException("Invalid number");

                Console.WriteLine(Math.Sqrt(n));
            }
            catch (System.ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
