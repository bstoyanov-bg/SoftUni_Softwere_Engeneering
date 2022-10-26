using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_CompanyRosterMore
{
    internal class P01_CompanyRosterMore
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            List<Employee> listOfEmployees = new List<Employee>();

            for (int i = 0; i < number; i++)
            {
                string[] employeeInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = employeeInfo[0];
                double salary = double.Parse(employeeInfo[1]);
                string department = employeeInfo[2];

                Employee newEmployee = new Employee();

                newEmployee.Name = name;
                newEmployee.Salary = salary;
                newEmployee.Department = department;

                listOfEmployees.Add(newEmployee);
            }

            listOfEmployees = listOfEmployees.OrderBy(x => x.Department).ToList();

            var departments = new Dictionary<string, List<double>>();

            for (int i = 0; i < listOfEmployees.Count; i++)
            {
                string newDepartment = listOfEmployees[i].Department;
                double newSalary = listOfEmployees[i].Salary;

                if (!departments.ContainsKey(newDepartment))
                {
                    departments[newDepartment] = new List<double>();
                }

                departments[newDepartment].Add(newSalary);
            }

            string departmentMaxAverage = departments.OrderByDescending(x => x.Value.Average()).First().Key;
            
            listOfEmployees = listOfEmployees
                .Where(x => x.Department == departmentMaxAverage)
                .OrderByDescending(x => x.Salary)
                .ToList();

            Console.WriteLine($"Highest Average Salary: {departmentMaxAverage}");

            foreach (var person in listOfEmployees)
            {
                Console.WriteLine($"{person.Name} {person.Salary:f2}");
            }
        }
    }
    class Employee
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}