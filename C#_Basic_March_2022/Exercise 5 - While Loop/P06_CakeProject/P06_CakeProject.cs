using System;

namespace P06_CakeProject
{
    class P06_CakeProject
    {
        static void Main()
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());

            int cakeArea = width * lenght;

            string command = "";

            bool cakeIsFinished = false;

            while (true)
            {
                command = Console.ReadLine();

                if (command == "STOP")
                {
                    break;
                }

                int pieces = int.Parse(command);

                cakeArea -= pieces;

                if (cakeArea <= 0)
                {
                    cakeIsFinished = true;
                    break;
                }
            }
            if (cakeIsFinished)
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cakeArea)} pieces more.");
            }
            else 
            {
                Console.WriteLine($"{cakeArea} pieces are left.");
            }
        }
    }
}