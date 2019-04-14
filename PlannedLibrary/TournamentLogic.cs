using PlannedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannedLibrary
{
    public static class TournamentLogic
    {
        public static void CreateRounds (Tournament model)
        {
            // randomly order them
            List<Team> randomizedTeamsList = RandomizeTeams(model.Teams);

            // add byes (empty spots) to make the number of teams a power of 2

            int roundsNumber = FindNumberOfRounds(randomizedTeamsList.Count);
            int byesNumber = (int)Math.Pow(2, roundsNumber-1) - randomizedTeamsList.Count;

            // create the first round of matches
            model.Rounds.Add(CreateFirstRound(randomizedTeamsList,byesNumber));
            // create the next rounds
            for (int i = 2; i < roundsNumber; i++)
            {
                model.Rounds.Add(CreateNewRound(i, model.Rounds.Last()));
            }

        }

        private static List<Match> CreateNewRound (int round, List<Match> prevRound)
        {
            List<Match> newRound = new List<Match>();
            MatchEntry currMatchEntry;
            Match currMatch = new Match();

            foreach (Match oldMatch in prevRound)
            {
                currMatch.Round = round;
                currMatchEntry = new MatchEntry();
                currMatchEntry.ParentMatch = oldMatch;
                
                // to pass teams with byes as the winner to the next round
                if (oldMatch.Entries.Count == 1)
                {
                    currMatchEntry.TeamCompeting = oldMatch.Entries[0].TeamCompeting;
                }
                currMatch.Entries.Add(currMatchEntry);

                if (currMatch.Entries.Count > 1)
                {
                    newRound.Add(currMatch);
                    currMatch = new Match();
                }

                //newRound.Add(new Match());
                //currMatchEntry = new MatchEntry();
            }

            return newRound;
        }

        private static List<Match> CreateFirstRound (List<Team> teams, int byesNumbers)
        {

            List<Match> firstRound = new List<Match>();
            MatchEntry currMatchEntry;
            Match currMatch = new Match();
            foreach (Team team in teams)
            {
                currMatch.Round = 1;
                currMatchEntry = new MatchEntry();
                currMatchEntry.TeamCompeting = team;
                currMatch.Entries.Add(currMatchEntry);

                if (byesNumbers > 0 || currMatch.Entries.Count > 1)
                {
                    if (byesNumbers > 0)
                    {
                        currMatch.Winner = currMatch.Entries[0].TeamCompeting;
                        byesNumbers--;
                    }
                    firstRound.Add(currMatch);
                    currMatch = new Match();
                }

            }


            return firstRound;
        }

        private static int FindNumberOfRounds(int numberOfTeams)
        {
            int output = (int)Math.Log(numberOfTeams, 2);
            if (numberOfTeams-Math.Pow(2,output) != 0)
            {
                output++;
            }
            return output+1;
        }

        private static List<Team> RandomizeTeams(List<Team> teams)
        {
            return teams.OrderBy(x => Guid.NewGuid()).ToList();
        }


        public static List<Match> FindUnplayedMatches(List<Match> round)
        {
            List<Match> roundUnplayed = new List<Match>();
            foreach (Match m in round)
            {
                if (m.Winner == null)
                {
                    roundUnplayed.Add(m);
                }
            }
            return roundUnplayed;
        }


        public static int FindActiveRound(List<List<Match>> tournamentRounds, out bool tournamentFinished)
        {
            List<Match> round;
            List<Match> roundUnplayed;
            tournamentFinished = false;
            int i;
            for (i = 0; i < tournamentRounds.Count; i++)
            {

                round = tournamentRounds[i];

                roundUnplayed = TournamentLogic.FindUnplayedMatches(round);

                if (roundUnplayed.Count != 0)
                {
                    return i;
                }
            }
            tournamentFinished = true;
            return i-1;
        }

        public static void PutTheWinnerInNextRound(Tournament tournament, Match match)
        {
            int nextRound = match.Round + 1;
            foreach (Match m in tournament.Rounds[nextRound-1])
            {
                foreach (MatchEntry mEntry in m.Entries)
                {
                    if (mEntry.ParentMatch == match)
                    {
                        mEntry.TeamCompeting = match.Winner;
                        GlobalConfig.Connection.UpdateMatch(m);
                        break;
                    }
                }
            }

        }
    }
}
