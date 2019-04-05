using System.Collections.Generic;

namespace PlannedLibrary.Models
{
    public class Tournament
    {
        public int Id { get; set; }
        public string TournamentName { get; set; }
        public decimal EntryFee { get; set; }

        public List<Team> Teams { get; set; } = new List<Team>();
        public List<List<Match>> Rounds { get; set; } = new List<List<Match>>();
        public List<Prize> Prizes { get; set; } = new List<Prize>();

        public void ArrangeMatchups()
        {

        }

    }
}
