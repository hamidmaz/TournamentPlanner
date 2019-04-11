using PlannedLibrary;
using PlannedLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlannerUI
{
    public partial class TournamentViewerForm : Form
    {
        private Tournament tournament;
        int activeRoundIndex = 0;
        private List<Match> selectedRound = new List<Match>();
        private List<Match> selectedRoundUnplayed = new List<Match>();
        private Match selectedMatch;
        private List<int> roundIds;
        bool tournamentFinished = false;

        // TODO remove this variables

        public TournamentViewerForm(Tournament tournamentmodel)
        {
            InitializeComponent();
            tournament = tournamentmodel;
            InitializeFieldsValue();
        }

        private void scoreButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {

                AddScores(teamOneScoreTextBox.Text, teamTwoScoreTextBox.Text);

                //check if the match is the final match
                if (activeRoundIndex < tournament.Rounds.Count-1)
                { 
                    PutTheWinnerInNextRound();
                    selectedRoundUnplayed = FindUnplayedMatches(selectedRound);
                    if (selectedRoundUnplayed.Count == 0)
                    {
                        activeRoundIndex++;
                        MessageBox.Show("Round finished!");
                        DisplayMatch();
                    }

                    if (unPlayedOnlyCheckBox.Checked)
                    {
                        LoadRound(activeRoundIndex);
                    }
                }
                else
                {
                    tournamentFinished = true;
                    MessageBox.Show("Tournament finished!");
                    DisplayMatch();
                }
                
            }
            else
            {
                MessageBox.Show("Invalid inputs!");
            }
        }

        private void AddScores(string teamOneScore, string teamTwoScore)
        {
            selectedMatch.Entries[0].Score = teamOneScore;
            selectedMatch.Entries[1].Score = teamTwoScore;

            if (Convert.ToInt32(teamOneScore) > Convert.ToInt32(teamTwoScore))
            {
                selectedMatch.Winner = selectedMatch.Entries[0].TeamCompeting;
            }
            else
            {
                selectedMatch.Winner = selectedMatch.Entries[1].TeamCompeting;
            }
            // Save to data base
            GlobalConfig.Connection.UpdateMatch(selectedMatch);
        }

        private void PutTheWinnerInNextRound()
        {

            int nextRoundIndex = Convert.ToInt32(roundComboBox.SelectedItem);

            foreach (Match m in tournament.Rounds[nextRoundIndex])
            {
                foreach (MatchEntry mEntry in m.Entries)
                {
                    if (mEntry.ParentMatch == selectedMatch)
                    {
                        mEntry.TeamCompeting = selectedMatch.Winner;
                        GlobalConfig.Connection.UpdateMatch(m);
                        break;
                    }
                }
            }
            
        }
        private void LoadRoundIds()
        {
            roundIds = new List<int>();
            for (int i = 0; i < tournament.Rounds.Count; i++)
            {
                roundIds.Add(i+1);
            }
            // if you do not set the datasource of a comboBox to null
            //before the main values, it will not be updated every time
            // you change it and will only work the first time! Do not know why...
            roundComboBox.DataSource = null;
            roundComboBox.DataSource = roundIds;
            //roundComboBox.DisplayMember = "";
        }

        private void LoadRound(int roundIndex)
        {
            selectedRound = tournament.Rounds[roundIndex];

            selectedRoundUnplayed = FindUnplayedMatches(selectedRound);

            matchListBox.DataSource = null;
            if (unPlayedOnlyCheckBox.Checked)
            {
                matchListBox.DataSource = selectedRoundUnplayed;
            }
            else
            {
                matchListBox.DataSource = selectedRound;
            }
            matchListBox.DisplayMember = "FullMatchName";
        }

        private int FindActiveRound()
        {
            List<Match> round;
            List<Match> roundUnplayed;
            int i;
            for (i = 0; i < tournament.Rounds.Count; i++)
            {

                round = tournament.Rounds[i];

                roundUnplayed = FindUnplayedMatches(round);

                if (roundUnplayed.Count != 0)
                {
                    return i;
                }
            }
            tournamentFinished = true;
            return i;
        }

        private List<Match> FindUnplayedMatches (List<Match> round)
        {
            List <Match> roundUnplayed = new List<Match>();
            foreach (Match m in round)
            {
                if (m.Winner == null)
                {
                    roundUnplayed.Add(m);
                }
            }
            return roundUnplayed;
        }

        private void LoadMatch(int matchIndex)
        {
            selectedMatch = selectedRound[matchIndex];
            teamOneNameLabel.Text = selectedMatch.Entries[0].MatchEntryName();
            teamOneScoreTextBox.Text = selectedMatch.Entries[0].Score;

            if (selectedMatch.Entries.Count == 2)
            {
                teamTwoNameLabel.Text = selectedMatch.Entries[1].MatchEntryName();
                teamTwoScoreTextBox.Text = selectedMatch.Entries[1].Score; ;
            }
            else
            {
                teamTwoNameLabel.Text = "BYE";
                teamTwoScoreTextBox.Text = "";
            }
        }

        private void InitializeFieldsValue()
        {
            tournamentNameLabel.Text = tournament.TournamentName;
            LoadRoundIds();
            activeRoundIndex = FindActiveRound();
            roundComboBox.SelectedItem = activeRoundIndex + 1;
            selectedMatch = selectedRound[0];
            unPlayedOnlyCheckBox.Checked = false;
        }

        private void roundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRound(Convert.ToInt32(roundComboBox.SelectedItem) - 1);
        }

        private void matchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (matchListBox.DataSource != null)
            {

                if (selectedRound.Count > 0)
                {
                    LoadMatch(matchListBox.SelectedIndex);
                }
            }
            DisplayMatch();
        }

        private void unPlayedOnlyCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            LoadRound(Convert.ToInt32(roundComboBox.SelectedItem) - 1);
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (int.TryParse(teamOneScoreTextBox.Text, out int score1) == false)
            {
                output = false;
            }
            else if (score1 < 0)
            {
                output = false;
            }

            if (int.TryParse(teamTwoScoreTextBox.Text, out int score2) == false)
            {
                output = false;
            }
            else if (score2 < 0)
            {
                output = false;
            }

            if (score1 == score2)
            {
                output = false;
            }

            return output;
        }

        private void DisplayMatch()
        {
            bool isVisible = matchListBox.DataSource != null;
            teamOneNameLabel.Visible = isVisible;
            teamOneScoreLabel.Visible = isVisible;
            teamOneScoreTextBox.Visible = isVisible;

            versusLabel.Visible = isVisible;

            teamTwoNameLabel.Visible = isVisible;
            teamTwoScoreLabel.Visible = isVisible;
            teamTwoScoreTextBox.Visible = isVisible;
            scoreButton.Visible = isVisible;

            bool isEnable = (activeRoundIndex == Convert.ToInt32(roundComboBox.SelectedItem) - 1);

            if (tournamentFinished)
            {
                unPlayedOnlyCheckBox.Enabled = false;
                unPlayedOnlyCheckBox.Checked = false;
                isEnable = false;
            }
            else if (selectedMatch.Entries.Count == 1)
            {
                //to check the match is not a bye
                isEnable = false;
            }

            teamOneScoreTextBox.Enabled = isEnable;
            teamTwoScoreTextBox.Enabled = isEnable;
            scoreButton.Enabled = isEnable;

        }
    }
}
