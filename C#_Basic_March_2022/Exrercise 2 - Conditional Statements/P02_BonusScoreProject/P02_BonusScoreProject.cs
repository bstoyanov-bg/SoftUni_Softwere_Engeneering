using System;

namespace P02_BonusScoreProject
{
    class P02_BonusScoreProject
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            double bonus = 0.0;

            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 100 && number <= 1000)
            {
                bonus = 0.2 * number;
            }
            else
            {
                bonus = 0.1 * number;
            }

            if (number % 2 == 0)
            {
                bonus = bonus +1;
            }
            else if (number % 10 == 5)
            {
                bonus = bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}