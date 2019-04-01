using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlannedLibrary.Models;

namespace PlannedLibrary.DataAccess
{
    public class TextFileConnector : IDataConnection
    {
        // TODO impelement CreatePrize to save new prize to text file
        /// <summary>
        /// Save the new prize to a txt file and pass it with its unique identifier
        /// </summary>
        /// <param name="model"> The new prize</param>
        /// <returns> The prize with a unique identifier</returns>
        public Prize CreatePrize(Prize model)
        {
            throw new NotImplementedException();
        }
        
    }
}
