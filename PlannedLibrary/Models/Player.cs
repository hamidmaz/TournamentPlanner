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
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            CellphoneNr = cellphoneNr;
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
