using System;

namespace P05_TrainingMaterialsProject_ForExam
{
    class P05_TrainingMaterialsProject_ForExam
    {
        static void Main()
        {
            double penPrice = 5.80;
            double markerPrice = 7.20;
            double detergentPerLiter = 1.20;
            double percentageDivider = 100;

            int numberOfPens = int.Parse(Console.ReadLine());
            int numberOfMarkers = int.Parse(Console.ReadLine());
            int litersOfDetergent = int.Parse(Console.ReadLine());
            int discountNumber = int.Parse(Console.ReadLine());

            double discountPercent = discountNumber / percentageDivider;

            double totalPenPrice = penPrice * numberOfPens;
            double totalMarkerPrice = markerPrice * numberOfMarkers;
            double totalDetergentPrice = detergentPerLiter * litersOfDetergent;

            double totalPrice = totalPenPrice + totalMarkerPrice + totalDetergentPrice;
            double discount = totalPrice * discountPercent;
            double totalPriceWithDiscount = totalPrice - discount;

            Console.WriteLine(totalPriceWithDiscount);
        }
    }
}