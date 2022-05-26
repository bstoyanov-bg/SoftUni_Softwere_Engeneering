using System;

namespace P03_SumPrimeNonPrime
{
    class P03_SumPrimeNonPrime
    {
        static void Main()
        {
            string command = "";

            int primesSum = 0;
            int compoundSum = 0;

            while (command != "stop")
            {
                command = Console.ReadLine();

                if (command == "stop")
                {
                    break;
                }

                int num = int.Parse(command);

                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    continue;
                }

                bool isPrime = true;

                for (int divider = 2; divider < num; divider++)
                {
                    int remainder = num % divider;

                    if (remainder == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    primesSum += num;
                }
                else
                {
                    compoundSum += num;
                }
            }

            Console.WriteLine($"Sum of all prime numbers is: {primesSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {compoundSum}");
        }
    }
}