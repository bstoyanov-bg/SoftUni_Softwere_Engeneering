using System;

namespace P01_NumberPyramid
{
    class P01_NumberPyramid
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int currentNum = 1;
            bool isBigger = false;

            for (int rows = 1; rows <= n; rows  ++)
            {
                for (int column = 1; column <= rows; column++)
                {
                    if (currentNum > n)
                    {
                        isBigger = true;
                        break;
                    }
                    Console.Write(currentNum + " ");
                    currentNum++;
                }
                if (isBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}