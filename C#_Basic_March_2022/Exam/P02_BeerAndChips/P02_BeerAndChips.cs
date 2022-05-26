using System;

namespace P02_BeerAndChips
{
    class P02_BeerAndChips
    {
        static void Main()
        {
            string fanName = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int numOfBeers = int.Parse(Console.ReadLine());
            int numChipsPackets = int.Parse(Console.ReadLine());

            double oneBeerPrice = 1.20;

            double allBeersPrice = numOfBeers * oneBeerPrice;
            double oneChipsPacket = allBeersPrice * 0.45;
            double allChipsprice = Math.Ceiling(numChipsPackets * oneChipsPacket);

            double tottalPrice = allBeersPrice + allChipsprice;

            if (budget >= tottalPrice)
            {
                double moneyLeft = budget - tottalPrice;
                Console.WriteLine($"{fanName} bought a snack and has {moneyLeft:f2} leva left.");
            }
            else
            {
                double moneyNeeded = tottalPrice - budget;
                Console.WriteLine($"{fanName} needs {moneyNeeded:f2} more leva!");
            }
        }
    }
}