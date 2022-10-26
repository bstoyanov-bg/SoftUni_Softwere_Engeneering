using System;
using System.Linq;

namespace P11_TriFunctionProject
{
    internal class P11_TriFunctionProject
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> checkName = (name, sum) => name.Sum(ch => ch) >= sum;

            Func<string[], int, Func<string, int, bool>, string> getFirstName = (names, sum, match) =>
            names.FirstOrDefault(names => match(names, sum));

            int sum = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(getFirstName(names, sum, checkName));
        }
    }
}