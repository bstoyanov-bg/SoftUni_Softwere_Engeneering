using System;

namespace P01_ProgrammingBook_Exam
{
    class P01_ProgrammingBook_Exam
    {
        static void Main()
        {
            double priceForOnePage = double.Parse(Console.ReadLine());
            double priceForOneCover = double.Parse(Console.ReadLine());
            int percentDiscountForPaper = int.Parse(Console.ReadLine());
            double priceForDesigner = double.Parse(Console.ReadLine());
            int percentForAllSumOfTeam = int.Parse(Console.ReadLine());
          
            int numOfPages = 899;
            int numOfCovers = 2;

            double percentDiscountNum = (double)percentDiscountForPaper / 100;
            double percentForAllSumOfTeamNum = (double)percentForAllSumOfTeam / 100;

            double bookValue = priceForOnePage * numOfPages + priceForOneCover * numOfCovers;
            double bookValueAfterDiscount = bookValue - (bookValue * percentDiscountNum);
            double bookValueAfterDiscountAndDesigner = bookValueAfterDiscount + priceForDesigner;
            double FinalValue = bookValueAfterDiscountAndDesigner - (bookValueAfterDiscountAndDesigner * percentForAllSumOfTeamNum);

            Console.WriteLine($"Avtonom should pay {FinalValue:f2} BGN.");
        }
    }
}