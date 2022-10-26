using System;
using System.Collections.Generic;

namespace P07_CompanyUsersProject
{
    internal class P07_CompanyUsersProject
    {
        static void Main(string[] args)
        {
            var companyInfo = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] commands = input.Split(" -> ");
                var companyName = commands[0];
                var employeeId = commands[1];

                if (!companyInfo.ContainsKey(companyName))
                {
                    companyInfo.Add(companyName, new List<string>());
                }

                if (companyInfo[companyName].Contains(employeeId))
                {
                    input = Console.ReadLine();
                    continue;
                }

                companyInfo[companyName].Add(employeeId);

                input = Console.ReadLine();
            }

            foreach (var company in companyInfo)
            {
                Console.WriteLine($"{company.Key}");
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}