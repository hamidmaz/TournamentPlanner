using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlannedLibrary.DataAccess.TextProcessors;
using PlannedLibrary.Models;

namespace PlannedLibrary.DataAccess
{
    public class TextFileConnector : IDataConnection
    {
        /// <summary>
        /// Save the new prize to a txt file and pass it with its unique identifier
        /// </summary>
        /// <param name="model"> The new prize</param>
        /// <returns> The prize with a unique identifier</returns>

        private const string PrizesFileName = "Prizes.csv";
        private const string PlayersFileName = "People.csv";

        public Prize CreatePrize(Prize model)
        {
            // Load the text file and convert it to a list of prizes

            List<Prize> prizesList = PrizesFileName.LoadFile().ConvertToPrizes();

            //find the last id
            int lastId = 0;
            if (prizesList.Count != 0)
            {
                lastId = prizesList[prizesList.Count - 1].Id;
                
            }
            model.Id = lastId + 1;
            // save the new one at the end of the file

            prizesList.Add(model);

            prizesList.ConvertPrizesToString().SaveFile(PrizesFileName);
            return model;
        }

        // TODO implement the following
        public Player CreatePlayer(Player model)
        {
            // Load the text file and convert it to a list of prizes

            List<Player> playersList = PlayersFileName.LoadFile().ConvertToPlayers();

            //find the last id
            int lastId = 0;
            if (playersList.Count != 0)
            {
                lastId = playersList[playersList.Count - 1].Id;

            }
            model.Id = lastId + 1;
            // save the new one at the end of the file

            playersList.Add(model);

            playersList.ConvertPlayersToString().SaveFile(PlayersFileName);
            return model;
        }
    }
}
