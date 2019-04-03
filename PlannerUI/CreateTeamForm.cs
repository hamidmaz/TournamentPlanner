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

        
        public CreateTeamForm()
        {
            InitializeComponent();
            CreateTestData();
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

        private void WireUpLists()
        {
            selectPlayerComboBox.DataSource = availablePlayers;
            selectPlayerComboBox.DisplayMember = "FullName";

            teamMembersListBox.DataSource = selectedPlayers;
            teamMembersListBox.DisplayMember = "FullName";
            
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
            }
            else
            {
                MessageBox.Show("Invalid inputs for the new player!");
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

        private void CleanNewMemberFields()
        {
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            emailTextBox.Text = "";
            mobileNrTextBox.Text = "";

        }
    }
}
