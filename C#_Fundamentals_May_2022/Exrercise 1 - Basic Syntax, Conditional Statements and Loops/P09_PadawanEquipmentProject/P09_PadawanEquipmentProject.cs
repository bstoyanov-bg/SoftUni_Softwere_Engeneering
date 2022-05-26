using System;

namespace P09_PadawanEquipmentProject
{
    class P09_PadawanEquipmentProject
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numOfStudents = int.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            double totalNumberOfSabers = Math.Ceiling(numOfStudents * 1.1);
            double numberOfFreeBelts = Math.Floor(numOfStudents / 6.0);
            double totalNumberOfBelts = numOfStudents - numberOfFreeBelts;
            double totalNumberOfRobes = numOfStudents;

            double totalPriceForSabers = totalNumberOfSabers * lightsaberPrice;
            double totalPriceForBelts = totalNumberOfBelts * beltPrice;
            double totalPriceForRobes = totalNumberOfRobes * robePrice;

            double totalPriceForEquipment = totalPriceForSabers + totalPriceForBelts + totalPriceForRobes;

            if (budget >= totalPriceForEquipment)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPriceForEquipment:f2}lv.");
            }
            else if (totalPriceForEquipment > budget)
            {
                double neededMoney = Math.Abs(budget - totalPriceForEquipment);
                Console.WriteLine($"John will need {neededMoney:f2}lv more.");
            }
        }
    }
}