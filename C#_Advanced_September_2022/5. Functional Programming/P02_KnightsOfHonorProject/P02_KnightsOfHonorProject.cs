using System;

namespace P02_KnightsOfHonorProject
{
    internal class P02_KnightsOfHonorProject
    {
        static void Main(string[] args)
        {
            Action<string[], string> printNames = (names, title) =>
            {
                foreach (var name in names)
                {
                    Console.WriteLine($"{title} {name}");
                }
            };

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printNames(names, "Sir");
        }
    }
}