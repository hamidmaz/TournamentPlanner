using PlannedLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlannerUI
{
    static class EntryPoint
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Initialize the dataBase: select either textfile or postgres
            GlobalConfig.InitializeConnections(DatabaseType.TextFile);

            Application.Run(new TournamentDashboardForm());

        }
    }
}
