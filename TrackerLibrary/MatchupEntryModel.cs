using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class MatchupEntryModel
    {
        /// <summary>
        /// Represents one team in the matchup
        /// </summary>
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for particular team
        /// </summary>
        public double score { get; set; }
        /// <summary>
        /// Represents the matchup that this tram came
        /// from as a Winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
