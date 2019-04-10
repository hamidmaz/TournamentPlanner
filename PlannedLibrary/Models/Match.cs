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
        /// The unique identifier for the match
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// List of the match entries
        /// </summary>
        public List<MatchEntry> Entries { get; set; } = new List<MatchEntry>();
        /// <summary>
        /// The winner of the match
        /// </summary>
        public Team Winner { get; set; }// = new Team();
        /// <summary>
        /// The round that the match belongs to
        /// </summary>
        public int Round { get; set; }

        public string FullMatchName
        {
            get
            {
                if (this.Entries.Count > 1)
                {
                    return $"{this.Id}. {this.Entries[0].MatchEntryName()} vs. {this.Entries[1].MatchEntryName()}";
                }
                else
                {
                    return $"{this.Id}. {this.Entries[0].MatchEntryName()} vs. BYE";
                }
            }
        }
    }
}
