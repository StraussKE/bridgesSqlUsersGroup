using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bridgesSqlUsersGroup.Models
{
    public class ReviewSpeaker : Review
    {
        public Guid SpeakerId { get; set; }
        public Meeting Speaker { get; set; }

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
