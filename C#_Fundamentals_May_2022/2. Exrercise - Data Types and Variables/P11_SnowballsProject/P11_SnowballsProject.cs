using System;
using System.Numerics;

namespace P11_SnowballsProject
{
    class P11_SnowballsProject
    {
        static void Main(string[] args)
        {
            int numberOfSnowballs = int.Parse(Console.ReadLine());

            BigInteger snowBallValue = 0;
            BigInteger snowBallSnow = 0;
            BigInteger snowBallTime = 0;
            int snowBallQuality = 0;
            BigInteger bestSnowBallValue = int.MinValue;

            string bestSnowballFormula = "";

            for (int i = 1; i <= numberOfSnowballs; i++)
            {
                snowBallSnow = BigInteger.Parse(Console.ReadLine());
                snowBallTime = BigInteger.Parse(Console.ReadLine());
                snowBallQuality = int.Parse(Console.ReadLine());

                BigInteger currentSnowBallValue = snowBallSnow / snowBallTime;
                snowBallValue = BigInteger.Pow(currentSnowBallValue, snowBallQuality);

                if (snowBallValue > bestSnowBallValue)
                {
                    bestSnowBallValue = snowBallValue;
                    bestSnowballFormula = $"{snowBallSnow} : {snowBallTime} = {bestSnowBallValue} ({snowBallQuality})";
                }
            }

            Console.WriteLine(bestSnowballFormula);
        }
    }
}