using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Gosho";
            person.Age = 15;

            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}