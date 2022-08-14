using System;

namespace P07_WaterOverflowProject
{
    class P07_WaterOverflowProject
    {
        static void Main(string[] args)
        {
            const int CAPACITY = 255;

            int numberOfLines = int.Parse(Console.ReadLine());
            int totalQuantity = CAPACITY;

            for (int i = 0; i < numberOfLines; i++)
            {
                int currentQuantity = int.Parse(Console.ReadLine());

                if (totalQuantity - currentQuantity >= 0)
                {
                    totalQuantity -= currentQuantity;
                }
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            int totalFieldQuantity = CAPACITY - totalQuantity;
            Console.WriteLine($"{totalFieldQuantity}");
        }
    }
}