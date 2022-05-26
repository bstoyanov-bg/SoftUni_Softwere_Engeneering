using System;

namespace P05_SpecialNumbers
{
    class P05_SpecialNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                int copyI = i;

                bool iIsSpecial = true;

                for (int j = 1; j <= 4; j++)
                {
                    int currentDigit = copyI % 10;

                    if (currentDigit == 0 || number % currentDigit != 0)
                    {
                        iIsSpecial = false;
                        break;
                    }

                    copyI /= 10;
                }

                if (iIsSpecial)
                {
                    Console.Write($"{i} ");
                }
            }
        }
    }
}