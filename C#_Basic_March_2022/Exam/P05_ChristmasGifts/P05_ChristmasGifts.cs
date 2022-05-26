using System;

namespace P05_ChristmasGifts
{
    class P05_ChristmasGifts
    {
        static void Main()
        {
            int priceForOneToy = 5;
            int priceForOnePulover = 15;

            int toyCounter = 0;
            int puloverCounter = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Christmas")
                {
                    break;
                }

                int age = int.Parse(input);

                if (age <= 16)
                {
                    toyCounter++;
                }
                else
                {
                    puloverCounter++;
                }
            }

            Console.WriteLine($"Number of adults: {puloverCounter}");
            Console.WriteLine($"Number of kids: {toyCounter}");
            Console.WriteLine($"Money for toys: {toyCounter * priceForOneToy}");
            Console.WriteLine($"Money for sweaters: {puloverCounter * priceForOnePulover}");
        }
    }
}