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

        public virtual List<Speaker> MeetingSpeakers { get; set; }
        public virtual List<Tag> MeetingTags { get; set; }
        public virtual List<Sponsor> MeetingSponsors { get; set; }
        public virtual List<User> MeetingAtendees { get; set; }

        public virtual List<Dictionary<User, int>> MeetingRatings { get; set; } // UserID and rating
        public virtual List<Dictionary<User, string>> MeetingReviews { get; set; } // UserID and review body
    }
}
