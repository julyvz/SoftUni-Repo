using System;
using System.Collections.Generic;
using System.Linq;

namespace _1Scheduling
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> tasks = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse));
            Queue<int> threads = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int taskToBeKilled = int.Parse(Console.ReadLine());

            while (threads.Count > 0)
            {
                int currentTask = tasks.Peek();
                int currentThread = threads.Peek();
                if (currentTask == taskToBeKilled)
                {
                    Console.WriteLine($"Thread with value {currentThread} killed task {taskToBeKilled}");
                    break;
                }
                if (currentThread >= currentTask)
                {
                    tasks.Pop();
                }
                    threads.Dequeue();
            }
            Console.WriteLine(string.Join(' ', threads));
        }
    }
}
