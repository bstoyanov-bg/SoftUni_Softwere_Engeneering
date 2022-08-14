using System;
using System.Collections.Generic;

namespace P03_HousePartyProject
{
    class P03_HousePartyProject
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());
            var listOfNames = new List<string>();
            for (int i = 0; i < numOfCommands; i++)
            {
                var command = Console.ReadLine().Split();
                // Contains return true/false !!! (if it is not in the list i skips the step !!!)
                if (listOfNames.Contains(command[0]) && command[2] == "going!")
                {
                    Console.WriteLine($"{command[0]} is already in the list!");
                }
                else if (listOfNames.Contains(command[0]) && command[2] == "not")
                {
                    listOfNames.Remove(command[0]);
                }
                //!listOfNames -> not contains in list
                else if (!listOfNames.Contains(command[0]) && command[2] == "not")
                {
                    Console.WriteLine($"{command[0]} is not in the list!");
                }
                else
                {
                    listOfNames.Add(command[0]);
                }
            }

            foreach (var currentName in listOfNames)
            {
                Console.WriteLine(currentName);
            }
        }
    }
}