using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_StudentsProject
{
    class P04_StudentsProject
    {
        static void Main(string[] args)
        {
            int numOfStudents = int.Parse(Console.ReadLine());
            List<Student> students = new List<Student>();

            for (int i = 0; i < numOfStudents; i++)
            {
                string[] studentInfo = Console.ReadLine().Split();
                var student = new Student(studentInfo[0], studentInfo[1], float.Parse(studentInfo[2]));
                students.Add(student);
            }

            students = students.OrderByDescending(currentStudent => currentStudent.Grade).ToList();

            foreach (var student in students)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:f2}");
            }
        }
    }

    class Student
    {
        public Student(string firstName, string lastName, float grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Grade { get; set; }

    }
}