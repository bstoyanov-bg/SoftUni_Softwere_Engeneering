using System;

namespace P08_TennisRanklistExam
{
    class P08_TennisRanklistExam
    {
        static void Main()
        {
            int numOfTurnaments = int.Parse(Console.ReadLine());
            int initialRankPoints = int.Parse(Console.ReadLine());

            double tournamentPoints = 0;
            int numOfWins = 0;

            for (int i = 1; i <= numOfTurnaments; i++)
            {
                string tournamentStage = Console.ReadLine();

                switch (tournamentStage)
                {
                    case "W":
                        tournamentPoints += 2000;
                        numOfWins++;
                        break;
                    case "F":
                        tournamentPoints += 1200;
                        break;
                    case "SF":
                        tournamentPoints += 720;
                        break;
                }
            }
            double totalPoints = tournamentPoints + initialRankPoints;
            Console.WriteLine($"Final points: {totalPoints}");

            double averageTournamentPoints = tournamentPoints / numOfTurnaments;
            Console.WriteLine($"Average points: {Math.Floor(averageTournamentPoints)}");

            double wonTournamentsPercent = numOfWins / (double)numOfTurnaments * 100;
            Console.WriteLine($"{wonTournamentsPercent:f2}%");
        }
    }
}