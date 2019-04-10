using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannedLibrary.Models
{
    public class MatchEntry
    {
        /// <summary>
        /// The unique identifier for the match entry
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The competing team
        /// </summary>
        public Team TeamCompeting { get; set; } //= new Team();
        /// <summary>
        /// The score of the team
        /// </summary>
        public string Score { get; set; }
        /// <summary>
        /// The previouse match of the team in the tournament
        /// </summary>
        public Match ParentMatch { get; set; }// = new Match();

        public string MatchEntryName()
        {
            
            if (this.TeamCompeting != null)
            {
                return $"{this.TeamCompeting.TeamName}";
            }
            else
            {
                return $"Winner of match {this.ParentMatch.Id}";
            }
            
        }
    }
}
