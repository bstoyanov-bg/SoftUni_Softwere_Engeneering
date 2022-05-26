using System;

namespace P08_Basketball_EquipmentProject_ForExam
{
    class Program
    {
        static void Main()
        {
            using System;

namespace P08Basketball_EquipmentProject_ForExam
    {
        class Program
        {
            static void Main()
            {
                int annualTraningPrice = int.Parse(Console.ReadLine());

                double twentyPercent = 0.2;
                double fortyPercent = 0.4;
                double oneForth = 4.0;
                double oneFifth = 5.0;

                double shoesPrice = annualTraningPrice - (annualTraningPrice * fortyPercent);
                double tracksuitPrice = shoesPrice - (shoesPrice * twentyPercent);
                double ballPrice = tracksuitPrice / oneForth;
                double accessoriesPrice = ballPrice / oneFifth;

                double allEqipmentPrice = annualTraningPrice + shoesPrice + tracksuitPrice + ballPrice + accessoriesPrice;

                Console.WriteLine(allEqipmentPrice);
            }
        }
    }
}