using System;
using System.Collections.Generic;

namespace P03_OrdersProject
{
    internal class P03_OrdersProject
    {
        static void Main(string[] args)
        {
            var productAndPrice = new Dictionary<string, double>();
            var productAndQuantity = new Dictionary<string, int>();

            var input = Console.ReadLine();

            while (input != "buy")
            {
                var cmd = input.Split();
                var productName = cmd[0];
                double productPrice = double.Parse(cmd[1]); 
                int productQuantity = int.Parse(cmd[2]);

                if (!productAndPrice.ContainsKey(productName))
                {
                    productAndPrice.Add(productName, productPrice);
                    productAndQuantity.Add(productName, productQuantity);
                }
                else if (productAndPrice.ContainsKey(productName))
                {
                    productAndPrice.Remove(productName);
                    productAndPrice.Add(productName, productPrice);
                    productAndQuantity[productName] += productQuantity;
                }

                input = Console.ReadLine();
            }

            foreach (var productPrice in productAndPrice)
            {
                foreach (var productQuantity in productAndQuantity)
                {
                    if (productPrice.Key == productQuantity.Key)
                    {
                        Console.WriteLine($"{productPrice.Key} -> {productPrice.Value * productQuantity.Value:f2}");
                    }
                }
            }
        }
    }
}