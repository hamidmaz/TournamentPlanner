﻿using PlannedLibrary;
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
    public partial class CreatTournamentForm : Form, IPrizeRequestor, ITeamRequestor
    {
        List<Team> availableTeams = new List<Team>();
        List<Team> selectedTeams = new List<Team>();
        List<Prize> tournamentPrizes = new List<Prize>();

        public ITournamentRequestor CallingForm { get; set; }
        public CreatTournamentForm(ITournamentRequestor callingForm)
        {
            CallingForm = callingForm;
            InitializeComponent();
            InitializeFieldsValue();
            WireUpLists();
        }

        private void WireUpLists()
        {
            // if you do not set the datasource of a comboBox to null
            //before the main values, it will not be updated every time
            // you change it and will only work the first time! Do not know why...
            selectTeamListBox.DataSource = null;
            selectTeamListBox.DataSource = availableTeams;
            selectTeamListBox.DisplayMember = "TeamName";

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
            //call the create prize form
            CreateTeamForm frm = new CreateTeamForm(callingForm: this);
            frm.Show();

            // get the new prize: it happens automatically inside the creatpirze form
            // when the PrizeComplete method from here is being called.
        }


        private void addTeamButton_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedT = selectTeamListBox.SelectedItems;

            // check to make sure sth is selected and the obj is not null
            if (selectedT != null)
            {
                foreach (Team t in selectedT)
                {
                    selectedTeams.Add(t);
                    availableTeams.Remove(t);
                }
                WireUpLists();
            }
        }
        private void removeSelectedTeamsButton_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedT = tournamentTeamsListBox.SelectedItems;

            // check to make sure sth is selected and the obj is not null
            if (selectedT != null)
            {
                foreach (Team t in selectedT)
                {
                    selectedTeams.Remove(t);
                    availableTeams.Add(t);
                }
                WireUpLists();
            }
            
        }


        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            //call the create prize form
            CreatePrizeForm frm = new CreatePrizeForm(callingForm: this);
            frm.Show();

            // get the new prize: it happens automatically inside the creatpirze form
            // when the PrizeComplete method from here is being called.

        }
        public void PrizeComplete(Prize model)
        {
            tournamentPrizes.Add(model);
            //add the prize to the related list
            WireUpLists();
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

        public void TeamComplete(Team model)
        {
            selectedTeams.Add(model);
            //add the prize to the related list
            WireUpLists();
        }

        private void createTournamentButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Tournament model = new Tournament();
                model.TournamentName = tournamentNameTextBox.Text;
                model.EntryFee = Convert.ToDecimal(EntryFeeTextBox.Text);
                model.Teams = selectedTeams;
                model.Prizes = tournamentPrizes;

                //Wire up matches
                TournamentLogic.CreateRounds(model);

                GlobalConfig.Connection.CreateTournament(model);

                TournamentLogic.AlertAllUsersOfNewRound(model, 0);
                CallingForm.TournamentComplete(model);
                
                //InitializeFieldsValue();
                //WireUpLists();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid inputs!");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;

            if (tournamentNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (int.TryParse(EntryFeeTextBox.Text, out int entryFee) == false)
            {
                output = false;
            }
            else if (entryFee < 0)
            {
                output = false;
            }
            
            return output;
        }        
    }
}
