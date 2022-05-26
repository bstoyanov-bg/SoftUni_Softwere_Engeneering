using System;

namespace P07_ShoppingProject_Exam
{
    class P07_ShoppingProject_Exam
    {
        static void Main()
        {
            int videoCardPrice = 250;

            double petersBudget = double.Parse(Console.ReadLine());
            int videoCardCount = int.Parse(Console.ReadLine());
            int processorCount = int.Parse(Console.ReadLine());
            int ramMemoryCount = int.Parse(Console.ReadLine());

            double allVideoCardPrice = (double)videoCardPrice * videoCardCount;
            double processorPrice = 0.35 * allVideoCardPrice;
            double ramMemoryPrice = 0.1 * allVideoCardPrice;

            double allProcessorsPrice = processorCount * processorPrice;
            double allRamMemorrysPrice = ramMemoryCount * ramMemoryPrice;

            double fifteenPercentDiscount = 0.15;

            double allPartsPrice = allVideoCardPrice + allProcessorsPrice + allRamMemorrysPrice;
            double allPartsPriceDiscount = allPartsPrice - (allPartsPrice * fifteenPercentDiscount);

            if (videoCardCount > processorCount)
            {
                double price = allPartsPriceDiscount;
                if (petersBudget >= price)
                {
                    double extraMoney = petersBudget - price;
                    Console.WriteLine($"You have {extraMoney:f2} leva left!");
                }
                else
                {
                    double neededMoney = price - petersBudget;
                    Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva more!");
                }
            }
            else
            {
                double price = allPartsPrice;
                if (petersBudget >= price)
                {
                    double extraMoney = petersBudget - price;
                    Console.WriteLine($"You have {extraMoney:f2} leva left!");
                }
                else
                {
                    double neededMoney = price - petersBudget;
                    Console.WriteLine($"Not enough money! You need {neededMoney:f2} leva more!");
                }
            }
        }
    }
}