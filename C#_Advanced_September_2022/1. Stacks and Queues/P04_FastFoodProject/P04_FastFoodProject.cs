using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

namespace P04_FastFoodProject
{
    internal class P04_FastFoodProject
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());

            int[] ordersQuantity = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>(ordersQuantity);

            Console.WriteLine(queue.Max());
            int count = queue.Count;

            for (int i = 0; i < count; i++)
            {
                if (foodQuantity >= queue.Peek())
                {
                    foodQuantity -= queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine($"Orders left: {string.Join(" ", queue)}");
            }
        }
    }
}