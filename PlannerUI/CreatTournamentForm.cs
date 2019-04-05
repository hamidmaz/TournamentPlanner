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
    public partial class CreatTournamentForm : Form, IPrizeRequestor
    {
        List<Team> availableTeams = new List<Team>();
        List<Team> selectedTeams = new List<Team>();
        List<Prize> tournamentPrizes = new List<Prize>();

        public CreatTournamentForm()
        {
            InitializeComponent();
            InitializeFieldsValue();
            WireUpLists();
        }

        private void WireUpLists()
        {
            // if you do not set the datasource of a comboBox to null
            //before the main values, it will not be updated every time
            // you change it and will only work the first time! Do not know why...
            selectTeamComboBox.DataSource = null;
            selectTeamComboBox.DataSource = availableTeams;
            selectTeamComboBox.DisplayMember = "TeamName";

            tournamentTeamsListBox.DataSource = null;
            tournamentTeamsListBox.DataSource = selectedTeams;
            tournamentTeamsListBox.DisplayMember = "TeamName";

            tournamentPrizesListBox.DataSource = null;
            tournamentPrizesListBox.DataSource = tournamentPrizes;
            tournamentPrizesListBox.DisplayMember = "PlaceName";

        }
        private void InitializeFieldsValue()
        {
            tournamentNameTextBox.Text = "";
            EntryFeeTextBox.Text = "0";
            availableTeams = GlobalConfig.Connection.GetTeams_All();
            selectedTeams.Clear();
            tournamentPrizes.Clear();
        }


        private void creatNewTeamlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            Team selectedT = selectTeamComboBox.SelectedItem as Team;

            // check to make sure sth is selected and the obj is not null
            if (selectedT != null)
            {
                selectedTeams.Add(selectedT);
                availableTeams.Remove(selectedT);
                WireUpLists();
            }
        }

        private void removeSelectedTeamsButton_Click(object sender, EventArgs e)
        {
            Team selectedT = tournamentTeamsListBox.SelectedItem as Team;

            // check to make sure sth is selected and the obj is not null
            if (selectedT != null)
            {
                selectedTeams.Remove(selectedT);
                availableTeams.Add(selectedT);
                WireUpLists();
            }
        }

        public void PrizeComplete(Prize model)
        {
            tournamentPrizes.Add(model);
            //add the prize to the related list
            WireUpLists();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //call the create prize form
            CreatePrizeForm frm = new CreatePrizeForm(callingForm: this);
            frm.Show();

            // get the new prize: it happens automatically inside the creatpirze form
            // when the PrizeComplete method from here is being called.

        }

        private void removeSelectedPrizesButton_Click(object sender, EventArgs e)
        {
            Prize selectedP = tournamentPrizesListBox.SelectedItem as Prize;

            // check to make sure sth is selected and the obj is not null
            if (selectedP != null)
            {
                tournamentPrizes.Remove(selectedP);
                WireUpLists();
            }

            //TOOD remove from the databse as well
        }
    }
}
