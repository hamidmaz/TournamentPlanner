using PlannedLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannedLibrary
{
    public static class GlobalConfig
    {
        public const string PrizesFileName = "Prizes.csv";
        public const string PlayersFileName = "People.csv";
        public const string TeamsFileName = "Teams.csv";
        public const string TournamentsFileName = "Tournaments.csv";
        public const string MatchesFileName = "Matches.csv";
        public const string MatchEntriesFileName = "MatchEntries.csv";

        public static IDataConnection Connection { get; private set; } 

        public static void InitializeConnections(DatabaseType connectionType)
        {
            // TIDO make enum for connectionType
            switch (connectionType)
            {
                case DatabaseType.PostgreSQL:
                    {
                        
                        PostgreSQLConnector pgSql = new PostgreSQLConnector();
                        Connection = pgSql;
                        break;
                    }
                case DatabaseType.SQL:
                    {
                        
                        SqlConnector sql = new SqlConnector();
                        Connection = sql;
                        break;
                    }
                case DatabaseType.TextFile:
                    {
                        TextFileConnector txt = new TextFileConnector();
                        Connection = txt;
                        break;
                    }
                default:
                    break;
            }
            
        }

        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;

        }

        public static string AppKeyLookUp (string key)
        {

            return ConfigurationManager.AppSettings[key];
        }
    }
}
