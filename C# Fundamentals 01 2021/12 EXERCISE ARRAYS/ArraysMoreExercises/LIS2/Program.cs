using System;
using System.Linq;

namespace LIS2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = nums.Length;

            int lengthOfIS = 1;
            int maxLengthOfIS = 0;
            int maxStartIndex = 0;
            int[] potential = new int[n];

            for (int i = 0; i < n; i++)
            {
                int counterPotential = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (nums[j] > nums[i])
                    {
                        counterPotential++;
                    }
                }
                potential[i] = counterPotential;
            }

            for (int m = 0; m < n; m++)
            {
                lengthOfIS = 1;
                int k = m;
                while (true)
                {
                    int nextIndex = FindNext(k, nums, potential);
                    if (nextIndex == 0)
                    {
                        break;
                    }
                    lengthOfIS++;
                    k = nextIndex;
                }
                if (lengthOfIS > maxLengthOfIS)
                {
                    maxLengthOfIS = lengthOfIS;
                    maxStartIndex = m;
                }
            }

            while (maxStartIndex <= n)
            {
                Console.Write(nums[maxStartIndex] + " ");
                maxStartIndex = FindNext(maxStartIndex, nums, potential);
                if (maxStartIndex == 0)
                {
                    break;
                }
            }
        }

        static int FindNext(int startIndex, int[] nums, int[] potential)
        {
            int nextIndex = 0;
            int maxPotential = 0;
            for (int i = startIndex; i < nums.Length; i++)
            {
                if (nums[i] > nums[startIndex] && potential[i] > maxPotential)
                {
                    maxPotential = potential[i];
                    nextIndex = i;
                }
            }

            return nextIndex;
        }
    }
}
