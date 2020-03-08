using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace bridgesSqlUsersGroup.Models
{
    public class Event
    {
        [Key]
        public Guid EventId { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; }
        public string Topic { get; set; }
        public string Description { get; set; }

        public virtual List<Speaker> EventSpeakers { get; set; }
        public virtual List<Tag> EventTags { get; set; }
        public virtual List<Sponsor> EventSponsors { get; set; }
        public virtual List<User> EventAtendees { get; set; }

        public virtual List<Dictionary<User, int>> EventRatings { get; set; } // UserID and rating
        public virtual List<Dictionary<User, string>> EventReviews { get; set; } // UserID and review body
    }
}
