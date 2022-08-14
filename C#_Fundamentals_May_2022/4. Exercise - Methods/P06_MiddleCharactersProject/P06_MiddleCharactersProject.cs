using System;

namespace P06_MiddleCharactersProject
{
    class P06_MiddleCharactersProject
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();

            PrintMiddleChar(inputText);
        }

        static void PrintMiddleChar(string inputText)
        {
            if (inputText.Length % 2 == 0)
            {
                Console.Write(inputText[inputText.Length / 2 - 1]);
                Console.WriteLine(inputText[inputText.Length / 2]);
            }
            else
            {
                Console.Write(inputText[inputText.Length / 2]);
            }
        }
    }
}