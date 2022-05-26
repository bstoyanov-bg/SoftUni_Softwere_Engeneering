using System;

namespace P09_SkiTripProect
{
    class P09_SkiTripProect
    {
        static void Main()
        {
            int daysToStay = int.Parse(Console.ReadLine());
            string accommodationType = Console.ReadLine();
            string evaluation = Console.ReadLine();

            int nightsToStay = daysToStay - 1;
            double price = 0.0;
            double priceAllNights = 0;

            switch (accommodationType)
            {
                case "room for one person":
                    price = 18.0;
                    priceAllNights = nightsToStay * price;
                    break;

                case "apartment":
                    price = 25.0;
                    if (daysToStay < 10)
                    {
                        price *= 0.7;
                        priceAllNights = nightsToStay * price;
                    }
                    else if (daysToStay >= 10 && daysToStay <= 15)
                    {
                        price *= 0.65;
                        priceAllNights = nightsToStay * price;
                    }
                    else if (daysToStay > 15)
                    {
                        price *= 0.50;
                        priceAllNights = nightsToStay * price;
                    }
                    break;

                case "president apartment":
                    price = 35.0;
                    if (daysToStay < 10)
                    {
                        price *= 0.9;
                        priceAllNights = nightsToStay * price;
                    }
                    else if (daysToStay >= 10 && daysToStay <= 15)
                    {
                        price *= 0.85;
                        priceAllNights = nightsToStay * price;
                    }
                    else if (daysToStay > 15)
                    {
                        price *= 0.80;
                        priceAllNights = nightsToStay * price;
                    }
                    break;
            }
            switch (evaluation)
            {
                case "positive":
                    priceAllNights *= 1.25;
                    break;

                case "negative":
                    priceAllNights *= 0.90;
                    break;
            }

            Console.WriteLine($"{priceAllNights:f2}");
        }
    }
}