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

        // TODO impelement this

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

                string test = "";
                string[] test2 = new string[5];
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
                // outputList.Add(dr.Cast<Player>);

                //tran.Commit();
                connection.Close();

                
            }

            return outputList;
        }
    }
}
