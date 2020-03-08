using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bridgesSqlUsersGroup.Models;

namespace bridgesSqlUsersGroup.Repsoitories
{
    interface ISpeakerRepository
    {
        IQueryable<Speaker> Speakers { get; }

        void AddSpeaker(Speaker speaker);

        void AddReview(Meeting meeting, Review review);

        void AddReview(Meeting meeting, Review parent, Review child);
    }
}
