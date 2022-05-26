using System;

namespace P03_VacationProject
{
    class P03_VacationProject
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            string groupeType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            double totalPrice = 0;

            if (groupeType == "Students")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = numOfPeople * 8.45;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = numOfPeople * 9.8;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = numOfPeople * 10.46;
                }

                if (numOfPeople >= 30)
                {
                    totalPrice -= totalPrice * 0.15;
                }
            }

            else if (groupeType == "Business")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = numOfPeople * 10.9;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = numOfPeople * 15.6;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = numOfPeople * 16.0;
                }

                if (numOfPeople >= 100)
                {
                    totalPrice -= totalPrice / numOfPeople * 10;
                }
            }

            else if (groupeType == "Regular")
            {
                if (dayOfWeek == "Friday")
                {
                    totalPrice = numOfPeople * 15.0;
                }
                else if (dayOfWeek == "Saturday")
                {
                    totalPrice = numOfPeople * 20.0;
                }
                else if (dayOfWeek == "Sunday")
                {
                    totalPrice = numOfPeople * 22.5;
                }

                if (numOfPeople >= 10 && numOfPeople <= 20)
                {
                    totalPrice -= totalPrice * 0.05;
                }
            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}