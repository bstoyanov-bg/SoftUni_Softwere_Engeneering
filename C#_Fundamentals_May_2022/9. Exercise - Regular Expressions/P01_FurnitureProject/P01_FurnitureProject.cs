using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace P01_FurnitureProject
{
    internal class P01_FurnitureProject
    {
        static void Main(string[] args)
        {
            // 1-st step -> Find the Regex.
            string regex = @">>(?<type>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";
            // 2-nd step -> Read the input.
            string input = Console.ReadLine();
            // 3-rd step -> Create a List which will store the "type" of items.
            var list = new List<string>();
            // 4-th step -> Create variable for the final price.
            double finalPrice = 0;

            //5-th step -> Create "While" loop for every output until the end.
            while (input != "Purchase")
            {
                Match matches = Regex.Match(input, regex, RegexOptions.IgnoreCase);

                if (matches.Success)
                {
                    var type = matches.Groups["type"].Value;
                    var price = double.Parse(matches.Groups["price"].Value);
                    var quantity = int.Parse(matches.Groups["quantity"].Value);
                    list.Add(type);
                    finalPrice += price * quantity;
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            list.ForEach(Console.WriteLine);
            Console.WriteLine($"Total money spend: {finalPrice:f2}");
        }
    }
}