using System;

namespace P01_CinemaProject
{
    class P01_CinemaProject
    {
        static void Main()
        {
            string projectionType = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());
            
            double profit = 0.0;

            if (projectionType == "Premiere")
            {
                profit = rows * colums * 12.0;
            }
            else if (projectionType == "Normal")
            {
                profit = rows * colums * 7.5;
            }
            else if (projectionType == "Discount")
            {
                profit = rows * colums * 5.0;
            }
            Console.WriteLine($"{profit:f2} leva");
        }
    }
}