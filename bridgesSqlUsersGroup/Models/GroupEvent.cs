using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace bridgesSqlUsersGroup.Models
{
    public class GroupEvent
    {
        [Key]
        public Guid GroupEventId { get; set; }
        public DateTime GroupEventDate { get; set; }
        public string Location { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }

        public virtual List<Speaker> GroupEventSpeakers { get; set; }
        public virtual List<Tag> GroupEventTags { get; set; }
        public virtual List<Sponsor> GroupEventSponsors { get; set; }
        public virtual List<User> GroupEventAtendees { get; set; }

        public virtual List<Dictionary<User, int>> GroupEventRatings { get; set; } // UserID and rating
        public virtual List<Dictionary<User, string>> GroupEventReviews { get; set; } // UserID and review body
    }
}
