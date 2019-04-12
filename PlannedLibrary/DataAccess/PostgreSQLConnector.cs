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
        // TODO 3 put this in app.config file, search how to avoid writing user and pass
        // TODO 3 synchronizeing the text and database saves?!
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
                dr.Close();
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

                dr.Close();


                foreach (Team team in outputList)
                {
                    team.TeamMembers = GetTeamPlayers(team.Id, connection);
                }

                //tran.Commit();
                connection.Close();
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

                int newMatchId = 0;
                
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
                        SaveEntriesOfMatch(m, connection);
                        counter++;
                    }
                }

                tran.Commit();
                connection.Close();
            }
        }

        private void SaveEntriesOfMatch(Match m, NpgsqlConnection connection)
        {
            int newMatchEntryId = 0;

            NpgsqlCommand command = new NpgsqlCommand("\"spMatchEntry_Insert\"", connection);
            command.CommandType = CommandType.StoredProcedure;

            foreach (MatchEntry mEntry in m.Entries)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("MatchId", m.Id);
                if (mEntry.ParentMatch != null)
                {
                    command.Parameters.AddWithValue("ParentMatchId", mEntry.ParentMatch.Id);
                }
                else
                {
                    // send DBNull.Value instead of null, otherwise Npgsql throw an exception
                    command.Parameters.AddWithValue("ParentMatchId", DBNull.Value);
                }
                if (mEntry.TeamCompeting != null)
                {
                    command.Parameters.AddWithValue("TeamCompetingId", mEntry.TeamCompeting.Id);
                }
                else
                {
                    // send DBNull.Value instead of null, otherwise Npgsql throw an exception
                    command.Parameters.AddWithValue("TeamCompetingId", DBNull.Value);
                }

                // Execute the procedure and obtain a result set
                //NpgsqlDataReader dr = command.ExecuteReader();
                // if it returns a single value, use ExecuteScalar!
                newMatchEntryId = Convert.ToInt32(command.ExecuteScalar());
                mEntry.Id = newMatchEntryId;
                //tran.Commit();
            }
        }

        public List<Tournament> GetTournaments_List()
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

                dr.Close();

                //tran.Commit();
                connection.Close();
            }

            return outputList;
        }

        public Tournament GetTournamentInfo(Tournament model)
        {
            List<Tournament> outputList = new List<Tournament>();

            using (var connection = new NpgsqlConnection(CnnString))
            {

                connection.Open();
                // Start a transaction as it is required to work with result sets (cursors) in PostgreSQL to make changes to database, not when you only read
                //NpgsqlTransaction tran = connection.BeginTransaction();
                model.Prizes = GetTournamentPrizes(model.Id, connection);
                model.Teams = GetTournamentTeams(model.Id, connection);
                model.Rounds = GetTournamentRounds(model, connection);

                //tran.Commit();
                connection.Close();
            }

            return model;
        }

        private List<List<Match>> GetTournamentRounds(Tournament tournament, NpgsqlConnection connection)
        {
            GetTournamentMatches(tournament,connection);
            GetTournamentMatchEntries(tournament, connection);

            return tournament.Rounds;
        }

        private void GetTournamentMatchEntries(Tournament tournament, NpgsqlConnection connection)
        {
            NpgsqlCommand command = new NpgsqlCommand("\"spMatchEntries_GetByMatch\"", connection);
            command.CommandType = CommandType.StoredProcedure;

            for (int roundIdx = 0; roundIdx < tournament.Rounds.Count; roundIdx++)
            {
                foreach (Match m in tournament.Rounds[roundIdx])
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("matchId", m.Id);

                    // Execute the procedure and obtain a result set
                    MatchEntry currentMatchEntry;

                    NpgsqlDataReader dr = command.ExecuteReader();
                    
                    while (dr.Read())
                    {
                        currentMatchEntry = new MatchEntry();
                        currentMatchEntry.Id = Convert.ToInt32(dr[0]);

                        if (dr[2] != DBNull.Value)
                        {
                            currentMatchEntry.ParentMatch = tournament.Rounds[roundIdx - 1].Where(x => x.Id == Convert.ToInt32(dr[2])).First();
                        }

                        if (dr[3] != DBNull.Value)
                        {
                            currentMatchEntry.TeamCompeting = tournament.Teams.Where(x => x.Id == Convert.ToInt32(dr[3])).First();
                        }

                        if (dr[4] != DBNull.Value)
                        {
                            currentMatchEntry.Score = Convert.ToString(dr[4]);
                        }

                        m.Entries.Add(currentMatchEntry);
                    }

                    dr.Close();
                    
                }
            }
            
        }

        /// <summary>
        /// returns matches of a given tournament without the match entries
        /// </summary>
        /// <param name="tournament"></param>
        /// <param name="connection"></param>
        /// <returns></returns>
        private void GetTournamentMatches(Tournament tournament, NpgsqlConnection connection)
        {
            List<List<Match>> roundsList = new List<List<Match>>();
            // Define a command to call the PostgreSQL function
            // This code works with PostgreSQL functions not procedures
            NpgsqlCommand command = new NpgsqlCommand("\"spMatches_GetByTournament\"", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("tournamentId", tournament.Id);

            // Execute the procedure and obtain a result set
            NpgsqlDataReader dr = command.ExecuteReader();

            // Output rows
            int currentRoundIdx = 1;
            List<Match> currentRound = new List<Match>();
            Match currentMatch;
            while (dr.Read())
            {
                if (Convert.ToInt32(dr[3]) != currentRoundIdx)
                {
                    currentRoundIdx++;
                    roundsList.Add(currentRound);
                    currentRound = new List<Match>();
                }
                currentMatch = new Match();
                currentMatch.Id = Convert.ToInt32(dr[0]);
                currentMatch.Round = currentRoundIdx;
                if (dr[2] != DBNull.Value)
                {
                    currentMatch.Winner = tournament.Teams.Where(x => x.Id == Convert.ToInt32(dr[2])).First();
                }
                currentRound.Add(currentMatch);
            }

            // Adding the last round as well
            roundsList.Add(currentRound);

            dr.Close();
            tournament.Rounds = roundsList;
        }

        private List<Team> GetTournamentTeams(int tournamentId, NpgsqlConnection connection)
        {
            List<Team> outputList = new List<Team>();

            // Define a command to call the PostgreSQL function
            // This code works with PostgreSQL functions not procedures
            NpgsqlCommand command = new NpgsqlCommand("\"spTeams_GetByTournament\"", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("tournamentId", tournamentId);

            // Execute the procedure and obtain a result set
            NpgsqlDataReader dr = command.ExecuteReader();

            // Output rows 
            while (dr.Read())
            {
                outputList.Add(new Team(
                    Convert.ToInt32(dr[0]),
                    Convert.ToString(dr[1])));
            }
            dr.Close();

            foreach (Team team in outputList)
            {
                team.TeamMembers = GetTeamPlayers(team.Id, connection);
            }
            return outputList;
        }

        private List<Player> GetTeamPlayers(int teamId, NpgsqlConnection connection)
        {
            List<Player> teamMembers = new List<Player>();
            // Start a transaction as it is required to work with result sets (cursors) in PostgreSQL
            //NpgsqlTransaction tran = connection.BeginTransaction();

            // Define a command to call the PostgreSQL function
            // This code works with PostgreSQL functions not procedures
            NpgsqlCommand command = new NpgsqlCommand("\"spPeople_GetByTeam\"", connection);
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("teamId", teamId);
            // Execute the procedure and obtain a result set
            NpgsqlDataReader dr = command.ExecuteReader();

            // Output rows 

            while (dr.Read())
            {
                teamMembers.Add(new Player(
                    Convert.ToInt32(dr[0]),
                    Convert.ToString(dr[1]),
                    Convert.ToString(dr[2]),
                    Convert.ToString(dr[3]),
                    Convert.ToString(dr[4])));
            }

            dr.Close();

            return teamMembers;
        }

        private List<Prize> GetTournamentPrizes(int tournamentId, NpgsqlConnection connection)
        {
            List<Prize> outputList = new List<Prize>();

            // Define a command to call the PostgreSQL function
            // This code works with PostgreSQL functions not procedures
            NpgsqlCommand command = new NpgsqlCommand("\"spPrizes_GetByTournament\"", connection);

            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("tournamentId", tournamentId);

            // Execute the procedure and obtain a result set
            //NpgsqlDataReader dr = command.ExecuteReader();
            // if it returns a single value, use ExecuteScalar!

            NpgsqlDataReader dr = command.ExecuteReader();

            // Output rows 
            while (dr.Read())
            {
                outputList.Add(new Prize(
                Convert.ToInt32(dr[0]),
                Convert.ToInt32(dr[1]),
                Convert.ToString(dr[2]),
                Convert.ToDecimal(dr[3]),
                Convert.ToDouble(dr[4])));
            }

            dr.Close();
            return outputList;
        }

        public void UpdateMatch(Match model)
        {
            using (var connection = new NpgsqlConnection(CnnString))
            {
                // TODO 1 not tested yet, first need to implement complete tournamnet in SQL
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

                UpdateMatchEntries(model.Entries, connection);

                tran.Commit();
                connection.Close();

            }

        }
        private void UpdateMatchEntries(List<MatchEntry> matchEntriesList, NpgsqlConnection connection)
        {
            NpgsqlCommand command = new NpgsqlCommand("\"spMatchEntries_Update\"", connection);

            command.CommandType = CommandType.StoredProcedure;

            foreach (MatchEntry mEntry in matchEntriesList)
            {
                command.Parameters.Clear();
                command.Parameters.AddWithValue("Id", mEntry.Id);
                command.Parameters.AddWithValue("Score", mEntry.Score);
                command.Parameters.AddWithValue("TeamCompetingId", mEntry.TeamCompeting.Id);

                command.ExecuteScalar();
            }
        }
    }
}
