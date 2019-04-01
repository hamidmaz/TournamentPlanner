using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannedLibrary
{
    public interface IDataConnection
    {
        /// <summary>
        /// It save the input prize and pass it with an Id populated for it
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        Prize CreatPrize(Prize model);
    }
}
