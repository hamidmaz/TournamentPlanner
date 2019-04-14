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
        void CreatePrize(Prize model);

        void CreatePlayer(Player model);
        void CreateTeam(Team model);
        void CreateTournament(Tournament model);

        List<Player> GetPeople_All();
        List<Team> GetTeams_All();
        
        /// <summary>
        /// return a list of tournaments with only their names and ids
        /// </summary>
        /// <returns></returns>
        List<Tournament> GetTournaments_List();

        Tournament GetTournamentInfo(Tournament tournament);

        void UpdateMatch(Match model);



    }
}
