using System;

namespace P06_RepaintingProject_ForExam
{
    class P06_RepaintingProject_ForExam
    {
        static void Main()
        {
            double nylonPerSqMPrice = 1.50;
            double paintPerLiterPrice = 14.50;
            double thinnerPerLiterPrice = 5.00;
            double bagsPrice = 0.40;
            
            double extraNylon = 2;

            double thirtyPercent = 0.3;

            int nylonSqM = int.Parse(Console.ReadLine());
            int paintLiters = int.Parse(Console.ReadLine());
            int thinnerLiters = int.Parse(Console.ReadLine());
            int workHours = int.Parse(Console.ReadLine());

            double totalNylonSqM = nylonSqM + extraNylon;
            double totalPaint = paintLiters * 1.1;

            double totalSpentOnNylon = totalNylonSqM * nylonPerSqMPrice;
            double totalSpentOnPaint = totalPaint * paintPerLiterPrice;
            double totalSpentOnThinner = thinnerLiters * thinnerPerLiterPrice;

            double totalForMaterials = totalSpentOnNylon + totalSpentOnPaint + totalSpentOnThinner + bagsPrice;

            double workersHourPrice = thirtyPercent * totalForMaterials;

            double totalForWorkers = workersHourPrice * workHours;

            double totalWork = totalForMaterials + totalForWorkers;

            Console.WriteLine(totalWork);
        }
    }
}
