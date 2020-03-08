using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bridgesSqlUsersGroup.Models
{
    public class UserMeeting
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid MeetingId { get; set; }
        public Meeting Meeting { get; set; }
    }
}
