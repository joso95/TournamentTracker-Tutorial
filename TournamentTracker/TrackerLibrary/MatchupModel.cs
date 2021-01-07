using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        /// <summary>
        /// Lager en liste over lag
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Den som vinnner
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Hvilken runde som foregår
        /// </summary>
        public int MatchupRound { get; set; }
    }
}
