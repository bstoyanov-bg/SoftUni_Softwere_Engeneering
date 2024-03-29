﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_OrderByAgeProject
{
    class P07_OrderByAgeProject
    {
        static void Main(string[] args)
        {
            string[] commands = Console.ReadLine().Split();
            List<Person> personsList = new List<Person>();

            while (commands[0] != "End")
            {
                var person = new Person(commands[0], commands[1], int.Parse(commands[2]));
                personsList.Add(person);
                commands = Console.ReadLine().Split();
            }

            //personsList
            //    .OrderBy(person => person.Age)
            //    .ToList()
            //    .ForEach(person => Console.WriteLine(person));

            foreach (var person in personsList.OrderBy(person => person.Age))
            {
                Console.WriteLine($"{person}");
            }
        }
    }

    class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            Id = id;
            Age = age;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }

        public override string ToString() => ($"{Name} with ID: {Id} is {Age} years old.");
    }
}