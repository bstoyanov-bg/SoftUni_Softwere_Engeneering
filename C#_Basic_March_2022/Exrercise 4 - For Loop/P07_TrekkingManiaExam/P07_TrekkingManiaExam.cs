using System;

namespace P07_TrekkingManiaExam
{
    class P07_TrekkingManiaExam
    {
        static void Main()
        {
            int numOfGroups = int.Parse(Console.ReadLine());

            int numAllPeople = 0;

            int to5people = 0;
            int between6and12 = 0;
            int between13and25 = 0;
            int between26and40 = 0;
            int morethan40 = 0;

            for (int i = 1; i <= numOfGroups; i++)
            {
                int numOfPeople = int.Parse(Console.ReadLine());
                numAllPeople += numOfPeople;

                if (numOfPeople <= 5)
                {
                   to5people += numOfPeople;
                }
                else if (numOfPeople > 5 && numOfPeople <= 12)
                {
                    between6and12 += numOfPeople;
                }
                else if (numOfPeople > 12 && numOfPeople <= 25)
                {
                    between13and25 += numOfPeople;
                }
                else if (numOfPeople > 25 && numOfPeople <= 40)
                {
                    between26and40 += numOfPeople;
                }
                else if (numOfPeople > 40)
                {
                    morethan40 += numOfPeople;
                }
            }

            double group1 = to5people / (double)numAllPeople * 100;
            double group2 = between6and12 / (double)numAllPeople * 100;
            double group3 = between13and25 / (double)numAllPeople * 100;
            double group4 = between26and40 / (double)numAllPeople * 100;
            double group5 = morethan40 / (double)numAllPeople * 100;

            Console.WriteLine($"{group1:f2}%");
            Console.WriteLine($"{group2:f2}%");
            Console.WriteLine($"{group3:f2}%");
            Console.WriteLine($"{group4:f2}%");
            Console.WriteLine($"{group5:f2}%");
        }
    }
}