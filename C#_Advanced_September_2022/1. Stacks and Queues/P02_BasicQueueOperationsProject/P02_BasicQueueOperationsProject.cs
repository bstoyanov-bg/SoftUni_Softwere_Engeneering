using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace P02_BasicQueueOperationsProject
{
    internal class P02_BasicQueueOperationsProject
    {
        static void Main(string[] args)
        {
            int[] queueArgs = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();
            int[] numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int n = queueArgs[0];
            int remove = queueArgs[1];
            int find = queueArgs[2];

            var queue = new Queue<int>(numbers);

            for (int i = 0; i < remove; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(find))
            {
                Console.WriteLine("true");
            }
            else if (queue.Count == 0)
            {
                Console.WriteLine(queue.Count);
            }
            else
            {
                Console.WriteLine(queue.Min());
            }
        }
    }
}