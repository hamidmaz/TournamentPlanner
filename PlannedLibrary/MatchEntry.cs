using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannedLibrary
{
    public class MatchEntry
    {
        /// <summary>
        /// The competing team
        /// </summary>
        public Team TeamCompeting { get; set; } = new Team();
        /// <summary>
        /// The score of the team
        /// </summary>
        public int Score { get; set; }
        /// <summary>
        /// The previouse match of the team in the tournament
        /// </summary>
        public Match ParentMatch { get; set; } = new Match();
    }
}
