using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bridgesSqlUsersGroup.Models
{
    public class Speaker
    {
        public Guid SpeakerId { get; set; }

        // Speaker's name
        public string SpeakerName { get; set; }

        // Speaker's title eg. CEO of company, Expert in whatever
        public string SpeakerTitle { get; set; }

        // Biographical details for the speaker
        public string SpeakerBio { get; set; }

        // list of GroupEvents this speaker has spoken at
        public virtual List<GroupEvent> GroupEventsSpokenAt { get; set; }

        public virtual List<Dictionary<User, int>> SpeakerRatings { get; set; } // UserID and rating
        public virtual List<Dictionary<User, string>> SpeakerReviews { get; set; } // UserID and review body
    }
}
