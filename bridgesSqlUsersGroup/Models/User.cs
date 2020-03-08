using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace bridgesSqlUsersGroup.Models
{
    public class User : IdentityUser
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedAccount { get; set; }

        // list of events that the user has attended
        public virtual List<Event> AttendedEvents { get; set; }

        // list of reviews that the user has written for events
        public virtual List<Dictionary<Event, string>> ReviewedEvents { get; set; }

        // list of reviews that the user has written for speakers
        public virtual List<Dictionary<Speaker, string>> ReviewedSpeakers { get; set; }
    }
}
