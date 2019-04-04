using PlannedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannedLibrary.DataAccess
{
    public interface IDataConnection
    {
        /// <summary>
        /// It save the input prize and pass it with an Id populated for it
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Prize CreatePrize(Prize model);
        Player CreatePlayer(Player model);
        Team CreateTeam(Team model);
        List<Player> GetPeople_All();
        
    }
}
