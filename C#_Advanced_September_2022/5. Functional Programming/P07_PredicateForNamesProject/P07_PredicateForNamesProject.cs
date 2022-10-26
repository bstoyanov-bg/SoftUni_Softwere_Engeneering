using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_PredicateForNamesProject
{
    internal class P07_PredicateForNamesProject
    {
        static void Main(string[] args)
        {
            Action<string[], Predicate<string>> printNames = (names, match) =>
            {
                foreach (var name in names)
                {
                    if (match(name))
                    {
                        Console.WriteLine(name);
                    }
                }
            };

            int nameLength = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            printNames(names, n => n.Length <= nameLength);
        }
    }
}