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

        // list of Meetings that the user has attended
        public virtual List<UserMeeting> AttendedMeetings { get; set; }

        // list of reviews that the user has written for speakers
        public virtual List<UserSpeaker> ReviewedSpeakers { get; set; }
    }
}
