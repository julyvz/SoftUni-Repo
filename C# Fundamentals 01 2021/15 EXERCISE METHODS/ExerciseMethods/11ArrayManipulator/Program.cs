using System;
using System.Linq;

namespace _11ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            int[] arr = input.Split().Select(int.Parse).ToArray();

            while (command != "end")
            {
                string[] commandInWords = command.Split();
                switch (commandInWords[0])
                {
                    case "exchange":
                        arr = Exchange(arr, int.Parse(commandInWords[1]));
                        break;
                    case "max":
                        Max(arr, commandInWords[1]);
                        break;
                    case "min":
                        Min(arr, commandInWords[1]);
                        break;
                    case "first":
                        First(arr, int.Parse(commandInWords[1]), commandInWords[2]);
                        break;
                    case "last":
                        Last(arr, int.Parse(commandInWords[1]), commandInWords[2]);
                        break;
                    default:
                        break;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"[{String.Join(", ", arr)}]");
        }

        private static void Last(int[] arr, int n, string selector)
        {
            if (n > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }
            int oddElements = 0;
            int evenElements = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenElements++;
                }
                else
                {
                    oddElements++;
                }
            }

            if (selector == "even")
            {
                if (evenElements == 0)
                {
                    Console.WriteLine("[]");
                    return;
                }
                else
                {
                    int[] newArr = new int[evenElements];
                    int j = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 0)
                        {
                            newArr[j] = arr[i];
                            j++;
                        }
                    }
                    if (newArr.Length <= n)
                    {
                        Console.WriteLine($"[{String.Join(", ", newArr)}]");
                    }
                    else
                    {
                        string[] newArrOfStrings = new string[newArr.Length];
                        for (int i = 0; i < newArr.Length; i++)
                        {
                            newArrOfStrings[i] = newArr[i].ToString();
                        }
                        Console.WriteLine($"[{String.Join(", ", newArrOfStrings, newArrOfStrings.Length - n, n)}]");
                    }
                }
            }
            else // odd
            {
                if (oddElements == 0)
                {
                    Console.WriteLine("[]");
                    return;
                }
                else
                {
                    int[] newArr = new int[oddElements];
                    int j = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 != 0)
                        {
                            newArr[j] = arr[i];
                            j++;
                        }
                    }
                    if (newArr.Length <= n)
                    {
                        Console.WriteLine($"[{String.Join(", ", newArr)}]");
                    }
                    else
                    {
                        string[] newArrOfStrings = new string[newArr.Length];
                        for (int i = 0; i < newArr.Length; i++)
                        {
                            newArrOfStrings[i] = newArr[i].ToString();
                        }
                        Console.WriteLine($"[{String.Join(", ", newArrOfStrings, newArrOfStrings.Length - n, n)}]");
                    }
                }
            }
        }

        private static void First(int[] arr, int n, string selector)
        {
            if (n > arr.Length)
            {
                Console.WriteLine("Invalid count");
                return;
            }

            int oddElements = 0;
            int evenElements = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenElements++;
                }
                else
                {
                    oddElements++;
                }
            }

            if (selector == "even")
            {
                if (evenElements == 0)
                {
                    Console.WriteLine("[]");
                    return;
                }
                else
                {
                    int[] newArr = new int[evenElements];
                    int j = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 == 0)
                        {
                            newArr[j] = arr[i];
                            j++;
                        }
                    }
                    if (newArr.Length <= n)
                    {
                        Console.WriteLine($"[{String.Join(", ", newArr)}]");
                    }
                    else
                    {
                        int[] smallArr = new int[n];
                        for (int i = 0; i < n; i++)
                        {
                            smallArr[i] = newArr[i];
                        }
                        Console.WriteLine($"[{String.Join(", ", smallArr)}]");
                    }
                }
            }
            else // odd
            {
                if (oddElements == 0)
                {
                    Console.WriteLine("[]");
                    return;
                }
                else
                {
                    int[] newArr = new int[oddElements];
                    int j = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (arr[i] % 2 != 0)
                        {
                            newArr[j] = arr[i];
                            j++;
                        }
                    }
                    if (newArr.Length <= n)
                    {
                        Console.WriteLine($"[{String.Join(", ", newArr)}]");
                    }
                    else
                    {
                        int[] smallArr = new int[n];
                        for (int i = 0; i < n; i++)
                        {
                            smallArr[i] = newArr[i];
                        }
                        Console.WriteLine($"[{String.Join(", ", smallArr)}]");
                    }
                }
            }
        }

        private static void Min(int[] arr, string selector)
        {
            if (selector == "even")
            {
                int minEven = int.MaxValue;
                int minIndex = -1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        if (arr[i] <= minEven)
                        {
                            minEven = arr[i];
                            minIndex = i;
                        }
                    }
                }
                if (minIndex >= 0)
                {
                    Console.WriteLine(minIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else // odd
            {
                int minOdd = int.MaxValue;
                int minIndex = -1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        if (arr[i] <= minOdd)
                        {
                            minOdd = arr[i];
                            minIndex = i;
                        }
                    }
                }
                if (minIndex >= 0)
                {
                    Console.WriteLine(minIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        private static void Max(int[] arr, string selector)
        {
            if (selector == "even")
            {
                int maxEven = int.MinValue;
                int maxIndex = -1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 == 0)
                    {
                        if (arr[i] >= maxEven)
                        {
                            maxEven = arr[i];
                            maxIndex = i;
                        }
                    }
                }
                if (maxIndex >= 0)
                {
                    Console.WriteLine(maxIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
            else // odd
            {
                int maxOdd = int.MinValue;
                int maxIndex = -1;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] % 2 != 0)
                    {
                        if (arr[i] >= maxOdd)
                        {
                            maxOdd = arr[i];
                            maxIndex = i;
                        }
                    }
                }
                if (maxIndex >= 0)
                {
                    Console.WriteLine(maxIndex);
                }
                else
                {
                    Console.WriteLine("No matches");
                }
            }
        }

        private static int[] Exchange(int[] arr, int index)
        {
            if (index < 0 || index > arr.Length - 1)
            {
                Console.WriteLine("Invalid index");
                return arr;
            }
            int[] newarr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (index + 1 + i > arr.Length - 1)
                {
                    index = index - arr.Length;
                }
                newarr[i] = arr[index + 1 + i];
            }
            return newarr;
        }
    }
}
