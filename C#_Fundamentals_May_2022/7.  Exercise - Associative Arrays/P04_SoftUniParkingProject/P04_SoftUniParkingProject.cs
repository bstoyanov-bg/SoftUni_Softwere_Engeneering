using System;
using System.Collections.Generic;

namespace P04_SoftUniParkingProject
{
    internal class P04_SoftUniParkingProject
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<string, string>();
            int numberOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfCommands; i++)
            {
                var command = Console.ReadLine().Split();
                var action = command[0];
                var username = command[1];

                switch (action)
                {
                    case "register":
                        var plateNumber = command[2];
                        if (CheckIfUsernameDoesntExist(users, username))
                        {
                            users.Add(username, plateNumber);
                            Console.WriteLine($"{username} registered {plateNumber} successfully");
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                        }
                        break;
                    case "unregister":
                        if (CheckIfUsernameDoesntExist(users, username))
                        {
                            Console.WriteLine($"ERROR: user {username} not found");
                        }
                        else
                        {
                            Console.WriteLine($"{username} unregistered successfully");
                            users.Remove(username);
                        }
                        break;
                }
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }

        static bool CheckIfUsernameDoesntExist(Dictionary<string, string> users, string name) => !users.ContainsKey(name);   
    }
}