using System;
using System.Linq;

namespace _9KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = Console.ReadLine();

            int maxSequence = 0;
            int[] bestDNA = new int[n];
            int sample = 0;
            int bestSample = 0;
            int bestSequenceIndex = 0;
            int bestSequenceSum = 0;

            while (input != "Clone them!")
            {
                int[] dNA = input.Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse).ToArray();

                sample++;
                int sum = 0;
                for (int i = 0; i < dNA.Length; i++)
                {
                    sum += dNA[i];
                }

                int counter = 0;
                for (int i = 0; i < dNA.Length; i++)
                {
                    if (i == 0)
                    {
                        continue;
                    }
                    counter = 1;
                    for (int j = i + 1; j < dNA.Length; j++)
                    {
                        if (dNA[j] == dNA[i])
                        {
                            counter++;
                        }
                        else break;
                    }
                    if (counter > maxSequence)
                    {
                        maxSequence = counter;
                        bestSequenceIndex = i;
                        bestSample = sample;
                        bestDNA = dNA;
                        bestSequenceSum = sum;
                    }

                    else if (counter == maxSequence)
                    {
                        if (i < bestSequenceIndex)
                        {
                            bestSequenceIndex = i;
                            bestSample = sample;
                            bestDNA = dNA;
                            bestSequenceSum = sum;
                        }
                        else if (i == bestSequenceIndex)
                        {
                            if (sum > bestSequenceSum)
                            {
                                bestSequenceIndex = i;
                                bestSample = sample;
                                bestDNA = dNA;
                                bestSequenceSum = sum;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSequenceSum}.");
            Console.WriteLine(String.Join(' ', bestDNA));
        }
    }
}
