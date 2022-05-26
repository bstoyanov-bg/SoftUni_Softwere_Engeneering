using System;

namespace P05_GodzillaKongProject_Exam
{
    class P05_GodzillaKongProject_Exam
    {
        static void Main()
        {
            double filmBudget = double.Parse(Console.ReadLine());
            int statistsNumber = int.Parse(Console.ReadLine());
            double outfitPriceForOneStatist = double.Parse(Console.ReadLine());

            double decorForFilm = filmBudget * 0.1;
            double outfitPriceForAll = statistsNumber * outfitPriceForOneStatist;

            if (statistsNumber > 150)
            {
                outfitPriceForAll = outfitPriceForAll - (outfitPriceForAll * 0.1);
            }
            else
            {
                outfitPriceForAll = outfitPriceForAll;
            }
            
            double allPrice = outfitPriceForAll + decorForFilm;

            if (allPrice > filmBudget)
            {
                Console.WriteLine($"Not enough money!");
                double neededMoney = allPrice - filmBudget;
                Console.WriteLine($"Wingard needs {neededMoney:F2} leva more.");
            }
            else
            {
                Console.WriteLine($"Action!");
                double extraMoney = filmBudget - allPrice;
                Console.WriteLine($"Wingard starts filming with {extraMoney:F2} leva left.");
            }
        }
    }
}