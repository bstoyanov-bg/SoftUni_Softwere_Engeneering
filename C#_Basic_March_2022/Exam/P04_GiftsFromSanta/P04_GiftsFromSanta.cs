using System;

namespace P04_GiftsFromSanta
{
    class P04_GiftsFromSanta
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int s = int.Parse(Console.ReadLine());

            bool isEqual = false;

            for (int i = m; i >= n; i--)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    if (i != s)
                    {
                        Console.Write($"{i} ");
                    }
                    else 
                    {
                        isEqual = true;
                        break;
                    }
                }
                if (isEqual == true)
                {
                    break;
                }
            }
        }
    }
}