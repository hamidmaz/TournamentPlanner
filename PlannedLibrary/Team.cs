using System.Collections.Generic;
namespace PlannedLibrary
{
    public class Team
    {
        /// <summary>
        /// Name of the team
        /// </summary>
        public string TeamName { get; set; }
        /// <summary>
        /// List of the team players
        /// </summary>
        public List<Player> TeamMembers { get; set; } = new List<Player>();
    }
}
