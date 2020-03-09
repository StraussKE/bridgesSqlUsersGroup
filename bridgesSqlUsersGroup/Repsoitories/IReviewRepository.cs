using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bridgesSqlUsersGroup.Models;

namespace bridgesSqlUsersGroup.Repsoitories
{
    public interface IReviewRepository
    {
        IQueryable<Review> Review { get; }

        void AddReview(Guid thingReviewedId, Review review);

    }
}
