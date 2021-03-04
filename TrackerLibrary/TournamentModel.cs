using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// represent a tournament 
    /// </summary>
    class TournamentModel
    {
        /// <summary>
        /// represent the name of the tournament
        /// </summary>
        public String TournamentName { get; set; }
        /// <summary>
        /// represent the entry fee of tournament
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// represent the entered teams of the tournament
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();
        /// <summary>
        /// represent the prizes allocated for the tournament
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();
        /// <summary>
        /// represent the rounds included in the tournament
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
