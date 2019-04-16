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
        public static string FullFilePath(this string fileName)
        {
            return $"{GlobalConfig.AppKeyLookUp("filePath")}\\{fileName}";
        }


        /// <summary>
        /// load a file and return a list of strings each contains a line of the text file
        /// </summary>
        /// <param name="file"> file name, not the full file path</param>
        /// <returns></returns>
        public static List<string> LoadFile(this string fileName)
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
        public static void SaveFile(this List<string> lines, string fileName)
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
        public static List<Team> ConvertToTeams(this List<string> lines)
        {
            List<Team> outputList = new List<Team>();

            List<Player> allPlayersList = GlobalConfig.PlayersFileName.LoadFile().ConvertToPlayers();

            Team t;
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                t = new Team();

                t.Id = Convert.ToInt32(cols[0]);
                t.TeamName = cols[1];
                t.TeamMembers = ConvertIdStringToTeamMembersList(cols[2], allPlayersList);

                outputList.Add(t);
            }
            return outputList;
        }

        private static List<Player> ConvertIdStringToTeamMembersList(string memebersString, List<Player> allPlayersList)
        {
            List<Player> teamMebmersList = new List<Player>();
            if (memebersString != "")
            {

                string[] teamMemberIds = memebersString.Split('|');
                foreach (string memberId in teamMemberIds)
                {
                    teamMebmersList.Add((allPlayersList.Where(x => x.Id == Convert.ToInt32(memberId)).First()));
                }
            }
            return teamMebmersList;
        }
        private static string ConvertTeamMembersToIdString(List<Player> teamMembers)
        {
            string output = "";
            foreach (Player p in teamMembers)
            {
                output = $"{output}{p.Id}|";
            }
            return output;
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

                teamString = $"{teamString}{ConvertTeamMembersToIdString(t.TeamMembers)}";

                if (t.TeamMembers.Count > 0)
                {

                    teamString = teamString.Remove(teamString.Length - 1);
                }
                outputStringList.Add(teamString);
            }
            return outputStringList;
        }

        public static List<Match> ConvertToMatchesAndMatchEntries(this List<string> matchLines, List<string> matchEntryLines, out List<MatchEntry> allMatchEntriesList)
        {
            //populate all match entries with fake parent matches (only contains the ids to the parent match)
            allMatchEntriesList = ConvertToMatchEntries(matchEntryLines);

            // populate all the matches
            List<Match> allMatchesList = ConvertToMatches(matchLines, allMatchEntriesList);

            //replace all the fake parent matches with real ones
            Match parentMatch = new Match();
            foreach (MatchEntry mEntry in allMatchEntriesList)
            {
                if (mEntry.ParentMatch != null)
                {
                    parentMatch = allMatchesList.Where(x => x.Id == mEntry.ParentMatch.Id).First();
                    mEntry.ParentMatch = parentMatch;

                }
            }

            return allMatchesList;
        }
        /// <summary>
        /// populate all match entries with fake parent matches (only contains the ids to the parent match)
        /// </summary>
        /// <param name="matchEntryLines"></param>
        /// <param name=""></param>
        /// <returns></returns>
        private static List<MatchEntry> ConvertToMatchEntries (List<string> matchEntryLines)
        {
            List<Team> allTeamsList = GlobalConfig.TeamsFileName.LoadFile().ConvertToTeams();
            List<MatchEntry> allMatchEntriesList = new List<MatchEntry>();

            foreach (string matchEntryLine in matchEntryLines)
            {
                string[] cols = matchEntryLine.Split(',');
                MatchEntry mEntry = new MatchEntry();

                mEntry.Id = Convert.ToInt32(cols[0]);
                if (cols[1] != "")
                {
                    mEntry.TeamCompeting = allTeamsList.Where(x => x.Id == Convert.ToInt32(cols[1])).First();
                }

                if (cols[2] != "")
                {
                    mEntry.Score = cols[2];
                }
                if (cols[3] != "")
                {
                    mEntry.ParentMatch = new Match();
                    mEntry.ParentMatch.Id = Convert.ToInt32(cols[3]);

                }
                allMatchEntriesList.Add(mEntry);
            }
            return allMatchEntriesList;
        }
        private static List<Match> ConvertToMatches(List<string> matchLines, List<MatchEntry> allMatchEntriesList)
        {
            List<Match> allMatchesList = new List<Match>();

            foreach (string line in matchLines)
            {
                string[] cols = line.Split(',');
                Match m = new Match();

                m.Id = Convert.ToInt32(cols[0]);
                m.Entries = new List<MatchEntry>();

                if (cols[3] != "")
                {

                    string[] matchEntriesId = cols[3].Split('|');
                    foreach (string matchEntryId in matchEntriesId)
                    {
                        m.Entries.Add((allMatchEntriesList.Where(x => x.Id == Convert.ToInt32(matchEntryId)).First()));
                    }
                }

                if (cols[1] != "")
                {
                    MatchEntry winnerEntity = m.Entries.Where(x => x.TeamCompeting.Id == Convert.ToInt32(cols[1])).First();
                    m.Winner = winnerEntity.TeamCompeting;
                }

                m.Round = Convert.ToInt32(cols[2]);
                allMatchesList.Add(m);
            }
            return allMatchesList;
        }

        private static List<string> ConvertMatchEntriesToString(this List<MatchEntry> matchEntriesList)
        {
            //id,competing team, score, parent match
            List<string> outputStringList = new List<string>();
            string score;
            string parentMatchId;
            string teamCompetingId;
            foreach (MatchEntry mEntry in matchEntriesList)
            {
                score = "";
                parentMatchId = "";
                teamCompetingId = "";

                if (mEntry.Score != null)
                {
                    score = $"{mEntry.Score}";
                }
                if (mEntry.ParentMatch != null)
                {
                    parentMatchId = $"{mEntry.ParentMatch.Id}";
                }
                if (mEntry.TeamCompeting != null)
                {
                    teamCompetingId = $"{mEntry.TeamCompeting.Id}";
                }
                string matchEntrySting = $"{mEntry.Id},{teamCompetingId},{score},{parentMatchId}";

                outputStringList.Add(matchEntrySting);
            }
            return outputStringList;
        }
        private static List<string> ConvertMatchesToString(this List<Match> matchesList)
        {
            //id, winnerId, round, entry1|entry2
            List<string> outputStringList = new List<string>();
            string matchSting;
            string winnderId;
            foreach (Match match in matchesList)
            {
                matchSting = "";
                winnderId = "";
                if (match.Winner != null)
                {
                    winnderId = $"{match.Winner.Id}";
                }
                matchSting = $"{match.Id},{winnderId},{match.Round},";
                foreach (MatchEntry mEntry in match.Entries)
                {
                    matchSting = $"{matchSting}{mEntry.Id}|";
                }
                if (match.Entries.Count > 0)
                {
                    matchSting = matchSting.Remove(matchSting.Length - 1);
                }

                outputStringList.Add(matchSting);
            }
            return outputStringList;
        }


        public static List<string> UpdateMatchesAndMatchEntries(this Match currMatch, out List<string> matchEntriesStringList)
        {
            //reading all matches and match entries from text file
            List<string> matchesStringList = GlobalConfig.MatchesFileName.LoadFile();
            matchEntriesStringList = GlobalConfig.MatchEntriesFileName.LoadFile();

            //converting strings to list of match and match entries models
            List<MatchEntry> allmatchEntriesList;
            List<Match> allmatchesList = matchesStringList.ConvertToMatchesAndMatchEntries(matchEntriesStringList, out allmatchEntriesList);

            //update the model list
            ReplaceOldMatchWithNew(currMatch, allmatchesList, allmatchEntriesList);

            // convert back the list to strings
            matchEntriesStringList = allmatchEntriesList.ConvertMatchEntriesToString();
            matchesStringList = allmatchesList.ConvertMatchesToString();
            return matchesStringList;
        }

        private static void ReplaceOldMatchWithNew(Match newMatch, List<Match> allmatchesList, List<MatchEntry> allmatchEntriesList)
        {
            Match oldmatch = allmatchesList.Where(x => x.Id == newMatch.Id).First();
            allmatchesList.Remove(oldmatch);
            allmatchesList.Add(newMatch);

            MatchEntry oldMatchEntry;
            foreach (MatchEntry mEntry in newMatch.Entries)
            {
                oldMatchEntry = allmatchEntriesList.Where(x => x.Id == mEntry.Id).First();
                allmatchEntriesList.Remove(oldMatchEntry);
                allmatchEntriesList.Add(mEntry);
            }
        }

        public static List<Tournament> ConvertToTournamentsList(this List<string> lines)
        {
            List<Tournament> outputList = new List<Tournament>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                Tournament tour = new Tournament();

                tour.Id = Convert.ToInt32(cols[0]);
                tour.TournamentName = cols[1];
                tour.EntryFee = Convert.ToDecimal(cols[2]);

                outputList.Add(tour);
            }
            return outputList;
        }

        public static Tournament CollectTournamentInfo(this Tournament selectedTournament)
        {
            List<string> allTournamentStringList = GlobalConfig.TournamentsFileName.LoadFile();
            List<MatchEntry> allmatchEntriesList;
            List<string> matchEntriesStringList = GlobalConfig.MatchEntriesFileName.LoadFile();
            List<Match> allmatchesList = GlobalConfig.MatchesFileName.LoadFile().ConvertToMatchesAndMatchEntries(matchEntriesStringList, out allmatchEntriesList);

            List<Tournament> outputList = new List<Tournament>();

            foreach (string line in allTournamentStringList)
            {
                string[] cols = line.Split(',');
                if (selectedTournament.Id == Convert.ToInt32(cols[0]))
                {
                    selectedTournament.Teams = ConvertIdStringToTeamList(cols[3]);
                    selectedTournament.Prizes = ConvertIdStringToPrizeList(cols[4]);
                    selectedTournament.Rounds = ConvertIdStringToRoundList(cols[5], allmatchesList, allmatchEntriesList);
                    
                    break;
                }
            }
            return selectedTournament;
        }

        /// <summary>
        /// Add the new tournament, matches, and match entries to the end of the previous files
        /// </summary>
        /// <param name="newTournaments"></param>
        /// <param name="matchesStringList"></param>
        /// <param name="matchEntriesStringList"></param>
        /// <returns></returns>
        public static List<string> ConvertTournamentsToString(this Tournament newTournaments, out List<string> matchesStringList, out List<string> matchEntriesStringList)
        {
            //id,name,fee,team1|team2|...,prize1|prize2|...,match1 of round1*match2 of round1*...|match1 of round2*match2 of round2*...|...
            List<string> outputStringList = GlobalConfig.TournamentsFileName.LoadFile();
            matchesStringList = GlobalConfig.MatchesFileName.LoadFile();
            matchEntriesStringList = GlobalConfig.MatchEntriesFileName.LoadFile();

            
            string tournamentString = $"{newTournaments.Id},{newTournaments.TournamentName},{newTournaments.EntryFee},{newTournaments.Teams.ConvertTeamsListToIdString()},{newTournaments.Prizes.ConvertPrizesListToIdString()},{newTournaments.Rounds.ConvertRoundsListToIdString()}";

            outputStringList.Add(tournamentString);

            foreach (List<Match> round in newTournaments.Rounds)
                {
                    matchesStringList.AddRange(round.ConvertMatchesToString());
                    foreach (Match m in round)
                    {
                        matchEntriesStringList.AddRange(m.Entries.ConvertMatchEntriesToString());
                    }
                }
            
            return outputStringList;
        }

        private static List<Team> ConvertIdStringToTeamList(string teamIdString)
        {
            List<Team> allTeamsList = GlobalConfig.TeamsFileName.LoadFile().ConvertToTeams();
            List<Team> tournamentTeamsList = new List<Team>();
            if (teamIdString != "")
            {

                string[] teamIdsArray = teamIdString.Split('|');
                foreach (string teamId in teamIdsArray)
                {
                    tournamentTeamsList.Add((allTeamsList.Where(x => x.Id == Convert.ToInt32(teamId)).First()));
                }
            }
            return tournamentTeamsList;
        }
        private static List<Prize> ConvertIdStringToPrizeList(string prizeIdString)
        {
            List<Prize> allPrizesList = GlobalConfig.PrizesFileName.LoadFile().ConvertToPrizes();
            List<Prize> tournamentPrizesList = new List<Prize>();
            if (prizeIdString != "")
            {

                string[] prizeIdsArray = prizeIdString.Split('|');
                foreach (string prizeId in prizeIdsArray)
                {
                    tournamentPrizesList.Add((allPrizesList.Where(x => x.Id == Convert.ToInt32(prizeId)).First()));
                }
            }
            return tournamentPrizesList;
        }
        private static List<Match> ConvertIdStringToMatchList(string roundString, List<Match> allmatchesList, List<MatchEntry> allmatchEntriesList)
        {
            List<Match> roundMatchesList = new List<Match>();
            string[] matcheIdsArray = roundString.Split('*');
            foreach (string matchId in matcheIdsArray)
            {
                roundMatchesList.Add((allmatchesList.Where(x => x.Id == Convert.ToInt32(matchId)).First()));
            }

            return roundMatchesList;
        }
        private static List<List<Match>> ConvertIdStringToRoundList(string roundsIdString, List<Match> allmatchesList, List<MatchEntry> allmatchEntriesList)
        {

            List<List<Match>> tournamentRoundsList = new List<List<Match>>();

            if (roundsIdString != "")
            {

                string[] roundsArray = roundsIdString.Split('|');
                foreach (string roundString in roundsArray)
                {
                    tournamentRoundsList.Add(ConvertIdStringToMatchList(roundString, allmatchesList, allmatchEntriesList));
                }
            }
            return tournamentRoundsList;
        }


        private static string ConvertTeamsListToIdString(this List<Team> teamList)
        {
            string output = "";
            foreach (Team t in teamList)
            {
                output = $"{output}{t.Id}|";
            }
            if (teamList.Count > 0)
            {
                output = output.Remove(output.Length - 1);
            }
            return output;
        }
        private static string ConvertPrizesListToIdString(this List<Prize> prizesList)
        {
            string output = "";
            foreach (Prize p in prizesList)
            {
                output = $"{output}{p.Id}|";
            }
            if (prizesList.Count > 0)
            {
                output = output.Remove(output.Length - 1);
            }
            return output;
        }
        private static string ConvertRoundsListToIdString(this List<List<Match>> roundsList)
        {
            string output = "";

            // find last Ids for match entires and matches--------------------------------------
            int[] lastIds = FindLastMatchAndMatchEntryIds();
            int lastMatchtId = lastIds[0];
            int lastMatchEntrytId = lastIds[1];

            //----------------------------------------------------------------------------------

            foreach (List<Match> round in roundsList)
            {
                foreach (Match m in round)
                {
                    m.Id = lastMatchtId + 1;
                    
                    lastMatchtId++;
                    foreach (MatchEntry mEntry in m.Entries)
                    {
                        mEntry.Id = lastMatchEntrytId + 1;
                        lastMatchEntrytId++;
                    }
                    output = $"{output}{m.Id}*";
                }
                if (round.Count > 0)
                {
                    output = output.Remove(output.Length - 1);
                }
                output = $"{output}|";
            }
            if (roundsList.Count > 0)
            {
                output = output.Remove(output.Length - 1);
            }

            return output;
        }

        /// <summary>
        /// Find the last Ids for matches and match entries in the database
        /// </summary>
        /// <returns>[last Match Id,last Match Entry Id]</returns>
        private static int[] FindLastMatchAndMatchEntryIds()
        {
            int[] output = {0,0};
            List<MatchEntry> allmatchEntriesList;
            List<string> matchEntriesStringList = GlobalConfig.MatchEntriesFileName.LoadFile();
            List<Match> allmatchesList = GlobalConfig.MatchesFileName.LoadFile().ConvertToMatchesAndMatchEntries(matchEntriesStringList, out allmatchEntriesList);

            if (allmatchesList.Count != 0)
            {
                //lasTtId = tournamentsList[tournamentsList.Count - 1].Id;
                output[0] = allmatchesList.OrderByDescending(x => x.Id).First().Id;
            }

            if (allmatchEntriesList.Count != 0)
            {
                //lasTtId = tournamentsList[tournamentsList.Count - 1].Id;
                output[1] = allmatchEntriesList.OrderByDescending(x => x.Id).First().Id;
            }

            return output;
        }

    }
}
