﻿using Dapper;
using PlannedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannedLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        //Attention, this class was developed based on a tutorial for Microsoft SQL server but
        //never tested here. Instead, I used PostgreSQLConnector.cs

        /// <summary>
        /// Save the new prize to the database and pass it with its unique identifier
        /// </summary>
        /// <param name="model"> The new prize</param>
        /// <returns> The prize with a unique identifier</returns>
        public void CreatePrize(Prize model)
        {
            //using this using block! avoid any memory link since
            // it close the connection at the end and do not keep 
            // it if eg. an exception happens
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("TournamentsSQL")))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.Amount);
                p.Add("@PrizePercentage", model.Percentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("db.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }

        public void CreatePlayer(Player model)
        {
            throw new NotImplementedException();
        }

        public List<Player> GetPeople_All()
        {
            throw new NotImplementedException();
        }

        public void CreateTeam(Team model)
        {
            throw new NotImplementedException();
        }

        public List<Team> GetTeams_All()
        {
            throw new NotImplementedException();
        }

        public void CreateTournament(Tournament model)
        {
            throw new NotImplementedException();
        }

        public List<Tournament> GetTournaments_List()
        {
            throw new NotImplementedException();
        }

        public void UpdateMatch(Match model)
        {
            throw new NotImplementedException();
        }

        public Tournament GetTournamentInfo(Tournament selectedTournament)
        {
            throw new NotImplementedException();
        }
    }
}
