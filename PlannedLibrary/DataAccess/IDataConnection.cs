﻿using PlannedLibrary.Models;
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
        Tournament CreateTournament(Tournament model);

        List<Player> GetPeople_All();
        List<Team> GetTeams_All();
        
        /// <summary>
        /// return a list of tournaments with only their names and ids
        /// </summary>
        /// <returns></returns>
        List<Tournament> GetTournament_All();


        void UpdateMatch(Match model);



    }
}
