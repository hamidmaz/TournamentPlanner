using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlannedLibrary.DataAccess.TextProcessors;
using PlannedLibrary.Models;

namespace PlannedLibrary.DataAccess
{
    public class TextFileConnector : IDataConnection
    {

        private const string PrizesFileName = "Prizes.csv";
        private const string PlayersFileName = "People.csv";
        private const string TeamsFileName = "Teams.csv";
        private const string TournamentsFileName = "Tournaments.csv";
        private const string MatchupsFileName = "Matchups.csv";


        /// <summary>
        /// Save the new prize to a txt file and pass it with its unique identifier
        /// </summary>
        /// <param name="model"> The new prize</param>
        /// <returns> The prize with a unique identifier</returns>
        public Prize CreatePrize(Prize model)
        {
            // Load the text file and convert it to a list of prizes

            List<Prize> prizesList = PrizesFileName.LoadFile().ConvertToPrizes();

            //find the last id
            int lastId = 0;
            if (prizesList.Count != 0)
            {
                lastId = prizesList[prizesList.Count - 1].Id;
                
            }
            model.Id = lastId + 1;
            // save the new one at the end of the file

            prizesList.Add(model);

            prizesList.ConvertPrizesToString().SaveFile(PrizesFileName);
            return model;
        }

        public Player CreatePlayer(Player model)
        {
            // Load the text file and convert it to a list of prizes

            List<Player> playersList = PlayersFileName.LoadFile().ConvertToPlayers();

            //find the last id
            int lastId = 0;
            if (playersList.Count != 0)
            {
                lastId = playersList[playersList.Count - 1].Id;

            }
            model.Id = lastId + 1;
            // save the new one at the end of the file

            playersList.Add(model);

            playersList.ConvertPlayersToString().SaveFile(PlayersFileName);
            return model;
        }

        /// <summary>
        /// load all the players from database and return a list of players
        /// </summary>
        /// <returns></returns>
        public List<Player> GetPeople_All()
        {
            // Load the text file and convert it to a list of people

            return PlayersFileName.LoadFile().ConvertToPlayers();
            
        }

        public Team CreateTeam(Team model)
        {
            // Load the text file and convert it to a list of teams

            List<Team> teamsList = TeamsFileName.LoadFile().ConvertToTeams(PlayersFileName);

            //find the last id
            int lasTeamtId = 0;
            if (teamsList.Count != 0)
            {
                lasTeamtId = teamsList[teamsList.Count - 1].Id;
            }
            model.Id = lasTeamtId + 1;
            // save the new one at the end of the file
            
            teamsList.Add(model);

            teamsList.ConvertTeamsToString().SaveFile(TeamsFileName);
            return model;
        }

         
        public List<Team> GetTeams_All()
        {
            // Load the text file and convert it to a list of prizes

            return TeamsFileName.LoadFile().ConvertToTeams(PlayersFileName);
        }


        // TODO implement this
        public Tournament CreateTournament(Tournament model)
        {
            // Load the text file and convert it to a list of tournaments

            List<Tournament> tournamentsList = TeamsFileName.LoadFile().ConvertToTournaments(TournamentsFileName,PlayersFileName,PrizesFileName,MatchupsFileName);

            //find the last id
            int lasTtId = 0;
            if (tournamentsList.Count != 0)
            {
                lasTtId = tournamentsList[tournamentsList.Count - 1].Id;
            }
            model.Id = lasTtId + 1;
            // save the new one at the end of the file

            tournamentsList.Add(model);

            tournamentsList.ConvertTournamentsToString().SaveFile(TournamentsFileName);
            return model;
        }
    }
}
