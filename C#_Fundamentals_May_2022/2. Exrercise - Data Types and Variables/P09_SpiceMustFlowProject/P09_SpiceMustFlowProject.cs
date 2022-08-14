using System;

namespace P09_SpiceMustFlowProject
{
    class P09_SpiceMustFlowProject
    {
        static void Main(string[] args)
        {
            int startingYield = int.Parse(Console.ReadLine());
            const int CONSUMATION = 26;
            int currentYield = 0;
            int totalSpice = 0;
            int days = 0;

            while (startingYield >= 100)
            {
                currentYield = startingYield - CONSUMATION;
                totalSpice += currentYield;
                days++;
                startingYield -= 10;

                if (startingYield < 100)
                {
                    totalSpice -= CONSUMATION;
                }
            }

            Console.WriteLine($"{days}");
            Console.WriteLine($"{totalSpice}");
        }
    }
}