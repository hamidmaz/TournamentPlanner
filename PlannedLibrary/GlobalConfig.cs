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
        public static IDataConnection Connection { get; private set; } 

        public static void InitializeConnections(DatabaseType connectionType)
        {
            // TIDO make enum for connectionType
            switch (connectionType)
            {
                case DatabaseType.SQL:
                    {
                        //TODO creat SQL connection
                        SqlConnector sql = new SqlConnector();
                        Connection = sql;
                        break;
                    }
                case DatabaseType.textFile:
                    {
                        //TODO creat text file connection
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
    }
}
