using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannedLibrary
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>(); 

        public static void InitializeConnections(bool database, bool textFile)
        {
            if (database)
            {
                //TODO creat SQL connection
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFile)
            {
                //TODO creat text file connection
                TextFileConnector txt = new TextFileConnector();
                Connections.Add(txt);
            }
        }
    }
}
