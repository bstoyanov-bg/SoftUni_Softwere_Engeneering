using System;

namespace P04_FishingBoatProject
{
    class P04_FishingBoatProject
    {
        static void Main()
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numOfFisherman = int.Parse(Console.ReadLine());

            double boatPrice = 0.0;

            switch (season)
            {
                case "Spring":
                    boatPrice = 3000;
                    if (numOfFisherman <= 6)
                    {
                        boatPrice *= 0.9;
                        if (numOfFisherman <= 6 && numOfFisherman % 2 == 0)
                        {
                            boatPrice *= 0.95;
                        }
                    }
                    else if (numOfFisherman > 7 && numOfFisherman <= 11)
                    {
                        boatPrice *= 0.85;
                        if (numOfFisherman > 7 && numOfFisherman <= 11 && numOfFisherman % 2 == 0)
                        {
                            boatPrice *= 0.95;
                        }
                    }
                    else if (numOfFisherman > 12)
                    {
                        boatPrice *= 0.75;
                        if (numOfFisherman > 12 && numOfFisherman % 2 == 0)
                        {
                            boatPrice *= 0.95;
                        }
                    }
                    break;
                case "Summer":
                    boatPrice = 4200;
                    if (numOfFisherman <= 6)
                    {
                        boatPrice *= 0.9;
                        if (numOfFisherman <= 6 && numOfFisherman % 2 == 0)
                        {
                            boatPrice *= 0.95;
                        }
                    }
                    else if (numOfFisherman > 7 && numOfFisherman <= 11)
                    {
                        boatPrice *= 0.85;
                        if (numOfFisherman > 7 && numOfFisherman <= 11 && numOfFisherman % 2 == 0)
                        {
                            boatPrice *= 0.95;
                        }
                    }
                    else if (numOfFisherman > 12)
                    {
                        boatPrice *= 0.75;
                        if (numOfFisherman > 12 && numOfFisherman % 2 == 0)
                        {
                            boatPrice *= 0.95;
                        }
                    }
                    break;
                case "Autumn":
                    boatPrice = 4200;
                    if (numOfFisherman <= 6)
                    {
                        boatPrice *= 0.9;
                    }
                    else if (numOfFisherman > 7 && numOfFisherman <= 11)
                    {
                        boatPrice *= 0.85;
                    }
                    else if (numOfFisherman > 12)
                    {
                        boatPrice *= 0.75;
                    }
                    break;
                case "Winter":
                        boatPrice = 2600;
                    if (numOfFisherman <= 6)
                    {
                        boatPrice *= 0.9;
                        if (numOfFisherman <= 6 && numOfFisherman % 2 == 0)
                        {
                            boatPrice *= 0.95;
                        }
                    }
                    else if (numOfFisherman > 7 && numOfFisherman <= 11)
                    {
                        boatPrice *= 0.85;
                        if (numOfFisherman > 7 && numOfFisherman <= 11 && numOfFisherman % 2 == 0)
                        {
                            boatPrice *= 0.95;
                        }
                    }
                    else if (numOfFisherman > 12)
                    {
                        boatPrice *= 0.75;
                        if (numOfFisherman > 12 && numOfFisherman % 2 == 0)
                        {
                            boatPrice *= 0.95;
                        }
                    }
                    break;
            }

            bool budgesIsSufficient = budget >= boatPrice;

            switch (budgesIsSufficient)
            {
                case true:
                    double extraMoney = budget - boatPrice;
                    Console.WriteLine($"Yes! You have {extraMoney:f2} leva left.");
                        break;
                case false:
                    double neededMoney = boatPrice - budget;
                    Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva.");
                    break;
            }
        }
    }
}