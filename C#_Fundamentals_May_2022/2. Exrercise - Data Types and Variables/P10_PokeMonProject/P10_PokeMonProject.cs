using System;

namespace P10_PokeMonProject
{
    class P10_PokeMonProject
    {
        static void Main(string[] args)
        {
            int power = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            int exhsaustionFactor = int.Parse(Console.ReadLine());
            int startingPower = power;
            int pockedTargetsCount = 0;

            while (power >= distance)
            {
                power -= distance;
                pockedTargetsCount++;

                if (startingPower * 0.5 == power && exhsaustionFactor > 0)
                {
                    power /= exhsaustionFactor;
                }
            }

            Console.WriteLine($"{power}");
            Console.WriteLine($"{pockedTargetsCount}");
        }
    }
}