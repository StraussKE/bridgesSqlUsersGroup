using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bridgesSqlUsersGroup.Models
{
    public class MeetingTag
    {
        public Guid MeetingId { get; set; }
        public Meeting Meeting { get; set; }

        public Guid TagId { get; set; }
        public Tag Tag { get; set; }
    }
}
