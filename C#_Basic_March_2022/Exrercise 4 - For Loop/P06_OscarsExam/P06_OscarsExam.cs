using System;

namespace P06_OscarsExam
{
    class P06_OscarsExam
    {
        static void Main()
        {
            string actorName = Console.ReadLine();
            double pointsFromAcademy = double.Parse(Console.ReadLine());
            int numOfEvaluators = int.Parse(Console.ReadLine());

            double totalPoints = pointsFromAcademy;
            double pointsForNomination = 1250.5;
            bool pointsEnoughForNomination = false;

            for (int juryMember = 1; juryMember <= numOfEvaluators; juryMember++)
            {
                string nameOfEvaluator = Console.ReadLine();
                double pointsFromEvaluator = double.Parse(Console.ReadLine());

                double PointsFromJuryMember = nameOfEvaluator.Length * pointsFromEvaluator / 2;

                totalPoints += PointsFromJuryMember;

                if (totalPoints > pointsForNomination)
                {
                    pointsEnoughForNomination = true;
                    break;
                }
            }
            if (pointsEnoughForNomination)
            {
                Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {totalPoints:f1}!");
            }
            else
            {
                double neededPoints = pointsForNomination - totalPoints;
                Console.WriteLine($"Sorry, {actorName} you need {neededPoints:f1} more!");
            }
        }
    }
}