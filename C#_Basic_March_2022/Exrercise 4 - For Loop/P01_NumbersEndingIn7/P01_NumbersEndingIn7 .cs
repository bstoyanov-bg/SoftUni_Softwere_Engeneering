using System;

namespace P01_NumbersEndingIn7
{
    class P01_NumbersEndingIn7
    {
        static void Main()
        {
            for (int i = 7; i <= 997; i++)
            {
                if (i % 10 == 7)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}