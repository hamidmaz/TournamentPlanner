using System.Collections.Generic;
namespace PlannedLibrary.Models
{
    public class Team
    {
        

        /// <summary>
        /// The unique identifier for the team
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Name of the team
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// List of the team players
        /// </summary>
        public List<Player> TeamMembers { get; set; } = new List<Player>();



        public Team(string teamName, List<Player> teamMembers)
            :this(0,teamName,teamMembers)
        {
        }
        public Team(int id, string teamName)
            :this(id, teamName, new List<Player>())
        {
        }

        public Team(int id, string teamName, List<Player> teamMembers)
        {
            this.Id = id;
            this.TeamName = teamName;
            this.TeamMembers = teamMembers;
        }

        public Team()
        {
        }
    }
}
