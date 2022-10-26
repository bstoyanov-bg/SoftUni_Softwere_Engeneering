using System;
using System.Collections.Generic;

namespace P02_AMinerTaskProject
{
    internal class P02_AMinerTaskProject
    {
        static void Main(string[] args)
        {
            var metals = new Dictionary<string, int>();
            string resources = Console.ReadLine();

            while (resources != "stop")
            {
               int quantity = int.Parse(Console.ReadLine());

                if (!metals.ContainsKey(resources))
                {
                    metals.Add(resources, 0);
                }
                metals[resources] += quantity;

                resources = Console.ReadLine();
            }

            foreach (var metal in metals)
            {
                Console.WriteLine($"{metal.Key} -> {metal.Value}");
            }
        }
    }
}