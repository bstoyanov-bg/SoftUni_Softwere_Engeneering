using System;
using System.Linq;

namespace P04_ArrayRotationProject
{
    class P04_ArrayRotationProject
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rotations = int.Parse(Console.ReadLine());

            for (int rotation = 0; rotation < rotations ; rotation++)
            {
                int tempElemrnt = array[0];

                for (int operations = 0; operations < array.Length - 1; operations++)
                {
                    array[operations] = array[operations + 1];
                }

                array[array.Length - 1] = tempElemrnt;
            }

            Console.WriteLine(string.Join(" ", array));
        }
    }
}