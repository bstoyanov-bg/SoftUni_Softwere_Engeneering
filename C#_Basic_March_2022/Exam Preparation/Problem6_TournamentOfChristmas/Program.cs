using System;

namespace Problem6_TournamentOfChristmas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfDaysTournament = int.Parse(Console.ReadLine());

            int allWonGames = 0;
            int allLostGames = 0;
            double monneyWon = 0.0;

            bool isTournamentWon = false;

            for (int i = 0; i < numOfDaysTournament; i++)
            {
                int dayWins = 0;  
                int dayLoses = 0;
                double dailyMoney = 0.0;

                string input;
                while ((input = Console.ReadLine()) != "Finish" )
                {

                    string gameResult = Console.ReadLine();
                    if (gameResult == "win")
                    {
                        dailyMoney += 20;
                        dayWins++;
                        allWonGames++;
                    }
                    else
                    {
                        dayLoses++;
                        allLostGames++;
                    }
                }

                if (dayWins > dayLoses)
                {
                    dailyMoney *= 1.1;
                }

                monneyWon += dailyMoney;
            }

            if (allWonGames > allLostGames)
            {
                monneyWon *= 1.2;
                Console.WriteLine($"You won the tournament! Total raised money: {monneyWon:f2}");
            }
            else
            {
                Console.WriteLine($"You lost the tournament! Total raised money: {monneyWon:f2}");
            }
        }
    }   
}