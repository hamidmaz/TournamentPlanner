using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannedLibrary
{
    public class SqlConnector : IDataConnection
    {
        // TODO impelement CreatePrize to save new prize to sql
        /// <summary>
        /// Save the new prize to the database and pass it with its unique identifier
        /// </summary>
        /// <param name="model"> The new prize</param>
        /// <returns> The prize with a unique identifier</returns>
        public Prize CreatPrize(Prize model)
        {
            throw new NotImplementedException();
        }
    }
}
