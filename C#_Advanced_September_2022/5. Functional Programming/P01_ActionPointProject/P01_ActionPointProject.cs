using System;
using System.Linq;

namespace P01_ActionPointProject
{
    internal class P01_ActionPointProject
    {
        static void Main(string[] args)
        {
            Action<string[]> print = strings => Console.WriteLine(string.Join(Environment.NewLine, strings));

            string[] strings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            print(strings);
        }
    }
}
