using PlannedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerUI
{
    /// <summary>
    /// each winfrom impelement this IF can call the create tournament form and get a new tournament
    /// and get back the new created prize
    /// </summary>
    public interface ITournamentRequestor
    {
        void TournamentComplete(Tournament model);
    }
}
