using PlannedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerUI
{
    public interface ITeamRequestor
    {
        void TeamComplete(Team model);
    }
}
