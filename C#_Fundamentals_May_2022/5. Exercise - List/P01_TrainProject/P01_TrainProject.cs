using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_TrainProject
{
    class P01_TrainProject
    {
        static void Main(string[] args)
        {
            List<int> trainWagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonCapacity = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();

                if (tokens.Length == 2)
                {
                    int wagonToAdd = int.Parse(tokens[1]);
                    trainWagons.Add(wagonToAdd);
                }
                else
                {
                    int peopleToFindPlace = int.Parse(tokens[0]);
                    FindFreeWagons(trainWagons, wagonCapacity, peopleToFindPlace);
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", trainWagons));
        }

        static void FindFreeWagons(List<int> trainWagons, int wagonCapacity, int peopleToFindPlace)
        {
            for (int i = 0; i < trainWagons.Count; i++)
            {
                int currentWagon = trainWagons[i];
                if (currentWagon + peopleToFindPlace <= wagonCapacity)
                {
                    trainWagons[i] += peopleToFindPlace;
                    break;
                }
            }
        }
    }
}