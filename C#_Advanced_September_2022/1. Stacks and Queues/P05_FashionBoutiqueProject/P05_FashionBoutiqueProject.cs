using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_FashionBoutiqueProject
{
    internal class P05_FashionBoutiqueProject
    {
        static void Main(string[] args)
        {
            int[] clothesInBox = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rackCapacity = int.Parse(Console.ReadLine());
            var stackClothes = new Stack<int>(clothesInBox);
            int count = clothesInBox.Length;
            int currSum = 0;
            int racks = 1;

            for (int i = 0; i < count; i++)
            {
                if (rackCapacity - currSum >= stackClothes.Peek())
                {
                    currSum += stackClothes.Pop();
                }
                else
                {
                    currSum = 0;
                    currSum += stackClothes.Pop();
                    racks++;
                }
            }

            Console.WriteLine(racks);
        }
    }
}