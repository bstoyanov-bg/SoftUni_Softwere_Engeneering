using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}