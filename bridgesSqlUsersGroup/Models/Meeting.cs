using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace bridgesSqlUsersGroup.Models
{
    public class Meeting
    {
        [Key]
        public Guid MeetingId { get; set; }
        public DateTime MeetingDate { get; set; }
        public string Location { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }

        public List<Review> Reviews {get;set;} // reviews are a pain and I do not love them

        public virtual List<MeetingSpeaker> MeetingSpeakers { get; set; }
        public virtual List<MeetingTag> MeetingTags { get; set; }
        public virtual List<MeetingSponsor> MeetingSponsors { get; set; }
        public virtual List<UserMeeting> MeetingAtendees { get; set; }

        public virtual List<Dictionary<User, int>> MeetingRatings { get; set; } // UserID and rating
    }
}
