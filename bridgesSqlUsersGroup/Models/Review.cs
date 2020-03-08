using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bridgesSqlUsersGroup.Models
{
    public class Review
    {
        public int ReviewId { get; set; }
        public User Author { get; set; }
        public List<Review> SubReviews { get; set; }
        public string ReviewContents { get; set; }

        Review(string contents)
        {
            ReviewContents = contents;
        }

        void AddSubReview(string contents)
        {
            SubReviews.Add(new Review(contents));
        }
    }
}
