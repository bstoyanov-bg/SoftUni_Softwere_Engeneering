using System;

namespace P03_ElevatorProject
{
    class P03_ElevatorProject
    {
        static void Main(string[] args)
        {
            int persons = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            double reminderCourses = (double)persons / capacity;

            Console.WriteLine(Math.Ceiling(reminderCourses));
        }
    }
}