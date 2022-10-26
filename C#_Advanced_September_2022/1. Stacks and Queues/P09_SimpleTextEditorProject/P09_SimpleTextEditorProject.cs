using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P09_SimpleTextEditorProject
{
    internal class P09_SimpleTextEditorProject
    {
        static void Main(string[] args)
        {
            int numOfOperations = int.Parse(Console.ReadLine());

            var memory = new Stack<string>();
            memory.Push(String.Empty);
            StringBuilder text = new StringBuilder();

            for (int i = 0; i < numOfOperations; i++)
            {
                string[] input = Console.ReadLine()
                    .Split();

                string action = input[0].ToString();

                if (action == "1")
                {
                    string textToAdd = input[1];
                    text.Append(textToAdd);
                    memory.Push(text.ToString());
                }
                else if (action == "2")
                {
                    int charToRemove = int.Parse(input[1]);
                    if (charToRemove <= text.Length)
                    {
                        text.Remove(text.Length - charToRemove, charToRemove);
                        memory.Push(text.ToString());
                    }
                }
                else if (action == "3")
                {
                    int index = int.Parse(input[1]);
                    if (index >= 0 & index <= text.Length)
                    {
                        Console.WriteLine(text[index - 1]);
                    }
                }
                else if (action == "4")
                {
                    memory.Pop();
                    string previousVersion = memory.Peek();

                    text = new StringBuilder(previousVersion);
                }
            }
        }
    }
}