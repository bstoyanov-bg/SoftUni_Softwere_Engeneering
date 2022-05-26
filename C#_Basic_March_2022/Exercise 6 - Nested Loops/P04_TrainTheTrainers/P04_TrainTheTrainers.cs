using System;

namespace P04_TrainTheTrainers
{
    class P04_TrainTheTrainers
    {
        static void Main()
        {
            int juryMembersNum = int.Parse(Console.ReadLine());

            double totalAverageGrades = 0;
            int presentationsCounter = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "Finish")
                {
                    break;
                }

                string presentationTitle = input;
                presentationsCounter++;

                double gradesForPresentation = 0;

                for (int juryMember = 1; juryMember <= juryMembersNum; juryMember++)
                {
                    double grade = double.Parse(Console.ReadLine());

                    gradesForPresentation += grade;
                }

                double averageForPresentation = gradesForPresentation / juryMembersNum;
                Console.WriteLine($"{presentationTitle} - {averageForPresentation:f2}.");

                totalAverageGrades += averageForPresentation;
            }

            double averagefForCourse = totalAverageGrades / presentationsCounter;
            Console.WriteLine($"Student's final assessment is {averagefForCourse:f2}.");
        }
    }
}