using System;

namespace P03_NewHouseProject
{
    class P03_NewHouseProject
    {
        static void Main()
        {
            string flowerType = Console.ReadLine();
            int flowerCount = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double singlePrice = 0.0;
            double totalToPay = 0.0;

            switch (flowerType)
            {
                case "Roses":
                    singlePrice = 5.00;
                    totalToPay = flowerCount * singlePrice;
                    if (flowerCount > 80)
                    {
                        totalToPay *= 0.9;
                    }
                    break;
                case "Dahlias":
                    singlePrice = 3.80;
                    totalToPay = flowerCount * singlePrice;
                    if (flowerCount > 90)
                    {
                        totalToPay *= 0.85;
                    }
                    break;
                case "Tulips":
                    singlePrice = 2.80;
                    totalToPay = flowerCount * singlePrice;
                    if (flowerCount > 80)
                    {
                        totalToPay *= 0.85;
                    }
                    break;
                case "Narcissus":
                    singlePrice = 3.00;
                    totalToPay = flowerCount * singlePrice;
                    if (flowerCount < 120)
                    {
                        totalToPay *= 1.15;
                    }
                    break;
                case "Gladiolus":
                    singlePrice = 2.50;
                    totalToPay = flowerCount * singlePrice;
                    if (flowerCount < 80)
                    {
                        totalToPay *= 1.20;
                    }
                    break;
            }
            if (budget >= totalToPay)
            {
                double extraMoney = budget - totalToPay;
                Console.WriteLine($"Hey, you have a great garden with {flowerCount} {flowerType} and {extraMoney:f2} leva left.");
            }
            else if (budget <= totalToPay)
            {
                double neededMoney = totalToPay - budget;
                Console.WriteLine($"Not enough money, you need {neededMoney:f2} leva more.");
            }
        }
    }
}