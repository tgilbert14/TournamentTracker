using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class TeamModel
    {
        //TYPING 'PROP' AND HITTING DOUBLE TAB
        //LIST OF PEOPLE FOR FOR EACH TEAM = INITIALIZE TEAMMEMBERS
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        //STING FOR TEAM NAME
        public string TeamName { get; set; }
    }
}
