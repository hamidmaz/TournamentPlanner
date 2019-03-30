using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannedLibrary
{
    public class Prize
    {
        /// <summary>
        /// The name of the place
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// The number of the place
        /// </summary>
        public string PlaceName { get; set; }
        /// <summary>
        /// The amount of the prize in dollar
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// The amount of the prize in terms of the percentage of the torunament fund
        /// </summary>
        public int Percentage { get; set; }
    }
}
