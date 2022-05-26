using System;

namespace P05_JourneyProject
{
    class P05_JourneyProject
    {
        static void Main()
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double priceForHouseing = 0.0;
            string placeToStay = null;
            string destination = null;

            if (budget <= 100)
            {
                switch (season)
                {
                    case "summer":
                        placeToStay = "Camp";
                        destination = "Bulgaria";
                        priceForHouseing = budget * 0.3;
                        break;
                    case "winter":
                        placeToStay = "Hotel";
                        destination = "Bulgaria";
                        priceForHouseing = budget * 0.7;
                        break;
                }
            }
            else if (budget > 100 && budget <= 1000)
            {
                switch (season)
                {
                    case "summer":
                        placeToStay = "Camp";
                        destination = "Balkans";
                        priceForHouseing = budget * 0.4;
                        break;
                    case "winter":
                        placeToStay = "Hotel";
                        destination = "Balkans";
                        priceForHouseing = budget * 0.8;
                        break;
                }
            }
            else if (budget > 1000)
            {
                switch (season)
                {
                    case "summer":
                    case "winter":
                        placeToStay = "Hotel";
                        destination = "Europe";
                        priceForHouseing = budget * 0.9;
                        break;
                }
            }

            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine($"{placeToStay} - {priceForHouseing:f2}");
        }
    }
}