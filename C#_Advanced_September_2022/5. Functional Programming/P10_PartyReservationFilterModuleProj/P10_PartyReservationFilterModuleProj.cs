using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_PartyReservationFilterModuleProj
{
    internal class P10_PartyReservationFilterModuleProj
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            Dictionary<string, Predicate<string>> filters = new Dictionary<string, Predicate<string>>();

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "Print")
                {
                    break;
                }

                string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string filter = tokens[1];
                string valueFilter = tokens[2];

                if (action == "Add filter")
                {
                    filters.Add( filter + valueFilter, GetPredicate(filter, valueFilter));
                }
                else
                {
                    filters.Remove(filter + valueFilter);
                }
            }

            foreach (var filter in filters)
            {
                people.RemoveAll(filter.Value);
            }

            Console.WriteLine(String.Join(" ", people));
        }

        static Predicate<string> GetPredicate(string filter, string valueFilter)
        {
            switch (filter)
            {
                case "Starts with":
                    return s => s.StartsWith(valueFilter);

                case "Ends with":
                    return s => s.EndsWith(valueFilter);

                case "Length":
                    return s => s.Length == int.Parse(valueFilter);

                case "Contains":
                    return s => s.Contains(valueFilter);

                default:
                    return default(Predicate<string>);
            }
        }
    }
}
