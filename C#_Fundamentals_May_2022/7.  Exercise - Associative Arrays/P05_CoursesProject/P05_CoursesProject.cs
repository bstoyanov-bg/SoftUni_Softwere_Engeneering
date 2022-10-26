using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_CoursesProject
{
    internal class P05_CoursesProject
    {
        static void Main(string[] args)
        {
            var courses = new Dictionary<string, List<string>>();
            string input = Console.ReadLine();

            while (input != "end")
            {
                string[] action = input.Split(" : ");
                string courseName = action[0];
                string studentName = action[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses[courseName] = new List<string>();
                }

                courses[courseName].Add(studentName);


                input = Console.ReadLine();
            }

            PrintCourseInfo(courses);
        }

        private static void PrintCourseInfo(Dictionary<string, List<string>> courses)
        {
            foreach (var course in courses)
            {
                string courseName = course.Key;
                var studentNames = course.Value;

                Console.WriteLine($"{courseName}: {studentNames.Count}");
                foreach (var student in studentNames)
                {
                Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}