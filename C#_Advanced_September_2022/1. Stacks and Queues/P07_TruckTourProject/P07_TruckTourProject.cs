using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_TruckTourProject
{
    internal class P07_TruckTourProject
    {
        static void Main(string[] args)
        {
            int numOfPumps = int.Parse(Console.ReadLine()); // == N
            var petrolAmount = new Queue<int>(); // amount of petrol that current pump gives
            var distance = new Queue<int>(); // distance toward next pump

            // Fill queues with input numbers
            for (int i = 0; i < numOfPumps; i++)
            {
                int[] userInput = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                petrolAmount.Enqueue(userInput[0]);
                distance.Enqueue(userInput[1]);
            }

            int fuel = petrolAmount.Peek(); // set initial fuel from first station
            int smallestPumpIndex = 0; // first station index
            int currentIndex = 0; // current index
            int stationsPassedCounter = 0; // counter

            while (stationsPassedCounter <= numOfPumps) // cycling while we pass through all stations
            {
                if (stationsPassedCounter == 0)
                {
                    smallestPumpIndex = currentIndex; // set starting index
                }

                if (fuel >= distance.Peek()) // if we have enough amount of fuel to reach next station
                {
                    fuel -= distance.Peek(); // go to next station (1 L fuel == 1 km distance)
                    stationsPassedCounter++; // +1 passed station

                    petrolAmount.Enqueue(petrolAmount.Dequeue()); // current station is put last in the queue
                    distance.Enqueue(distance.Dequeue());
                    fuel += petrolAmount.Peek(); // load fuel from next station
                }
                else // if we don't have enough amount of fuel to reach next station
                {
                    petrolAmount.Enqueue(petrolAmount.Dequeue()); // current station is put last in the queue so we start from next station
                    distance.Enqueue(distance.Dequeue());

                    fuel = petrolAmount.Peek(); // set initial fuel from next station
                    stationsPassedCounter = 0; // restart counter                    
                }

                currentIndex++;
            }

            // Print output
            Console.WriteLine(smallestPumpIndex);
        }
    }
}