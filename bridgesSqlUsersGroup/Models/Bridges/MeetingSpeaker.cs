using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bridgesSqlUsersGroup.Models
{
    public class MeetingSpeaker
    {
        public Guid MeetingId { get; set; }
        public Meeting Meeting { get; set; }

        public Guid SpeakerId { get; set; }
        public Speaker Speaker { get; set; }
    }
}
