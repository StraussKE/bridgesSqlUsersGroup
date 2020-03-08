using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bridgesSqlUsersGroup.Models
{
    public class MeetingSponsor
    {
        public Guid MeetingId { get; set; }
        public Meeting Meeting { get; set; }

        public Guid SponsorId { get; set; }
        public Sponsor Sponsor { get; set; }
    }
}
