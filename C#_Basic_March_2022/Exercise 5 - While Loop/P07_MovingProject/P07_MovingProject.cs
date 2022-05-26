using System;

namespace P07_MovingProject
{
    class P07_MovingProject
    {
        static void Main()
        {
            int widthFreeSpace = int.Parse(Console.ReadLine());
            int lenghtFreeSpace = int.Parse(Console.ReadLine());
            int heightFreeSpace = int.Parse(Console.ReadLine());

            int volumeFreeSpace = widthFreeSpace * lenghtFreeSpace * heightFreeSpace;

            string command = "";

            bool roomIsFull = false;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "Done")
                {
                    break;
                }

                int boxes = int.Parse(command);

                volumeFreeSpace -= boxes;

                if (volumeFreeSpace <= 0)
                {
                    roomIsFull = true;
                    break;
                }
            }
            if (roomIsFull)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volumeFreeSpace)} Cubic meters more.");
            }
            else
            {
                Console.WriteLine($"{volumeFreeSpace} Cubic meters left.");
            }
        }
    }
}