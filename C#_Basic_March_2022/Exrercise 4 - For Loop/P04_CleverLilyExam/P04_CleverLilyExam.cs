using System;

namespace P04_CleverLilyExam
{
    class P04_CleverLilyExam
    {
        static void Main()
        {
            int age = int.Parse(Console.ReadLine());
            double washingmachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int toyCount = 0;
            double cashBox = 0;
            double moneyGift = 10;

            for (int birthday = 1; birthday <= age; birthday++)
            {
                if (birthday % 2 == 1)
                {
                    toyCount++;
                }
                else
                {
                    cashBox += moneyGift;
                    cashBox--;
                    moneyGift += 10;
                }
            }
            double allToysPrice = toyCount * toyPrice;
            double allMoney = allToysPrice + cashBox;

            if (allMoney >= washingmachinePrice)
            {
                double extraMoney = allMoney - washingmachinePrice;
                Console.WriteLine($"Yes! {extraMoney:f2}");
            }
            else
            {
                double neededMoney = washingmachinePrice - allMoney;
                Console.WriteLine($"No! {neededMoney:f2}");
            }
        }
    }
}