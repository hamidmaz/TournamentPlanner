﻿using PlannedLibrary.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//We add an extra ".TextConnector" to the end of the namespace
// to make the access to the methods of it more limited especially
// the extension for the string type in FullFilePath method
namespace PlannedLibrary.DataAccess.TextProcessors
{
    public static class TextFileProcessor
    {
        // "this" keyword in the input make the method an extension for 
        //string type which is only available in this namespace
        public static string FullFilePath (this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }


        /// <summary>
        /// load a file and return a list of strings each contains a line of the text file
        /// </summary>
        /// <param name="file"> file name, not the full file path</param>
        /// <returns></returns>
        public static List<string> LoadFile (this string fileName)
        {
            if (!File.Exists(fileName.FullFilePath()))
            {
                return new List<string>();
            }
            else
            {
                return File.ReadAllLines(fileName.FullFilePath()).ToList();
            }    
        }

        /// <summary>
        /// Get a list of strings each contains a line of the text file and save it to the file
        /// </summary>
        /// <param name="file"> file name, not the full file path</param>
        /// <returns></returns>
        public static void SaveFile (this List<string> lines, string fileName)
        {
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }

        public static List<Prize> ConvertToPrizes(this List<string> lines)
        {
            List<Prize> outputList = new List<Prize>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                Prize p = new Prize(cols[1], cols[2], cols[3], cols[4]);
                p.Id = Convert.ToInt32(cols[0]);

                outputList.Add(p);
            }
            return outputList;
        }

        public static List<string> ConvertPrizesToString(this List<Prize> prizesList)
        {
            List<string> outputStringList = new List<string>();
            foreach (Prize p in prizesList)
            {
                outputStringList.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.Amount},{p.Percentage}");
            }
            return outputStringList;
        }

        public static List<Player> ConvertToPlayers(this List<string> lines)
        {
            List<Player> outputList = new List<Player>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                Player p = new Player(cols[1], cols[2], cols[3], cols[4]);
                p.Id = Convert.ToInt32(cols[0]);
                
                outputList.Add(p);
            }
            return outputList;
        }

        public static List<string> ConvertPlayersToString(this List<Player> playersList)
        {
            List<string> outputStringList = new List<string>();
            foreach (Player p in playersList)
            {
                outputStringList.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNr}");
            }
            return outputStringList;
        }






    }
}