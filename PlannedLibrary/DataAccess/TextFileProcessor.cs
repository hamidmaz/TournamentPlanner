using PlannedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We add an extra ".TextConnector" to the end of the namespace
// to make the access to the methods of it more limited especially
// the extension for the string type in FullFilePath method
namespace PlannedLibrary.DataAccess.TextProcessors
{
    public static class TextFileProcessor
    {
        // "this" keyword in the input make the method an extension for 
        //string type which is only available in this namespace
        public static string FullFilePath (this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }


        /// <summary>
        /// load a file and return a list of strings each contains a line of the text file
        /// </summary>
        /// <param name="file"> file name, not the full file path</param>
        /// <returns></returns>
        public static List<string> LoadFile (this string fileName)
        {
            if (!File.Exists(fileName.FullFilePath()))
            {
                return new List<string>();
            }
            else
            {
                return File.ReadAllLines(fileName.FullFilePath()).ToList();
            }    
        }

        /// <summary>
        /// Get a list of strings each contains a line of the text file and save it to the file
        /// </summary>
        /// <param name="file"> file name, not the full file path</param>
        /// <returns></returns>
        public static void SaveFile (this List<string> lines, string fileName)
        {
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }


        public static List<Prize> ConvertToPrizes(this List<string> lines)
        {
            List<Prize> outputList = new List<Prize>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                Prize p = new Prize(cols[1], cols[2], cols[3], cols[4]);
                p.Id = Convert.ToInt32(cols[0]);

                outputList.Add(p);
            }
            return outputList;
        }
        public static List<string> ConvertPrizesToString(this List<Prize> prizesList)
        {
            List<string> outputStringList = new List<string>();
            foreach (Prize p in prizesList)
            {
                outputStringList.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.Amount},{p.Percentage}");
            }
            return outputStringList;
        }


        public static List<Player> ConvertToPlayers(this List<string> lines)
        {
            List<Player> outputList = new List<Player>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                Player p = new Player(Convert.ToInt32(cols[0]), cols[1], cols[2], cols[3], cols[4]);
                
                outputList.Add(p);
            }
            return outputList;
        }
        public static List<string> ConvertPlayersToString(this List<Player> playersList)
        {
            List<string> outputStringList = new List<string>();
            foreach (Player p in playersList)
            {
                outputStringList.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNr}");
            }
            return outputStringList;
        }

        /// <summary>
        /// Read teams from the file and return a list of teams containing teamnames and IDs without their members
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static List<Team> ConvertToTeams(this List<string> lines, string playersFileName)
        {
            List<Team> outputList = new List<Team>();
            List<Player> teamMebmersList;
            List<Player> allPlayersList = playersFileName.LoadFile().ConvertToPlayers();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                Team t = new Team();

                t.Id = Convert.ToInt32(cols[0]);
                t.TeamName = cols[1];

                
                teamMebmersList= new List<Player>();
                if (cols[2] != "")
                {

                    string[] teamMemberIds = cols[2].Split('|');
                    foreach (string memberId in teamMemberIds)
                    {
                        teamMebmersList.Add((allPlayersList.Where(x => x.Id == Convert.ToInt32(memberId)).First()));
                    } 
                }
                t.TeamMembers = teamMebmersList;

                outputList.Add(t);
            }
            return outputList;
        }
        
        /// <summary>
        /// Converts new teams to strings without their teammembers. 
        /// </summary>
        /// <param name="teamsList"></param>
        /// <returns></returns>
        public static List<string> ConvertTeamsToString(this List<Team> teamsList)
        {
            List<string> outputStringList = new List<string>();
            foreach (Team t in teamsList)
            {
                string teamString = $"{t.Id},{t.TeamName},";
                
                foreach (Player p in t.TeamMembers)
                {
                    teamString = $"{teamString}{p.Id}|";
                }
                if (teamString.Length >0)
                {

                    teamString = teamString.Remove(teamString.Length-1);
                }
                outputStringList.Add(teamString);
            }
            return outputStringList;
        }


        /// <summary>
        /// Read teams from the file and return a list of teams containing teamnames and IDs without their members
        /// </summary>
        /// <param name="lines"></param>
        /// <returns></returns>
        public static List<Tournament> ConvertToTournaments(this List<string> lines, string teamsFileName,string playersFileName, string prizesFileName, string matchesFileName)
        {
            List<Tournament> outputList = new List<Tournament>();

            List<Team> tournamentTeamsList;
            List<Team> allTeamsList = teamsFileName.LoadFile().ConvertToTeams(playersFileName);

            List<Prize> tournamentPrizesList;
            List<Prize> allPrizesList = prizesFileName.LoadFile().ConvertToPrizes();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                Tournament tour = new Tournament();

                tour.Id = Convert.ToInt32(cols[0]);
                tour.TournamentName = cols[1];
                tour.EntryFee = Convert.ToDecimal(cols[2]);


                tournamentTeamsList = new List<Team>();
                if (cols[3] != "")
                {

                    string[] teamIdsArray = cols[3].Split('|');
                    foreach (string teamId in teamIdsArray)
                    {
                        tournamentTeamsList.Add((allTeamsList.Where(x => x.Id == Convert.ToInt32(teamId)).First()));
                    }
                }
                tour.Teams = tournamentTeamsList;

                tournamentPrizesList = new List<Prize>();
                if (cols[4] != "")
                {

                    string[] prizeIdsArray = cols[4].Split('|');
                    foreach (string prizeId in prizeIdsArray)
                    {
                        tournamentPrizesList.Add((allPrizesList.Where(x => x.Id == Convert.ToInt32(prizeId)).First()));
                    }
                }
                tour.Prizes = tournamentPrizesList;


                // TODO take care of round coversion

                outputList.Add(tour);
            }
            return outputList;
        }

        /// <summary>
        /// Converts new teams to strings without their teammembers. 
        /// </summary>
        /// <param name="tournamentsList"></param>
        /// <returns></returns>
        public static List<string> ConvertTournamentsToString(this List<Tournament> tournamentsList)
        {
            //id,name,fee,team1|team2|...,prize1|prize2|...,match1 of round1*match2 of round1*...|match1 of round2*match2 of round2*...|...
            List<string> outputStringList = new List<string>();
            foreach (Tournament tour in tournamentsList)
            {
                string tournamentString = $"{tour.Id},{tour.TournamentName},{tour.EntryFee},";

                foreach (Team t in tour.Teams)
                {
                    tournamentString = $"{tournamentString}{t.Id}|";
                }
                if (tournamentString.Length > 0)
                {
                    tournamentString = tournamentString.Remove(tournamentString.Length - 1);
                    tournamentString = $"{tournamentString},";
                }

                foreach (Prize p in tour.Prizes)
                {
                    tournamentString = $"{tournamentString}{p.Id}|";
                }
                if (tournamentString.Length > 0)
                {
                    tournamentString = tournamentString.Remove(tournamentString.Length - 1);
                }

                foreach (List<Match> round in tour.Rounds)
                {
                    foreach (Match m in round)
                    {
                        tournamentString = $"{tournamentString}{m.Id}*";
                    }
                    if (tournamentString.Length > 0)
                    {
                        tournamentString = tournamentString.Remove(tournamentString.Length - 1);
                    }
                    tournamentString = $"{tournamentString}|";
                }
                if (tournamentString.Length > 0)
                {
                    tournamentString = tournamentString.Remove(tournamentString.Length - 1);
                }

                outputStringList.Add(tournamentString);
            }
            return outputStringList;
        }




    }
}
