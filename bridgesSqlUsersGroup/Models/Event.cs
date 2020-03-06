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

        // list of ratings in dictionary key/value pairs
        public List<Dictionary<Guid, int>> UserRatings { get; set; }

        // list of reviews for the event
        public List<EventReview> EventReviews { get; set; } // UserID and review body
    }
}
