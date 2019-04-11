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

        /// <summary>
        /// Save the new prize to a txt file and pass it with its unique identifier
        /// </summary>
        /// <param name="model"> The new prize</param>
        /// <returns> The prize with a unique identifier</returns>
        public Prize CreatePrize(Prize model)
        {
            // Load the text file and convert it to a list of prizes

            List<Prize> prizesList = GlobalConfig.PrizesFileName.LoadFile().ConvertToPrizes();

            //find the last id
            int lastId = 0;
            if (prizesList.Count != 0)
            {
                //lastId = prizesList[prizesList.Count - 1].Id;
                lastId = prizesList.OrderByDescending(x => x.Id).First().Id;
            }
            model.Id = lastId + 1;
            // save the new one at the end of the file

            prizesList.Add(model);

            prizesList.ConvertPrizesToString().SaveFile(GlobalConfig.PrizesFileName);
            return model;
        }

        public Player CreatePlayer(Player model)
        {
            // Load the text file and convert it to a list of prizes

            List<Player> playersList = GlobalConfig.PlayersFileName.LoadFile().ConvertToPlayers();

            //find the last id
            int lastId = 0;
            if (playersList.Count != 0)
            {
                //lastId = playersList[playersList.Count - 1].Id;
                lastId = playersList.OrderByDescending(x => x.Id).First().Id;

            }
            model.Id = lastId + 1;
            // save the new one at the end of the file

            playersList.Add(model);

            playersList.ConvertPlayersToString().SaveFile(GlobalConfig.PlayersFileName);
            return model;
        }

        /// <summary>
        /// load all the players from database and return a list of players
        /// </summary>
        /// <returns></returns>
        public List<Player> GetPeople_All()
        {
            // Load the text file and convert it to a list of people

            return GlobalConfig.PlayersFileName.LoadFile().ConvertToPlayers();
            
        }

        public Team CreateTeam(Team model)
        {
            // Load the text file and convert it to a list of teams

            List<Team> teamsList = GlobalConfig.TeamsFileName.LoadFile().ConvertToTeams();

            //find the last id
            int lasTeamtId = 0;
            if (teamsList.Count != 0)
            {
                //lasTeamtId = teamsList[teamsList.Count - 1].Id;
                lasTeamtId = teamsList.OrderByDescending(x => x.Id).First().Id;
            }
            model.Id = lasTeamtId + 1;
            // save the new one at the end of the file
            
            teamsList.Add(model);

            teamsList.ConvertTeamsToString().SaveFile(GlobalConfig.TeamsFileName);
            return model;
        }

         
        public List<Team> GetTeams_All()
        {
            // Load the text file and convert it to a list of prizes

            return GlobalConfig.TeamsFileName.LoadFile().ConvertToTeams();
        }


        public Tournament CreateTournament(Tournament model)
        {
            // Load the text files and convert it to a list of match entries, matches, and tournaments


            List<Tournament> tournamentsList = GetTournament_All();

            //find the last ids

            int lastTournamenttId = 0;
            if (tournamentsList.Count != 0)
            {
                //lasTtId = tournamentsList[tournamentsList.Count - 1].Id;
                lastTournamenttId = tournamentsList.OrderByDescending(x => x.Id).First().Id;
            }
            model.Id = lastTournamenttId + 1;

            // save the new one at the end of the file, but first need to populate ids for matches

            tournamentsList.Add(model);

            //save all three files
            tournamentsList.ConvertTournamentsToString(out List<string> matchesStringList, out List<string> matchEntriesStringList).SaveFile(GlobalConfig.TournamentsFileName);
            matchesStringList.SaveFile(GlobalConfig.MatchesFileName);
            matchEntriesStringList.SaveFile(GlobalConfig.MatchEntriesFileName);
            return model;
        }

        public List<Tournament> GetTournament_All()
        {
            return GlobalConfig.TournamentsFileName.LoadFile().ConvertToTournaments();

        }

        // TODO implement this
        public void UpdateMatch(Match model)
        {
            List<string> matchesStringList = model.UpdateMatchesAndMatchEntries(out List<string> matchEntriesStringList);
            matchesStringList.SaveFile(GlobalConfig.MatchesFileName);
            matchEntriesStringList.SaveFile(GlobalConfig.MatchEntriesFileName);
        }
    }
}
