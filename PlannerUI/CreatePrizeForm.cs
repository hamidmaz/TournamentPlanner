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
    public partial class CreatePrizeForm : Form
    {
        public CreatePrizeForm()
        {
            InitializeComponent();
        }

        private void createPrizeButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Prize model = new Prize(
                    placeNumberTextBox.Text,
                    placeNameTextBox.Text,
                    prizeAmountTextBox.Text,
                    prizePercentageTextBox.Text);

                GlobalConfig.Connection.CreatePrize(model);
                
                CleanFields();
            }
            else
            {
                MessageBox.Show("Invalid inputs!");
            }
        }

        private bool ValidateForm()
        {
            bool output = true;
            if (int.TryParse(placeNumberTextBox.Text, out int placeNumber) == false)
            {
                output = false;
            }
            else if (placeNumber < 1)
            {
                output = false;
            }

            if (placeNameTextBox.Text.Length == 0)
            {
                output = false;
            }

            if (decimal.TryParse(prizeAmountTextBox.Text, out decimal prizeAmount) == false)
            {
                output = false;
            }


            if (double.TryParse(prizePercentageTextBox.Text, out double prizePercentage) == false)
            {
                output = false;
            }

            if (prizeAmount <= 0 && (prizePercentage <= 0 || prizePercentage > 100))
            {
                output = false;
            }


            return output;
        }

        private void CleanFields()
        {
            placeNumberTextBox.Text = "";
            placeNameTextBox.Text = "";
            prizeAmountTextBox.Text = "0";
            prizePercentageTextBox.Text = "0";

        }
    }
}
