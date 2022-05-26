using System;

namespace P04_WalkingProject
{
    class P04_WalkingProject
    {
        static void Main()
        {
            int dayStepsGoal = 10000;

            int tottalSteps = 0;
            string command = "";

            while (tottalSteps < dayStepsGoal)
            {
                command = Console.ReadLine();

                if (command == "Going home")
                {
                    int lastSteps = int.Parse(Console.ReadLine());
                    tottalSteps += lastSteps;
                    break;
                }
                int steps = int.Parse(command);

                tottalSteps += steps;
            }

            if (tottalSteps >= dayStepsGoal)
            {
                Console.WriteLine("Goal reached! Good job!");
                int moreSteps = tottalSteps - dayStepsGoal;
                Console.WriteLine($"{moreSteps} steps over the goal!");
            }
            else if (dayStepsGoal > tottalSteps)
            {
                int lessSteps = dayStepsGoal - tottalSteps;
                Console.WriteLine($"{lessSteps} more steps to reach goal.");
            }
        }
    }
}