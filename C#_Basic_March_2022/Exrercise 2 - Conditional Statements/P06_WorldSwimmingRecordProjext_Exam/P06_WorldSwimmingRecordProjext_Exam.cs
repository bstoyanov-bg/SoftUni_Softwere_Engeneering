using System;

namespace P06_WorldSwimmingRecordProjext_Exam
{
    class P06_WorldSwimmingRecordProjext_Exam
    {
        static void Main()
        {
            double worldRecordInSec = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double distanceForOneMeterInSeconds = double.Parse(Console.ReadLine());

            double allTimeForSwimming = distanceInMeters * distanceForOneMeterInSeconds;
            
            int fifteenMeters = 15;
            double dilayTimeInSeconds = 12.50;

            double extraTimeCount = distanceInMeters / fifteenMeters;
            int in1 = (int)extraTimeCount;
            double extraTime = in1 * dilayTimeInSeconds;

            double allTime = allTimeForSwimming + extraTime;

            if (worldRecordInSec > allTime)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {allTime:F2} seconds.");
            }
            else 
            {
                double notEnoughTime = allTime - worldRecordInSec;
                Console.WriteLine($"No, he failed! He was {notEnoughTime:F2} seconds slower.");
            }
        }
    }
}