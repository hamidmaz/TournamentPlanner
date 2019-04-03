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
        public CreateTeamForm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
           
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
