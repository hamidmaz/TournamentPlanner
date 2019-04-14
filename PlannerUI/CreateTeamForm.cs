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
    public partial class CreateTeamForm : Form
    {
        private List<Player> availablePlayers = new List<Player>();
        private List<Player> selectedPlayers = new List<Player>();

        public ITeamRequestor CallingForm { get; set; }


        public CreateTeamForm(ITeamRequestor callingForm)
        {
            this.CallingForm = callingForm;
            InitializeComponent();
            InitializeFieldsValue();
            
            WireUpLists();
        }


        private void CreateTestData()
        {
            availablePlayers.Add(new Player("h1","m1","h1m1@noobnoob.edu","1616514"));
            availablePlayers.Add(new Player("h2", "m2", "h2m2@noobnoob.edu", "154684"));
            availablePlayers.Add(new Player("h3", "m3", "h3m3@noobnoob.edu", "145684894"));

            selectedPlayers.Add(new Player("h4", "m4", "h3m3@noobnoob.edu", "145684894"));
            selectedPlayers.Add(new Player("h5", "m5", "h3m3@noobnoob.edu", "145684894"));
            selectedPlayers.Add(new Player("h6", "m6", "h3m3@noobnoob.edu", "145684894"));

        }


        private void addNewplayerButton_Click(object sender, EventArgs e)
        {
            if (ValidateNewMemberForm())
            {
                Player model = new Player(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    emailTextBox.Text,
                    mobileNrTextBox.Text);

                GlobalConfig.Connection.CreatePlayer(model);

                CleanNewMemberFields();

                // Add the new player to the team members list
                selectedPlayers.Add(model);
                WireUpLists();
            }
            else
            {
                MessageBox.Show("Invalid inputs for the new player!");
            }
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            Player selectedP = selectPlayerComboBox.SelectedItem as Player;

            // check to make sure sth is selected and the obj is not null
            if (selectedP != null)
            {
                selectedPlayers.Add(selectedP);
                availablePlayers.Remove(selectedP);
                WireUpLists(); 
            }
        }
        private void removeSelectedTeamMembersButton_Click(object sender, EventArgs e)
        {
            Player selectedP = teamMembersListBox.SelectedItem as Player;

            // check to make sure sth is selected and the obj is not null
            if (selectedP != null)
            {
                selectedPlayers.Remove(selectedP);
                availablePlayers.Add(selectedP);
                WireUpLists(); 
            }
        }

        private void createTeamButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Team model = new Team(
                    teamNameTextBox.Text,
                    selectedPlayers);

                GlobalConfig.Connection.CreateTeam(model);

                CallingForm.TeamComplete(model);
                this.Close();

                InitializeFieldsValue();
                WireUpLists();
            }
            else
            {
                MessageBox.Show("Invalid inputs!");
            }
        }


        private bool ValidateNewMemberForm()
        {
            bool output = true;

            if (firstNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (lastNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (emailTextBox.Text.Length == 0)
            {
                output = false;
            }
            else
            {
                string[] firstSplit = emailTextBox.Text.Split('@');
                if (firstSplit.Length !=2 || (firstSplit[0].Length == 0))
                {
                    output = false;
                }
                else
                {
                    string[] secondSplit = firstSplit[1].Split('.');
                    if (secondSplit.Length <2 || (secondSplit[0].Length == 0) || (secondSplit[secondSplit.Length-1].Length == 0))
                    {
                        output = false;
                    }
                }
            }
            


            return output;
        }
        private bool ValidateForm()
        {
            bool output = true;
            
            if (teamNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (selectedPlayers.Count == 0)
            {
                output = false;
            }

            return output;
        }
        

        private void WireUpLists()
        {
            // if you do not set the datasource of a comboBox to null
            //before the main values, it will not be updated every time
            // you change it and will only work the first time! Do not know why...
            selectPlayerComboBox.DataSource = null;
            selectPlayerComboBox.DataSource = availablePlayers;
            selectPlayerComboBox.DisplayMember = "FullName";

            teamMembersListBox.DataSource = null;
            teamMembersListBox.DataSource = selectedPlayers;
            teamMembersListBox.DisplayMember = "FullName";
            
        }
        private void InitializeFieldsValue()
        {
            teamNameTextBox.Text = "";
            availablePlayers = GlobalConfig.Connection.GetPeople_All();
            selectedPlayers.Clear();
        }
        private void CleanNewMemberFields()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            mobileNrTextBox.Text = "";

        }





    }
}
