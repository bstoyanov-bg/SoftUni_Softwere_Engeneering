using System;

namespace P05_SalaryExam
{
    class P05_SalaryExam
    {
        static void Main()
        {
            int openedTabs = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int fine = 0;
            int sum =0;

            for (int i = 0; i < openedTabs; i++)
            {
               string currentSiteName = (Console.ReadLine());

                if (currentSiteName == "Facebook")
                {
                    fine = 150;
                    sum += fine;
                }
                else if (currentSiteName == "Instagram")
                {
                    fine = 100;
                    sum += fine;
                }
                else if (currentSiteName == "Reddit")
                {
                    fine = 50;
                    sum += fine;
                }
            }
            if (salary - sum <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                int moneyLeft = salary - sum;
                Console.WriteLine(moneyLeft);
            }
        }
    }
}