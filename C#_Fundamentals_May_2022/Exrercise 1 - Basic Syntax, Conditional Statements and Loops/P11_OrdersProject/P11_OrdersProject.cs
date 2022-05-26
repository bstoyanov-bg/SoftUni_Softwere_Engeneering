using System;

namespace P11_OrdersProject
{
    class P11_OrdersProject
    {
        static void Main(string[] args)
        {
            int ordersCount = int.Parse(Console.ReadLine());

            double totalPrice = 0;
            //((daysInMonth * capsulesCount) * pricePerCapsule)

            for (int i = 1; i <= ordersCount; i++)
            { 
                double pricePerCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());
                
                double signleOrderPrice = (days * capsulesCount) * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${signleOrderPrice:f2}");
                totalPrice += signleOrderPrice;
            }

            Console.WriteLine($"Total: ${totalPrice:f2}");
        }
    }
}