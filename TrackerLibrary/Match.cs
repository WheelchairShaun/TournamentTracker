using System.Collections.Generic;

namespace TrackerLibrary
{
    public class Match
    {
        /// <summary>
        /// Represents the competitors in this match
        /// </summary>
        public List<MatchEntry> Entries { get; set; }
        /// <summary>
        /// Represents the winner of this match
        /// </summary>
        public Team Winner { get; set; }
        /// <summary>
        /// Represents which round this match is
        /// </summary>
        public int Round { get; set; }
    }
}