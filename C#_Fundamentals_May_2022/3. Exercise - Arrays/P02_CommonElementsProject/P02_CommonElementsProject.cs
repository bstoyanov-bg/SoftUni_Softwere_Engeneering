using System;

namespace P02_CommonElementsProject
{
    class P02_CommonElementsProject
    {
        static void Main(string[] args)
        {
            string[] arrayOne = Console.ReadLine().Split(' ');
            string[] arrayTwo = Console.ReadLine().Split(' ');

            foreach (string secondCurrentElement in arrayTwo)
            {
                for (int i = 0; i < arrayOne.Length; i++)
                {
                    string currentElement = arrayOne[i];
                    if (currentElement == secondCurrentElement)
                    {
                        Console.Write($"{currentElement} ");
                        break;
                    }
                }
            }
        }
    }
}