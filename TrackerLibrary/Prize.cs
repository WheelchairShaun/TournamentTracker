namespace TrackerLibrary
{
    public class Prize
    {
        /// <summary>
        /// Represents the place that wins this prize
        /// </summary>
        public int Place { get; set; }
        /// <summary>
        /// The name of this prize
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The amount awarded by this prize
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// The percentage of the total entry fees award by this prize
        /// </summary>
        public double Percentage { get; set; }
    }
}