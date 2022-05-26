using System;

namespace P03_Histogram
{
    class P03_Histogram
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int between1and199 = 0;
            int between200and399 = 0;
            int between400and599 = 0;
            int between600and799 = 0;
            int moreThan800 = 0;

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num >= 1 && num <= 199)
                {
                    between1and199++;
                }
                else if (num >= 200 && num <= 399)
                {
                    between200and399++;
                }
                else if (num >= 400 && num <= 599)
                {
                    between400and599++;
                }
                else if (num >= 600 && num <= 799)
                {
                    between600and799++;
                }
                else
                {
                    moreThan800++;
                }
            }
            double p1 = between1and199 / (double)n * 100;
            double p2 = between200and399 / (double)n * 100;
            double p3 = between400and599 / (double)n * 100;
            double p4 = between600and799 / (double)n * 100;
            double p5 = moreThan800 / (double)n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}