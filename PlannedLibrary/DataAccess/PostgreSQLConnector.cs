﻿using Dapper;
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

            //TODO save matches which are made somewhere else
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
                NpgsqlCommand command = new NpgsqlCommand("\"spTournaments_Insert\"", connection);

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
                NpgsqlCommand command = new NpgsqlCommand("\"spTournamentEntries_Insert\"", connection);

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




    }
}
