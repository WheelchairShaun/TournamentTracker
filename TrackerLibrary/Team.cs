using System.Collections.Generic;

namespace TrackerLibrary
{
    public class Team
    {
        /// <summary>
        /// The list of players on this team
        /// </summary>
        public List<Player> MyProperty { get; set; } = new List<Player>();
        /// <summary>
        /// The name of this team
        /// </summary>
        public string Name { get; set; }
    }
}