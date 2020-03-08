using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bridgesSqlUsersGroup.Models;

namespace bridgesSqlUsersGroup.Repsoitories
{
    public class EFMeetingRepository : IMeetingRepository
    {
        private AppIdentityDbContext context;

        public EFMeetingRepository(AppIdentityDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Meeting> Meetings => context.Meetings;


        public void AddMeeting(Meeting meeting)
        {
            context.Add(meeting);
            context.SaveChanges();
        }
    }
}
