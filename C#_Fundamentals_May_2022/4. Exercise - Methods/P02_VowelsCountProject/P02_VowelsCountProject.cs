using System;
using System.Linq;

namespace P02_VowelsCountProject
{
    class P02_VowelsCountProject
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine().ToLower();

            SearchForVoweles(inputText);
        }

        static void SearchForVoweles(string text)
        {
            Console.WriteLine(text.Count(voweles => "aouei".Contains(voweles)));
        }
    }
}