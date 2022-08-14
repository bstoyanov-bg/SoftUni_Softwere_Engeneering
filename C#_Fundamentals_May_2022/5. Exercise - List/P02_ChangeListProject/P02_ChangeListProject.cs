using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_ChangeListProject
{
    class P02_ChangeListProject
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();
                string cmd = tokens[0];

                if (cmd == "Delete")
                {
                    int element = int.Parse(tokens[1]);
                    numbers.RemoveAll(elem => elem == element);
                }
                else if (cmd == "Insert")
                {
                    int element = int.Parse(tokens[1]);
                    int index = int.Parse(tokens[2]);
                    numbers.Insert(index, element);
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}