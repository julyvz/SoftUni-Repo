using System;

namespace _02EnglishNameOfTheLastDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Write a method that returns the English name of the last digit of a given number.
            // Write a program that reads an integer and prints the returned value from this method.

            int num = int.Parse(Console.ReadLine());

            string result = LastDigitName(num);
            Console.WriteLine(result);
        }

        static string LastDigitName(int num)
        {
            int lastDigit = num % 10;
            string englishName = "";
            switch (lastDigit)
            {
                case 0:
                    englishName = "zero";
                    break;
                case 1:
                    englishName = "one";
                    break;
                case 2:
                    englishName = "two";
                    break;
                case 3:
                    englishName = "three";
                    break;
                case 4:
                    englishName = "four";
                    break;
                case 5:
                    englishName = "five";
                    break;
                case 6:
                    englishName = "six";
                    break;
                case 7:
                    englishName = "seven";
                    break;
                case 8:
                    englishName = "eight";
                    break;
                case 9:
                    englishName = "nine";
                    break;
                default:
                    englishName = "Something went wrong!";
                    break;
            }
            return englishName;
        }
    }
}
