using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// represent a team of the tournament
    /// </summary>
    public class TeamModel
    {
        /// <summary>
        /// represent members of the team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
        /// <summary>
        /// represent the name of the team
        /// </summary>
        public String TeamName { get; set; }
    }
}
