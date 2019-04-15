using System;

namespace PlannedLibrary.Models
{
    public class Player
    {
        

        /// <summary>
        /// The unique identifier for the prize
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of the place
        /// </summary>

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string EmailAddress { get; set; }
        /// <summary>
        /// The players cellphone number
        /// </summary>
        public string CellphoneNr { get; set; }

        

        public Player(string firstName, string lastName, string emailAddress, string cellphoneNr)
            :this(0, firstName, lastName, emailAddress, cellphoneNr)
        {
        }

        public Player(int id, string firstName, string lastName, string emailAddress, string cellphoneNr)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EmailAddress = emailAddress;
            this.CellphoneNr = cellphoneNr;
        }

        public Player()
        {
        }

        public string FUllName
        {
            get
            {
                return $"{this.FirstName} {this.LastName}";
            }
        }

        
    }
}
