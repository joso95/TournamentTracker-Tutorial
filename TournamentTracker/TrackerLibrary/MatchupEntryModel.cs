using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Representerer et lag i mathcup'en
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Representerer poengene til et partikulert lag
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Representerer mathcup'en som laget kom fra som vinnere
        /// </summary>
        public  MatchupModel ParentMatchup { get; set; }
    }
}
