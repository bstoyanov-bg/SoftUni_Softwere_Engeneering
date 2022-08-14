using System;

namespace P08_BeerKegsProject
{
    class P08_BeerKegsProject
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            double biggestKeg = double.MinValue;
            string biggestKegName = "";

            for (int i = 1; i <= nLines; i++)
            {
                string currentKegName = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volumeOfCurrentKeg = Math.PI * Math.Pow(radius, 2) * height;

                if (volumeOfCurrentKeg > biggestKeg)
                {
                    biggestKegName = currentKegName;
                    biggestKeg = volumeOfCurrentKeg;
                }
            }

            Console.WriteLine($"{biggestKegName}");
        }
    }
}