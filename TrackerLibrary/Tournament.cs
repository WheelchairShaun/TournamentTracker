using System.Collections.Generic;

namespace TrackerLibrary
{
    public class Tournament
    {
        /// <summary>
        /// The name of this tournament
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The entry fee amount to enter this tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// The list of the teams competing in this tournament
        /// </summary>
        public List<Team> Competitors { get; set; } = new List<Team>();
        /// <summary>
        /// The list of prizes for this tournament
        /// </summary>
        public List<Prize> Prizes { get; set; } = new List<Prize>();
        /// <summary>
        /// The list of rounds in this tournament
        /// </summary>
        public List<List<Match>> Rounds { get; set; } = new List<List<Match>>();
    }
}