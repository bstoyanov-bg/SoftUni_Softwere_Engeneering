using System;
using System.Linq;

namespace P03_ExtractFileProject
{
    internal class P03_ExtractFileProject
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine().Split("\\").Last<string>();

            string[] lastIndex = path.Split(".");

            Console.WriteLine($"File name: {lastIndex[0]}");
            Console.WriteLine($"File extension: {lastIndex[1]}");
        }
    }
}