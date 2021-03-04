using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// represent one team in the matchup
    /// </summary>
    public class MatchupEntryModel
    {
        /// <summary>
        /// represent one team in the matchup.
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// represent score of team.
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// represent matchup that this team came
        /// from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
