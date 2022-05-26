using System;

namespace Problem4_PCGameShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int soldGames = int.Parse(Console.ReadLine());

            int hearthStoneNum = 0;
            int fortniteNum = 0;
            int overwatchNum = 0;
            int othersNum = 0;

            for (int i = 1; i <= soldGames; i++)
            {
                string currentGame = Console.ReadLine();
                if (currentGame == "Hearthstone")
                {
                    hearthStoneNum++;
                }
                else if (currentGame == "Fornite")
                {
                    fortniteNum++;
                }
                else if (currentGame == "Overwatch")
                {
                    overwatchNum++;
                }
                else
                {
                    othersNum++;
                }
            }

            Console.WriteLine($"Hearthstone - {hearthStoneNum / (double)soldGames*100:f2}%");
            Console.WriteLine($"Fornite - {fortniteNum / (double)soldGames *100:f2}%");
            Console.WriteLine($"Overwatch - {overwatchNum / (double)soldGames *100:f2}%");
            Console.WriteLine($"Others - {othersNum / (double)soldGames *100:f2}%");
        }
    }
}