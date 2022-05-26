using System;

namespace P07_Food_DeliveryProject_ForExam
{
    class Program
    {
        static void Main()
        {
            double chickenMenuPrice = 10.35;
            double fishMenuPrice = 12.40;
            double vegMenuPrice = 8.15;
            double deliveryPrice = 2.50;

            double twentyPercent = 0.2;

            int chickenMenuCount = int.Parse(Console.ReadLine());
            int fishMenuCount = int.Parse(Console.ReadLine());
            int vegMenuCount = int.Parse(Console.ReadLine());

            double totalChickenMenu = chickenMenuCount * chickenMenuPrice;
            double totalFishMenu = fishMenuCount * fishMenuPrice;
            double totalVegMenu = vegMenuCount * vegMenuPrice;

            double totalMenus = totalChickenMenu + totalFishMenu + totalVegMenu;

            double desertPrice = totalMenus * twentyPercent;

            double totalCheck = totalMenus + desertPrice + deliveryPrice;

            Console.WriteLine(totalCheck);
        }
    }
}