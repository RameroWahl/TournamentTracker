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
        /// Represents 1 team
        /// </summary>
        public TeamModel TeamCompeting { get; set; }
        /// <summary>
        /// Score for this team
        /// </summary>
        public double Score { get; set; }
        /// <summary>
        /// Who the team beat/lost against
        /// </summary>
        public MatchupModel ParenMatchup { get; set; } 
    }
}
