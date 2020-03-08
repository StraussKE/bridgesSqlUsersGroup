using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bridgesSqlUsersGroup.Models;

namespace bridgesSqlUsersGroup.Repsoitories
{
    interface ISponsorRepository
    {
        IQueryable<Sponsor> Sponsors { get; }

        void AddSponsor(Sponsor sponsor);
    }
}
