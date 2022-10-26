using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_TeamworkProjectsProject
{
    class P05_TeamworkProjectsProject
    {
        static void Main(string[] args)
        {
            int teamsToRegisterCount = int.Parse(Console.ReadLine());
            var teams = new List<Team>();

            for (int i = 0; i < teamsToRegisterCount; i++)
            {
                string[] currTeamInfo = Console.ReadLine().Split("-");
                string creator = currTeamInfo[0];
                string teamName = currTeamInfo[1];

                if (teams.Any(team => team.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} was already created!");
                }
                else if (teams.Any(team => team.Creator == creator))
                {
                    Console.WriteLine($"{creator} cannot create another team!");
                }
                else
                {
                    var team = new Team();
                    team.TeamName = teamName;
                    team.Creator = creator;
                    team.Members = new List<string>();
                    teams.Add(team);
                    Console.WriteLine($"Team {team.TeamName} has been created by {team.Creator}!");
                }
            }

            string line = Console.ReadLine();

            while (line != "end of assignment")
            {
                var memberInfo = line.Split(new string[] { "->" }, StringSplitOptions.None);
                var user = memberInfo[0];
                var teamToJoin = memberInfo[1];

                if (teams.All(team => team.TeamName != teamToJoin))
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }

                else if (teams.Any(team => team.Members.Contains(user) || teams.Any(creator => creator.Creator == user)))
                {
                    Console.WriteLine($"Member {user} cannot join team {teamToJoin}!");
                }
                else
                {
                    var currentTeam = teams.Find(team => team.TeamName == teamToJoin);
                    currentTeam.Members.Add(user);
                }

                line = Console.ReadLine();
            }

            var completedTeams = teams.Where(x => x.Members.Count > 0);
            var disbannedTeams = teams.Where(team => team.Members.Count == 0);

            foreach (var team in completedTeams.OrderByDescending(x => x.Members.Count).ThenBy(y => y.TeamName))
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.Creator}");
                foreach (var member in team.Members.OrderBy(x => x))
                {
                Console.WriteLine($"-- {member}");
                }
            }

            Console.WriteLine($"Teams to disband:");
                foreach (var disbanedTeam in disbannedTeams.OrderBy(x => x.TeamName))
                {
                    Console.WriteLine($"{disbanedTeam.TeamName}");
                }
        }
    }

    class Team
    {
        public string TeamName { get; set; }
        public string Creator { get; set; }
        public List<string> Members { get; set; }
    }
}