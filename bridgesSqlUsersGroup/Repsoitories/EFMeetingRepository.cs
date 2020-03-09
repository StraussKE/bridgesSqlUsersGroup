using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bridgesSqlUsersGroup.Models;

namespace bridgesSqlUsersGroup.Repsoitories
{
    public class EFMeetingRepository : IMeetingRepository
    {
        private AppIdentityDbContext context;

        public IQueryable<Meeting> Meetings => context.Meetings;
        public EFMeetingRepository(AppIdentityDbContext ctx)
        {
            context = ctx;
        }

        public void AddMeeting(Meeting meeting)
        {
            context.Add(meeting);
            context.SaveChanges();
        }

        public void AddReview(Meeting meeting, Review review)
        {
            meeting.Reviews.Add(review);
            context.Meetings.Update(meeting);
            context.SaveChanges();
        }

        public void AddReview(Meeting meeting, Review parent, Review child)
        {
            parent.SubReviews.Add(child);
            context.Meetings.Update(meeting);
            context.SaveChanges();
        }
    }
}
