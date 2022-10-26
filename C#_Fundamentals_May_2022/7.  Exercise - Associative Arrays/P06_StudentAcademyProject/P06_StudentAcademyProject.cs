using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_StudentAcademyProject
{
    internal class P06_StudentAcademyProject
    {
        static void Main(string[] args)
        {
            int readNumber = int.Parse(Console.ReadLine());
            var students = new Dictionary<string, List<double>>();

            for (int i = 0; i < readNumber; i++)
            {
                string studentName = Console.ReadLine();
                double studentGrade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students[studentName] = new List<double>();
                }

                students[studentName].Add(studentGrade);
            }

            foreach (var student in students)
            {
                string studentName = student.Key;
                double studentAvgGrade = student.Value.Average();
                
                if (studentAvgGrade >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {studentAvgGrade:f2}");
                }
            }
        }
    }
}