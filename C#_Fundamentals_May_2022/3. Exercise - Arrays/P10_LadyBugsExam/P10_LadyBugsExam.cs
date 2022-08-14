using System;

namespace P10_LadyBugsExam
{
    class P10_LadyBugsExam
    {
        static void Main(string[] args)
        {
            int sizeOfField = int.Parse(Console.ReadLine());

            int[] ladyBugsField = new int[sizeOfField];

            string[] occupiedIndexes = Console.ReadLine().Split();

            for (int i = 0; i < occupiedIndexes.Length; i++)
            {
                int currentIndex = int.Parse(occupiedIndexes[i]);
                if (currentIndex >= 0 && currentIndex < sizeOfField)
                {
                    ladyBugsField[currentIndex] = 1;
                }
            }

            string[] commands = Console.ReadLine().Split();

            while (commands[0] != "end")
            {
                bool isFirst = true;
                int currentIndex = int.Parse(commands[0]);

                while (currentIndex >= 0 && currentIndex < sizeOfField && ladyBugsField[currentIndex] != 0)
                {
                    if (isFirst)
                    {
                        ladyBugsField[currentIndex] = 0;
                        isFirst = false;
                    }

                    string direction = commands[1];
                    int flightLength = int.Parse(commands[2]);

                    if (direction == "left")
                    {
                        currentIndex -= flightLength;
                        if (currentIndex >= 0 && currentIndex < sizeOfField)
                        {
                            if (ladyBugsField[currentIndex] == 0)
                            {
                                ladyBugsField[currentIndex] = 1;
                                break;
                            }
                        }
                    }
                    else
                    {
                        currentIndex += flightLength;
                        if (currentIndex >= 0 && currentIndex < sizeOfField)
                        {
                            if (ladyBugsField[currentIndex] == 0)
                            {
                                ladyBugsField[currentIndex] = 1;
                                break;
                            }
                        }
                    }
                }

                commands = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", ladyBugsField));
        }
    }
}