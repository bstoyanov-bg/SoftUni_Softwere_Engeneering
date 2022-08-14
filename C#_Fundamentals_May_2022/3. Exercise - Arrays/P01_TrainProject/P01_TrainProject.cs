using System;
using System.Linq;

namespace P01_TrainProject
{
    class P01_TrainProject
    {
        static void Main(string[] args)
        {
            int numOfWagons = int.Parse(Console.ReadLine());
            int[] wagons = new int[numOfWagons];

            int sum = 0;

            for (int indexOfWagons = 0; indexOfWagons < wagons.Length; indexOfWagons++)
            {
                wagons[indexOfWagons] = int.Parse(Console.ReadLine());
                sum += wagons[indexOfWagons];
            }

            foreach (int wagon in wagons)
            {
                Console.Write($"{wagon} ");
            }

            Console.WriteLine();
            Console.WriteLine(sum);
        }
    }
}