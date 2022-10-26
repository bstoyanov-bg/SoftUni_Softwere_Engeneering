using System;
using System.Collections.Generic;
using System.Linq;

namespace P09_PredicatePartyProject
{
    internal class P09_PredicatePartyProject
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Party!")
                {
                    break;
                }

                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string filter = tokens[1];
                string valueFilter = tokens[2];

                if (action == "Remove")
                {
                    people.RemoveAll(GetPredicate(filter, valueFilter));
                }
                else
                {
                    List<string> peopleToDouble = people.FindAll(GetPredicate(filter, valueFilter));

                    int index = people.FindIndex(GetPredicate(filter, valueFilter));

                    if (index >= 0)
                    {
                        people.InsertRange(index, peopleToDouble);
                    }
                }
            }

            if (people.Any())
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
        }

        static Predicate<string> GetPredicate(string filter, string valueFilter)
        {
            switch (filter)
            {
                case "StartsWith":
                    return s => s.StartsWith(valueFilter);

                case "EndsWith":
                    return s => s.EndsWith(valueFilter);

                case "Length":
                    return s => s.Length == int.Parse(valueFilter);

                default:
                    return default(Predicate<string>);
            }
        }
    }
}