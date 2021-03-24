using System;

namespace _01Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            string personType = "";

            if (age>=0 && age <= 2)
            {
                personType = "baby";
            }
            else if (age <= 13)
            {
                personType = "child";
            }
            else if (age <= 19)
            {
                personType = "teenager";
            }
            else if (age <= 65)
            {
                personType = "adult";
            }
            else if (age >= 66)
            {
                personType = "elder";
            }

            Console.WriteLine(personType);
        }
    }
}
