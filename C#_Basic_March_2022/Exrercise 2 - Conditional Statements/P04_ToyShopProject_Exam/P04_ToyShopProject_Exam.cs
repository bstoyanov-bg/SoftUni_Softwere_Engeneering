using System;

namespace P04_ToyShopProject_Exam
{
    class P04_ToyShopProject_Exam
    {
        static void Main()
        {
            double puzzlePrice = 2.6;
            double talkingPuppetPrice = 3;
            double teddyBearPrice = 4.1;
            double minionPrice = 8.2;
            double truckPrice = 2;

            double tripPrice = double.Parse(Console.ReadLine());
            int puzzleQuantity = int.Parse(Console.ReadLine());
            int talkingPuppetsQuantity = int.Parse(Console.ReadLine());
            int teddyBearsQuantity = int.Parse(Console.ReadLine());
            int minionsQuantity = int.Parse(Console.ReadLine());
            int trucksQuantity = int.Parse(Console.ReadLine());

            double discount = 0.25;
            double rent = 0.1;

            double puzzleFinalPrice = puzzleQuantity * puzzlePrice;
            double talkingPuppetsFinalPrice = talkingPuppetsQuantity * talkingPuppetPrice;
            double teddyBearsFinalPrice = teddyBearsQuantity * teddyBearPrice;
            double minionsFinalPrice = minionsQuantity * minionPrice;
            double trucksFinalPrice = trucksQuantity * truckPrice;

            int allToysNumber = puzzleQuantity + talkingPuppetsQuantity + teddyBearsQuantity +
                                minionsQuantity + trucksQuantity;

            double allToysPrice = puzzleFinalPrice + talkingPuppetsFinalPrice + teddyBearsFinalPrice +
                                  minionsFinalPrice + trucksFinalPrice;
            double allToysPriceDiscount = allToysPrice * discount;

            if (allToysNumber >= 50)
            {
                allToysPrice = allToysPrice - allToysPriceDiscount;
            }
            
            double allToysPriceRent = allToysPrice * rent;
            double allToysFinalPriceWithRent = allToysPrice - allToysPriceRent;

            if (allToysFinalPriceWithRent >= tripPrice)
            {
                double moneyLeft = allToysFinalPriceWithRent - tripPrice;
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else 
            {
                double lackOfMoney = tripPrice - allToysFinalPriceWithRent;
                Console.WriteLine($"Not enough money! {lackOfMoney:f2} lv needed.");
            }
        }
    }
}