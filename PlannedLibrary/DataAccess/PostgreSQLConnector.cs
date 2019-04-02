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

        /// <summary>
        /// Save the new prize to the database and pass it with its unique identifier
        /// </summary>
        /// <param name="model"> The new prize</param>
        /// <returns> The prize with a unique identifier</returns>
        public Prize CreatePrize(Prize model)
        {


            //using (var connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=hamidma1367;Database=Tournaments"))
            //{
            //    connection.Open();
            //    // Start a transaction as it is required to work with result sets (cursors) in PostgreSQL
            //    NpgsqlTransaction tran = connection.BeginTransaction();

            //    // Define a command to call the PostgreSQL function
            //    // This code works with PostgreSQL functions not procedures
            //    NpgsqlCommand command = new NpgsqlCommand("\"spPrizes_GetAll\"", connection);
            //    command.CommandType = CommandType.StoredProcedure;

            //    // Execute the procedure and obtain a result set
            //    NpgsqlDataReader dr = command.ExecuteReader();

            //    // Output rows 
            //    int x = 0;
            //    while (dr.Read())
            //        x = Convert.ToInt32(dr[3]);

            //    tran.Commit();
            //    connection.Close();

            //    return model;
            //}

            using (var connection = new NpgsqlConnection("Host=localhost;Username=postgres;Password=hamidma1367;Database=Tournaments"))
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
                return model;
            }


        }
    }
}
