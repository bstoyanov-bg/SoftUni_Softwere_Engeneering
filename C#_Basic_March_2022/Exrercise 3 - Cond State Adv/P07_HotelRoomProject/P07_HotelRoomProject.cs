using System;

namespace P07_HotelRoomProject
{
    class P07_HotelRoomProject
    {
        static void Main()
        {
            string month = Console.ReadLine();
            int nightNum = int.Parse(Console.ReadLine());

            string accomodation = null;
            double apartmentPrice = 0.0;
            double studioPrice = 0.0;

            switch (month)
            {
                case "May":
                case "October":
                    studioPrice = nightNum * 50.0;
                    apartmentPrice = nightNum * 65.0;
                    if (nightNum > 7 && nightNum <= 14)
                    {
                        studioPrice *= 0.95;
                    }
                    else if (nightNum > 14)
                    {
                        studioPrice *= 0.70;
                        apartmentPrice *= 0.90;
                    }
                    break;
                case "June":
                case "September":
                    studioPrice = nightNum * 75.20;
                    apartmentPrice = nightNum * 68.70;
                    if (nightNum > 14)
                    {
                        studioPrice *= 0.80;
                        apartmentPrice *= 0.90;
                    }
                    break;
                case "July":
                case "August":
                    studioPrice = nightNum * 76.00;
                    apartmentPrice = nightNum * 77.00;
                    if (nightNum > 14)
                    {
                        apartmentPrice *= 0.90;
                    }
                    break;
            }
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}