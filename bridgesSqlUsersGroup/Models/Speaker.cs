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

        // list of Meetings this speaker has spoken at
        public virtual List<MeetingSpeaker> MeetingsSpokenAt { get; set; }

        //public virtual List<Dictionary<User, int>> SpeakerRatings { get; set; } // UserID and 

        public List<Review> Reviews { get; set; } // UserID and review body
    }
}
