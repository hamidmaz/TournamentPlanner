using PlannedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannerUI
{
    /// <summary>
    /// each winfrom impelement this IF can call the prize model form
    /// and get back the new created prize
    /// </summary>
    public interface IPrizeRequestor
    {
        void PrizeComplete(Prize model);
    }
}
