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

        void AddReview(Speaker speaker, Review review);

        void AddReview(Speaker speaker, Review parent, Review child);
    }
}
