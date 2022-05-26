using System;

namespace Problem5_SuitcasesLoad
{
    class Program
    {
        static void Main(string[] args)
        {
            double loadCapacity = double.Parse(Console.ReadLine());

            int suitcaseNumber = 0;
            string command = "";

            while (true)
            {
                command = Console.ReadLine();

                if (command == "End")
                {
                    Console.WriteLine("Congratulations! All suitcases are loaded!");
                    break;
                }

                double suitcase = double.Parse(command);
                suitcaseNumber++;

                if (suitcaseNumber % 3 == 0)
                {
                    suitcase *= 1.1;
                }

                if (loadCapacity < suitcase)
                {
                    suitcaseNumber--;
                    Console.WriteLine("No more space!");
                    break;
                }
                loadCapacity -= suitcase;
            }

            Console.WriteLine($"Statistic: {suitcaseNumber} suitcases loaded.");
        }
    }
}