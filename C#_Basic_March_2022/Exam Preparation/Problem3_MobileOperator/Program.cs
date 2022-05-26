using System;

namespace Problem3_MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractDuration = Console.ReadLine();
            string contractType = Console.ReadLine();
            string mobileInternet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double oneMonthPrice = 0;

            if (contractDuration == "one")
            {
                if (contractType == "Small")
                {
                    oneMonthPrice = 9.98;
                }
                else if (contractType == "Middle")
                {
                    oneMonthPrice = 18.99;
                }
                else if (contractType == "Large")
                {
                    oneMonthPrice = 25.98;
                }
                else if (contractType == "ExtraLarge")
                {
                    oneMonthPrice = 35.99;
                }

                if (mobileInternet == "yes")
                {
                    if (oneMonthPrice <= 10)
                    {
                        oneMonthPrice += 5.5;
                    }
                    else if (oneMonthPrice <= 30)
                    {
                        oneMonthPrice += 4.35;
                    }
                    else if (oneMonthPrice > 30)
                    {
                        oneMonthPrice += 3.85;
                    }
                }

            }

            else if (contractDuration == "two")
            {
                if (contractType == "Small")
                {
                    oneMonthPrice = 8.58;
                }
                else if (contractType == "Middle")
                {
                    oneMonthPrice = 17.09;
                }
                else if (contractType == "Large")
                {
                    oneMonthPrice = 23.59;
                }
                else if (contractType == "ExtraLarge")
                {
                    oneMonthPrice = 31.79;
                }

                if (mobileInternet == "yes")
                {
                    if (oneMonthPrice <= 10)
                    {
                        oneMonthPrice += 5.5;
                    }
                    else if (oneMonthPrice <= 30)
                    {
                        oneMonthPrice += 4.35;
                    }
                    else if (oneMonthPrice > 30)
                    {
                        oneMonthPrice += 3.85;
                    }
                }

                if (contractDuration == "two")
                {
                    oneMonthPrice *= 0.9625;
                }
            }

            double tottalPrice = oneMonthPrice * months;
            Console.WriteLine($"{tottalPrice:f2} lv.");
        }
    }
}