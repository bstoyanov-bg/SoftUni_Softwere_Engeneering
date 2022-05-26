using System;

namespace P09_FishTankProject_ForExam
{
    class P09_FishTankProject_ForExam
    {
        static void Main()
        {
            double decimeterDivider = 1000;
            double percentDivider = 100;

            int lenghtInCm = int.Parse(Console.ReadLine());
            int widthInCm = int.Parse(Console.ReadLine());
            int heightInCm = int.Parse(Console.ReadLine());
            double accessoriesVolumeNum = double.Parse(Console.ReadLine());

            double accessoriesVolumePercent = accessoriesVolumeNum / percentDivider;

            int totalVolumeOfAquariumInCm = lenghtInCm * widthInCm * heightInCm;

            double totalVolumeOfAquariumInDm = totalVolumeOfAquariumInCm / decimeterDivider;

            double accessoriesVolume = totalVolumeOfAquariumInDm * accessoriesVolumePercent;

            double waterVolume = totalVolumeOfAquariumInDm - accessoriesVolume;

            Console.WriteLine(waterVolume);
        }
    }
}