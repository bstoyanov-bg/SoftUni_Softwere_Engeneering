using System;

namespace Problem2_FootballResults
{
    class Program
    {
        static void Main(string[] args)
        {
            int win = 0;
            int lost = 0;
            int draw = 0;

            for (int i = 1; i <= 3; i++)
            {
                string GameResult = Console.ReadLine();

                char HomeScore = GameResult[0];
                char OtherTeamScore = GameResult[2];

                if (HomeScore > OtherTeamScore)
                {
                    win++;
                }

                else if (HomeScore < OtherTeamScore)
                {
                    lost++;
                }

                else if (HomeScore == OtherTeamScore)
                {
                    draw++;
                }
            }

            Console.WriteLine($"Team won {win} games.");
            Console.WriteLine($"Team lost {lost} games.");
            Console.WriteLine($"Drawn games: {draw}");
        }
    }
}