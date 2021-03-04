using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// represent one match of the tournament
    /// </summary>
    public class MatchupModel
    {
        /// <summary>
        /// set of teams that were in this match
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// winner of this match
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// which round this match was part of
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
