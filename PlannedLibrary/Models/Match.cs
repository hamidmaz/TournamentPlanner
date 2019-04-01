using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannedLibrary.Models
{
    public class Match
    {
        /// <summary>
        /// List of the match entries
        /// </summary>
        public List<MatchEntry> Entries { get; set; } = new List<MatchEntry>();
        /// <summary>
        /// The winner of the match
        /// </summary>
        public Team Winner { get; set; } = new Team();
        /// <summary>
        /// The round that the match belongs to
        /// </summary>
        public int Round { get; set; }
    }
}
