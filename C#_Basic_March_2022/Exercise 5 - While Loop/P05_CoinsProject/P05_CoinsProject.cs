using System;

namespace P05_CoinsProject
{
    class P05_CoinsProject
    {
        static void Main()
        {
            double input = double.Parse(Console.ReadLine()) * 100;
            int change = (int)input;

            int coinsCounter = 0;

            while (change > 0.0)
            {
                if (change >= 200)
                {
                    change -= 200;
                }
                else if (change >= 100)
                {
                    change -= 100;
                }
                else if (change >= 50)
                {
                    change -= 50;
                }
                else if (change >= 20)
                {
                    change -= 20;
                }
                else if (change >= 10)
                {
                    change -= 10;
                }
                else if (change >= 5)
                {
                    change -= 5;
                }
                else if (change >= 2)
                {
                    change -= 2;
                }
                else if (change >= 1)
                {
                    change -= 1;
                }

                coinsCounter++;
            }
            Console.WriteLine($"{coinsCounter}");
        }
    }
}