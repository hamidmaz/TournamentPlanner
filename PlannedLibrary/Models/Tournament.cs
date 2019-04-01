using System.Collections.Generic;

namespace PlannedLibrary.Models
{
    public class Tournament
    {
        public string TournomentName { get; set; }
        public decimal EntryFee { get; set; }

        public List<Team> Teams { get; set; } = new List<Team>();
        public List<List<Match>> Rounds { get; set; } = new List<List<Match>>();
        public List<Prize> Prizes { get; set; } = new List<Prize>();

    }
}
