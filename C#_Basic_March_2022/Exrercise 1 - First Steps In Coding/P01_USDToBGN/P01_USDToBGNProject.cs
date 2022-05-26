using System;

namespace P01_USDToBGN
{
    class P01_USDToBGNProject
    {
        static void Main()
        {
            double usd = double.Parse(Console.ReadLine());
            double OneUsdToOneBgn = 1.79549;

            double ResultusdToBgn = usd * OneUsdToOneBgn;

            Console.WriteLine(ResultusdToBgn);
        }
    }
}