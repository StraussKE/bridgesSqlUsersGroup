using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bridgesSqlUsersGroup.Models
{
    public class Tag
    {
        public Guid TagId { get; set; }
        
        // string value of the tag
        public string TagName { get; set; }

        // list of Meetings that share this tag
        public virtual List<MeetingTag> TaggedMeetings { get; set; }
    }
}
