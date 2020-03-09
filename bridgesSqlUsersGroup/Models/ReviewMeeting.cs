using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bridgesSqlUsersGroup.Models
{
    public class ReviewMeeting : Review
    {
        public Guid MeetingId { get; set; }
        public Meeting Meeting { get; set; }

        /*Review(string contents)
        {
            ReviewContents = contents;
        }

        void AddSubReview(string contents)
        {
            SubReviews.Add(new Review(contents));
        }*/
    }
}
