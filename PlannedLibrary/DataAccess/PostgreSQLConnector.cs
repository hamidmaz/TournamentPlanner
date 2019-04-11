using Dapper;
using Npgsql;
using PlannedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannedLibrary.DataAccess
{
    public class PostgreSQLConnector: IDataConnection
    {
        // TODO put this in app.config file, search how to avoid writing user and pass
        private static string CnnString = "Host=localhost;Username=postgres;Password=hamidma1367;Database=Tournaments";

        /// <summary>
        /// Save the new prize to the database and pass it with its unique identifier
        /// </summary>
        /// <param name="model"> The new prize</param>
        /// <returns> The prize with a unique identifier</returns>
        public Prize CreatePrize(Prize model)
        {

            using (var connection = new NpgsqlConnection(CnnString))
            {
                
                connection.Open();
                // Start a transaction as it is required to work with result sets (cursors) in PostgreSQL
                NpgsqlTransaction tran = connection.BeginTransaction();

                // Define a command to call the PostgreSQL function
                // This code works with PostgreSQL functions not procedures
                NpgsqlCommand command = new NpgsqlCommand("\"spPrizes_Insert\"", connection);


                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("PlaceNumber", model.PlaceNumber);
                command.Parameters.AddWithValue("PlaceName", model.PlaceName);
                command.Parameters.AddWithValue("PrizeAmount", model.Amount);
                command.Parameters.AddWithValue("PrizePercentage", model.Percentage);


                // Execute the procedure and obtain a result set
                //NpgsqlDataReader dr = command.ExecuteReader();
                // if it returns a single value, use ExecuteScalar!
                int newId = Convert.ToInt32(command.ExecuteScalar());

                tran.Commit();
                connection.Close();

                model.Id = newId;
            }

            return model;


        }

        public Player CreatePlayer(Player model)
        {
            using (var connection = new NpgsqlConnection(CnnString))
            {

                connection.Open();
                // Start a transaction as it is required to work with result sets (cursors) in PostgreSQL
                NpgsqlTransaction tran = connection.BeginTransaction();

                // Define a command to call the PostgreSQL function
                // This code works with PostgreSQL functions not procedures
                NpgsqlCommand command = new NpgsqlCommand("\"spPeople_Insert\"", connection);


                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("FirstName", model.FirstName);
                command.Parameters.AddWithValue("LastName", model.LastName);
                command.Parameters.AddWithValue("EmailAddress", model.EmailAddress);
                command.Parameters.AddWithValue("CellphoneNumber", model.CellphoneNr);


                // Execute the procedure and obtain a result set
                //NpgsqlDataReader dr = command.ExecuteReader();
                // if it returns a single value, use ExecuteScalar!
                int newId = Convert.ToInt32(command.ExecuteScalar());

                tran.Commit();
                connection.Close();

                model.Id = newId;
            }
            return model;
        }
        public List<Player> GetPeople_All()
        {
            List<Player> outputList = new List<Player>();

            using (var connection = new NpgsqlConnection(CnnString))
            {
                connection.Open();
                // Start a transaction as it is required to work with result sets (cursors) in PostgreSQL
                //NpgsqlTransaction tran = connection.BeginTransaction();

                // Define a command to call the PostgreSQL function
                // This code works with PostgreSQL functions not procedures
                NpgsqlCommand command = new NpgsqlCommand("\"spPeople_GetAll\"", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Execute the procedure and obtain a result set
                NpgsqlDataReader dr = command.ExecuteReader();

                // Output rows 
                while (dr.Read())
                {
                    outputList.Add(new Player(
                        Convert.ToInt32(dr[0]),
                        Convert.ToString(dr[1]),
                        Convert.ToString(dr[2]),
                        Convert.ToString(dr[3]),
                        Convert.ToString(dr[4])));
                }
                
                //tran.Commit();
                connection.Close();
            }

            return outputList;
        }

        public Team CreateTeam(Team model)
        {
            using (var connection = new NpgsqlConnection(CnnString))
            {

                connection.Open();
                // Start a transaction as it is required to work with result sets (cursors) in PostgreSQL
                NpgsqlTransaction tran = connection.BeginTransaction();

                // Define a command to call the PostgreSQL function
                // This code works with PostgreSQL functions not procedures
                NpgsqlCommand command = new NpgsqlCommand("\"spTeam_Insert\"", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("TeamName", model.TeamName);

                // Execute the procedure and obtain a result set
                //NpgsqlDataReader dr = command.ExecuteReader();
                // if it returns a single value, use ExecuteScalar!
                int newId = Convert.ToInt32(command.ExecuteScalar());

                tran.Commit();
                connection.Close();

                model.Id = newId;
            }
            

            using (var connection = new NpgsqlConnection(CnnString))
            {

                connection.Open();
                // Start a transaction as it is required to work with result sets (cursors) in PostgreSQL
                NpgsqlTransaction tran = connection.BeginTransaction();

                // Define a command to call the PostgreSQL function
                // This code works with PostgreSQL functions not procedures
                NpgsqlCommand command = new NpgsqlCommand("\"spTeamMembers_Insert\"", connection);

                command.CommandType = CommandType.StoredProcedure;

                int newId = 0;
                foreach (Player p in model.TeamMembers)
                {
                    // Since we are using command in a loop, we need to remove the prev. parameters each time
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("TeamId", model.Id);
                    command.Parameters.AddWithValue("PersonId", p.Id);
                    

                    // Execute the procedure and obtain a result set
                    //NpgsqlDataReader dr = command.ExecuteReader();
                    // if it returns a single value, use ExecuteScalar!
                    newId = Convert.ToInt32(command.ExecuteScalar());
                    p.Id = newId;
                }
                

                tran.Commit();
                connection.Close();

                
            }
            return model;
        }
        public List<Team> GetTeams_All()
        {
            List<Team> outputList = new List<Team>();

            using (var connection = new NpgsqlConnection(CnnString))
            {
                connection.Open();
                // Start a transaction as it is required to work with result sets (cursors) in PostgreSQL
                //NpgsqlTransaction tran = connection.BeginTransaction();

                // Define a command to call the PostgreSQL function
                // This code works with PostgreSQL functions not procedures
                NpgsqlCommand command = new NpgsqlCommand("\"spTeams_GetAll\"", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Execute the procedure and obtain a result set
                NpgsqlDataReader dr = command.ExecuteReader();

                // Output rows 
                while (dr.Read())
                {
                    outputList.Add(new Team(
                        Convert.ToInt32(dr[0]),
                        Convert.ToString(dr[1])));
                }

                //tran.Commit();
                connection.Close();
            }

            foreach (Team team in outputList)
            {
                using (var connection = new NpgsqlConnection(CnnString))
                {
                    connection.Open();
                    // Start a transaction as it is required to work with result sets (cursors) in PostgreSQL
                    //NpgsqlTransaction tran = connection.BeginTransaction();

                    // Define a command to call the PostgreSQL function
                    // This code works with PostgreSQL functions not procedures
                    NpgsqlCommand command = new NpgsqlCommand("\"spPeople_GetByTeam\"", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("teamId", team.Id);
                    // Execute the procedure and obtain a result set
                    NpgsqlDataReader dr = command.ExecuteReader();

                    // Output rows 

                    while (dr.Read())
                    {
                        team.TeamMembers.Add(new Player(
                            Convert.ToInt32(dr[0]),
                            Convert.ToString(dr[1]),
                            Convert.ToString(dr[2]),
                            Convert.ToString(dr[3]),
                            Convert.ToString(dr[4])));
                    }
                    connection.Close();
                }
            }
            return outputList;
        }


        public Tournament CreateTournament(Tournament model)
        {

            // put tournament in the database
            SaveTournament(model);
            // purt prizes in the tournament
            SaveTournamentPrizes(model);
            // put all the tournament entries (teams) in the database
            SaveTournamentEntries(model);
            // put all the matches in the database
            SaveTournamentRounds(model);
            return model;
        }

        private void SaveTournament(Tournament model)
        {
            using (var connection = new NpgsqlConnection(CnnString))
            {

                connection.Open();
                // Start a transaction as it is required to work with result sets (cursors) in PostgreSQL
                NpgsqlTransaction tran = connection.BeginTransaction();

                // Define a command to call the PostgreSQL function
                // This code works with PostgreSQL functions not procedures
                NpgsqlCommand command = new NpgsqlCommand("\"spTournament_Insert\"", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("TournamentName", model.TournamentName);
                command.Parameters.AddWithValue("EntryFee", model.EntryFee);

                // Execute the procedure and obtain a result set
                //NpgsqlDataReader dr = command.ExecuteReader();
                // if it returns a single value, use ExecuteScalar!
                int newId = Convert.ToInt32(command.ExecuteScalar());

                tran.Commit();
                connection.Close();

                model.Id = newId;
            }
        }
        private void SaveTournamentPrizes(Tournament model)
        {
            using (var connection = new NpgsqlConnection(CnnString))
            {

                connection.Open();
                // Start a transaction as it is required to work with result sets (cursors) in PostgreSQL
                NpgsqlTransaction tran = connection.BeginTransaction();

                // Define a command to call the PostgreSQL function
                // This code works with PostgreSQL functions not procedures
                NpgsqlCommand command = new NpgsqlCommand("\"spTournamentPrizes_Insert\"", connection);

                command.CommandType = CommandType.StoredProcedure;

                int newId = 0;
                foreach (Prize p in model.Prizes)
                {
                    // Since we are using command in a loop, we need to remove the prev. parameters each time
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("TournamentId", model.Id);
                    command.Parameters.AddWithValue("PrizeId", p.Id);


                    // Execute the procedure and obtain a result set
                    //NpgsqlDataReader dr = command.ExecuteReader();
                    // if it returns a single value, use ExecuteScalar!
                    newId = Convert.ToInt32(command.ExecuteScalar());
                    //p.Id = newId;
                }


                tran.Commit();
                connection.Close();


            }
        }
        private void SaveTournamentEntries(Tournament model)
        {
            using (var connection = new NpgsqlConnection(CnnString))
            {

                connection.Open();
                // Start a transaction as it is required to work with result sets (cursors) in PostgreSQL
                NpgsqlTransaction tran = connection.BeginTransaction();

                // Define a command to call the PostgreSQL function
                // This code works with PostgreSQL functions not procedures
                NpgsqlCommand command = new NpgsqlCommand("\"spTournamentEntry_Insert\"", connection);

                command.CommandType = CommandType.StoredProcedure;

                int newId = 0;
                foreach (Team t in model.Teams)
                {
                    // Since we are using command in a loop, we need to remove the prev. parameters each time
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("TournamentId", model.Id);
                    command.Parameters.AddWithValue("TeamId", t.Id);


                    // Execute the procedure and obtain a result set
                    //NpgsqlDataReader dr = command.ExecuteReader();
                    // if it returns a single value, use ExecuteScalar!
                    newId = Convert.ToInt32(command.ExecuteScalar());
                    //t.Id = newId;
                }


                tran.Commit();
                connection.Close();


            }
        }
        private void SaveTournamentRounds(Tournament model)
        {
            using (var connection = new NpgsqlConnection(CnnString))
            {

                connection.Open();
                // Start a transaction as it is required to work with result sets (cursors) in PostgreSQL
                NpgsqlTransaction tran = connection.BeginTransaction();

                // Define a command to call the PostgreSQL function
                // This code works with PostgreSQL functions not procedures
                NpgsqlCommand command = new NpgsqlCommand("\"spMatch_Insert\"", connection);
                command.CommandType = CommandType.StoredProcedure;

                NpgsqlCommand command2 = new NpgsqlCommand("\"spMatchEntry_Insert\"", connection);
                command2.CommandType = CommandType.StoredProcedure;

                int newMatchId = 0;
                int newMatchEntryId = 0;
                int counter = 1;

                foreach (List<Match> round in model.Rounds)
                {
                    foreach (Match m in round)
                    {
                        // Since we are using command in a loop, we need to remove the prev. parameters each time
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("TournamentId", model.Id);
                        command.Parameters.AddWithValue("MatchRound", m.Round);

                        // Execute the procedure and obtain a result set
                        //NpgsqlDataReader dr = command.ExecuteReader();
                        // if it returns a single value, use ExecuteScalar!
                        newMatchId = Convert.ToInt32(command.ExecuteScalar());
                        m.Id = newMatchId;
                        //tran.Commit();
                        foreach (MatchEntry mEntry in m.Entries)
                        {
                            command2.Parameters.Clear();
                            command2.Parameters.AddWithValue("MatchId", m.Id);
                            if (mEntry.ParentMatch != null)
                            {
                                command2.Parameters.AddWithValue("ParentMatchId", mEntry.ParentMatch.Id);
                            }
                            else
                            {
                                // send DBNull.Value instead of null, otherwise Npgsql throw an exception
                                command2.Parameters.AddWithValue("ParentMatchId", DBNull.Value);
                            }
                            if (mEntry.TeamCompeting != null)
                            {
                                command2.Parameters.AddWithValue("TeamCompetingId", mEntry.TeamCompeting.Id);
                            }
                            else
                            {
                                // send DBNull.Value instead of null, otherwise Npgsql throw an exception
                                command2.Parameters.AddWithValue("TeamCompetingId", DBNull.Value);
                            }

                            // Execute the procedure and obtain a result set
                            //NpgsqlDataReader dr = command.ExecuteReader();
                            // if it returns a single value, use ExecuteScalar!
                            newMatchEntryId = Convert.ToInt32(command2.ExecuteScalar());
                            mEntry.Id = newMatchEntryId;
                            //tran.Commit();
                        }
                    counter++;
                    }
                }

                tran.Commit();
                connection.Close();


            }
        }

        public List<Tournament> GetTournament_All()
        {
            List<Tournament> outputList = new List<Tournament>();

            using (var connection = new NpgsqlConnection(CnnString))
            {
                connection.Open();
                // Start a transaction as it is required to work with result sets (cursors) in PostgreSQL
                //NpgsqlTransaction tran = connection.BeginTransaction();

                // Define a command to call the PostgreSQL function
                // This code works with PostgreSQL functions not procedures
                NpgsqlCommand command = new NpgsqlCommand("\"spTournaments_GetAll\"", connection);
                command.CommandType = CommandType.StoredProcedure;

                // Execute the procedure and obtain a result set
                NpgsqlDataReader dr = command.ExecuteReader();

                // Output rows 
                while (dr.Read())
                {
                    // check if the tournament is active or not
                    if (Convert.ToBoolean(dr[3]))
                    {
                        outputList.Add(new Tournament(
                        Convert.ToInt32(dr[0]),
                        Convert.ToString(dr[1])));
                    }
                }

                //tran.Commit();
                connection.Close();
            }

            return outputList;
        }


        public void UpdateMatch(Match model)
        {
            using (var connection = new NpgsqlConnection(CnnString))
            {
                // TODO not tested yet, first need to implement complete tournamnet in SQL
                connection.Open();
                // Start a transaction as it is required to work with result sets (cursors) in PostgreSQL
                NpgsqlTransaction tran = connection.BeginTransaction();

                // Define a command to call the PostgreSQL function
                // This code works with PostgreSQL functions not procedures
                NpgsqlCommand command = new NpgsqlCommand("\"spMatches_Update\"", connection);

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.AddWithValue("Id", model.Id);
                command.Parameters.AddWithValue("WinnerId", model.Winner);

                // Execute the procedure and obtain a result set
                //NpgsqlDataReader dr = command.ExecuteReader();
                // if it returns a single value, use ExecuteScalar!
                command.ExecuteScalar();

                command = new NpgsqlCommand("\"spMatchEntries_Update\"", connection);

                command.CommandType = CommandType.StoredProcedure;

                foreach (MatchEntry mEntry in model.Entries)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("Id", mEntry.Id);
                    command.Parameters.AddWithValue("Score", mEntry.Score);
                    command.Parameters.AddWithValue("TeamCompetingId", mEntry.TeamCompeting.Id);

                    command.ExecuteScalar();
                }
                
                // TOOD enter the winner team in the next round in SQL?!

                tran.Commit();
                connection.Close();
                
            }
            

        }
    }
}
