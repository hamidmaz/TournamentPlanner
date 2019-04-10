using PlannedLibrary;
using PlannedLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlannerUI
{
    public partial class TournamentDashboardForm : Form, ITournamentRequestor
    {
        private List<Tournament> availableTournaments = new List<Tournament>();
        private Tournament selectedTournamet = new Tournament();

        public TournamentDashboardForm()
        {
            InitializeComponent();
            InitializeFieldsValue();
            WireUpLists();
        }

        private void loadTournamentButton_Click(object sender, EventArgs e)
        {
            // TODO load tourament completely with SQL
            selectedTournamet = selectTournamentComboBox.SelectedItem as Tournament;
            TournamentViewerForm frm = new TournamentViewerForm(selectedTournamet);
            frm.Show();
        }

        private void WireUpLists()
        {
            // if you do not set the datasource of a comboBox to null
            //before the main values, it will not be updated every time
            // you change it and will only work the first time! Do not know why...
            selectTournamentComboBox.DataSource = null;
            selectTournamentComboBox.DataSource = availableTournaments;
            selectTournamentComboBox.DisplayMember = "TournamentName";


        }
        private void InitializeFieldsValue()
        {
            
            availableTournaments = GlobalConfig.Connection.GetTournament_All();
            
        }

        private void createNewTournamentButton_Click(object sender, EventArgs e)
        {
            //call the create prize form
            CreatTournamentForm frm = new CreatTournamentForm(callingForm: this);
            frm.Show();

            // get the new prize: it happens automatically inside the creatpirze form
            // when the PrizeComplete method from here is being called.
        }

        public void TournamentComplete(Tournament model)
        {
            availableTournaments.Add(model);
            //add the prize to the related list
            WireUpLists();
        }
    }
}
