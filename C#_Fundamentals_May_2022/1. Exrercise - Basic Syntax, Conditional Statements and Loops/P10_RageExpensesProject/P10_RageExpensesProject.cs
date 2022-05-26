using System;

namespace P10_RageExpensesProject
{
    class P10_RageExpensesProject
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int headsetTrashCount = lostGamesCount / 2;
            int mouseTrashCount = lostGamesCount / 3;
            int keyboardTrashCount = lostGamesCount / 6;
            int displayTrashCount = keyboardTrashCount / 2;

            double totalExpense = headsetTrashCount * headsetPrice + mouseTrashCount * mousePrice +
                                keyboardTrashCount * keyboardPrice + displayTrashCount * displayPrice;

            Console.WriteLine($"Rage expenses: {totalExpense:f2} lv.");
        }
    }
}