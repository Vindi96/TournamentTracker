using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    /// <summary>
    /// represent prizes allocated 
    /// </summary>
    class PrizeModel
    {
        /// <summary>
        /// represent place number
        /// </summary>
        public int PlaceNumber { get; set; }
        /// <summary>
        /// represent place name related to place number
        /// </summary>
        public String PlaceName { get; set; }
        /// <summary>
        /// represent price amount
        /// </summary>
        public decimal PriceAmount { get; set; }
        /// <summary>
        /// represent the prize percentage acording to tournament income
        /// </summary>
        public double PrizePercentage { get; set; }

    }
}
