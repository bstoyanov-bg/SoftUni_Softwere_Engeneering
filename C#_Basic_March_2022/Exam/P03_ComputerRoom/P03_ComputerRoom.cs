using System;

namespace P03_ComputerRoom
{
    class P03_ComputerRoom
    {
        static void Main()
        {
            string month = Console.ReadLine(); //"march", "april", "may", "june", "july", "august"
            int hoursStayed = int.Parse(Console.ReadLine());
            int numOfPeople = int.Parse(Console.ReadLine());
            string dayTime = Console.ReadLine(); //"day", "night"

            double pricePerHour = 0.0;
            double priceForOnePersonForOneHour = 0.0;

            if (month == "march" || month == "april" || month == "may")
            {
                if (dayTime == "day")
                {
                    pricePerHour = 10.5;
                    priceForOnePersonForOneHour = pricePerHour;

                    if (numOfPeople >= 4)
                    {
                        priceForOnePersonForOneHour *= 0.9;

                        if (hoursStayed >= 5)
                        {
                            priceForOnePersonForOneHour *= 0.5;
                        }
                    }

                }
                else if (dayTime == "night")
                {
                    pricePerHour = 8.4;
                    priceForOnePersonForOneHour = pricePerHour;

                    if (numOfPeople >= 4)
                    {
                        priceForOnePersonForOneHour *= 0.9;

                        if (hoursStayed >= 5)
                        {
                            priceForOnePersonForOneHour *= 0.5;
                        }
                    }
                }
            }
            else if (month == "june" || month == "july" || month == "august")
            {
                if (dayTime == "day")
                {
                    pricePerHour = 12.6;
                    priceForOnePersonForOneHour = pricePerHour;

                    if (numOfPeople >= 4)
                    {
                        priceForOnePersonForOneHour *= 0.9;

                        if (hoursStayed >= 5)
                        {
                            priceForOnePersonForOneHour *= 0.5;
                        }
                    }
                }
                else if (dayTime == "night")
                {
                    pricePerHour = 10.2;
                    priceForOnePersonForOneHour = pricePerHour;

                    if (numOfPeople >= 4)
                    {
                        priceForOnePersonForOneHour *= 0.9;

                        if (hoursStayed >= 5)
                        {
                            priceForOnePersonForOneHour *= 0.5;
                        }
                    }
                }
            }

            double tottalPrice = priceForOnePersonForOneHour * numOfPeople * hoursStayed;

            Console.WriteLine($"Price per person for one hour: {priceForOnePersonForOneHour:f2}");
            Console.WriteLine($"Total cost of the visit: {tottalPrice:f2}");
        }
    }
}