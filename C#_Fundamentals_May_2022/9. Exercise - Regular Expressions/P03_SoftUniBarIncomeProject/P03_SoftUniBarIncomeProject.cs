using System;
using System.Text.RegularExpressions;

namespace P03_SoftUniBarIncomeProject
{
    internal class P03_SoftUniBarIncomeProject
    {
        static void Main(string[] args)
        {
            string pattern = @"%(?<customer>[A-z][a-z]+)%[^|$%.]*<(?<product>\w+)>[^|$%.]*\|(?<count>[\d]+)\|[^|$%.]*?(?<price>[\d]+.?[\d]+)?\$";

            string input = Console.ReadLine();
            double tottalPrice = 0;

            while (input != "end of shift")
            {
                Regex regex = new Regex(pattern);
                bool isValid = regex.IsMatch(input);
                if (isValid)
                {
                    string customer = regex.Match(input).Groups["customer"].Value;
                    string product = regex.Match(input).Groups["product"].Value;
                    int quantity = int.Parse(regex.Match(input).Groups["count"].Value);
                    double price = double.Parse(regex.Match(input).Groups["price"].Value);

                    double priceForCurrProduct = price * quantity;
                    tottalPrice += priceForCurrProduct;

                    Console.WriteLine($"{customer}: {product} - {priceForCurrProduct:f2}");
                }

                input = Console.ReadLine();
            }

                Console.WriteLine($"Total income: {tottalPrice:f2}");
        }
    }
}