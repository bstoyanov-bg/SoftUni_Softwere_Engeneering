using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_TheVLoggerExam
{
    internal class P07_TheVLoggerExam
    {
        static void Main(string[] args)
        {
            List<Vlogger> vloggers = new List<Vlogger>();

            string command = Console.ReadLine();

            while (command != "Statistics")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[1];
                string vloggerName = tokens[0];
                string vloggerToFollowName = tokens[2];

                if (action == "joined")
                {
                    if (!vloggers.Any(x => x.Name == vloggerName))
                    {
                        vloggers.Add(new Vlogger(vloggerName));
                    }
                }
                else if (action == "followed")
                {
                    if (vloggerName == vloggerToFollowName
                        || !vloggers.Any(x => x.Name == vloggerName)
                        || !vloggers.Any(x => x.Name == vloggerToFollowName))
                    {
                        command = Console.ReadLine();
                        continue;
                    }

                    Vlogger vlogger = vloggers.Single(x => x.Name == vloggerName);
                    vlogger.Following.Add(vloggerToFollowName);

                    Vlogger vloggerToFollow = vloggers.Single(x => x.Name == vloggerToFollowName);
                    vloggerToFollow.Followers.Add(vloggerName);
                }

                command = Console.ReadLine();
            }

            vloggers = vloggers.OrderByDescending(x => x.Followers.Count)
                .ThenBy(x => x.Following.Count)
                .ToList();

            Console.WriteLine($"The V-Logger has a total of {vloggers.Count} vloggers in its logs.");

            int count = 1;

            foreach (var vlogger in vloggers)
            {
                Console.WriteLine($"{count}. {vlogger.Name} : {vlogger.Followers.Count} followers, {vlogger.Following.Count} following");

                if (count == 1)
                {
                    foreach (var follower in vlogger.Followers)
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                count++;
            }
        }
    }

    public class Vlogger
    {
        public Vlogger(string name)
        {
            Name = name;
            Followers = new SortedSet<string>();
            Following = new HashSet<string>();
        }

        public string Name { get; set; }

        public SortedSet<string> Followers { get; set; }

        public HashSet<string> Following { get; set; }
    }
}