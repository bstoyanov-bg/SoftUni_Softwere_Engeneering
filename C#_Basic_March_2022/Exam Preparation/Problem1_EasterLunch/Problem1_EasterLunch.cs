using System;

namespace Problem1
{
    class Problem1_EasterLunch
    {
        static void Main(string[] args)
        {
            int breadNumber = int.Parse(Console.ReadLine());
            int eggsCartonNumber = int.Parse(Console.ReadLine());
            int cookieNumber = int.Parse(Console.ReadLine());

            double breadPrice = 3.20;
            double eggsPrice = 4.35;
            double cookiePrice = 5.40;
            double eggPaint = 0.15;

            int eggsInOneCarton = 12;

            double breadTottal = breadNumber * breadPrice;
            double eggsTottal = eggsCartonNumber * eggsPrice;
            double cookieTottal = cookieNumber * cookiePrice;
            double eggPaintTottal = eggsCartonNumber * eggsInOneCarton * eggPaint;

            double Tottal = breadTottal + eggsTottal + cookieTottal + eggPaintTottal;

            Console.WriteLine($"{Tottal:f2}");
        }
    }
}