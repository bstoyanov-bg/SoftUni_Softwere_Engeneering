﻿using System;

namespace P06_StrongNumberProject
{
    class P06_StrongNumberProject
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int numberCopy = number;
            int sum = 0;

            while (number > 0)
            {
                int factorialNumber = 1;
                int currentNumber = number % 10;
                number /= 10;

                for (int i = 2; i <= currentNumber; i++)
                {
                    factorialNumber *= i;
                }

                sum += factorialNumber;
            }

            Console.WriteLine(sum == numberCopy ? "yes": "no");
        }
    }
}