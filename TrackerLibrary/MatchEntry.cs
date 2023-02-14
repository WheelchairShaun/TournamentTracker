namespace TrackerLibrary
{
    public class MatchEntry
    {
        /// <summary>
        /// Represents one team in the match
        /// </summary>
        public Team Competitor { get; set; }
        /// <summary>
        /// Represents this competitor's score
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Represents the match that this competitor came from as the winner
        /// </summary>
        public Match ParentMatch { get; set; }
    }
}