using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bridgesSqlUsersGroup.Models
{
    public class Sponsor
    {
        public Guid SponsorId { get; set; }
        
        // Sponsor name for either company or private sponsor
        public string Name { get; set; }

        // list of GroupEvents this sponsor has sponsored
        public virtual List<GroupEvent> SponsoredGroupEvents { get; set; }
    }
}
