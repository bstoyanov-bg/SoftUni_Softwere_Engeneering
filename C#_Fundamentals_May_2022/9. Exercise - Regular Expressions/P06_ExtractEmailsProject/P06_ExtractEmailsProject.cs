using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace P06_ExtractEmailsProject
{
    internal class P06_ExtractEmailsProject
    {
        static void Main(string[] args)
        {
            string pattern = @"(^|\s)[A-Za-z0-9][\w*\-\.]*[A-Za-z0-9]@[A-Za-z]+([.-][A-Za-z]+)+\b";

            string input = Console.ReadLine();

            MatchCollection mateches = Regex.Matches(input, pattern);
            mateches.ToList().ForEach(Console.WriteLine);
        }
    }
}