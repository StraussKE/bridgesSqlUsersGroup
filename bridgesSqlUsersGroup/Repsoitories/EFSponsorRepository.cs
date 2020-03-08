using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bridgesSqlUsersGroup.Models;

namespace bridgesSqlUsersGroup.Repsoitories
{
    public class EFSponsorRepository : ISponsorRepository
    {
        private AppIdentityDbContext context;

        public EFSponsorRepository(AppIdentityDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Sponsor> Sponsors => context.Sponsors;


        public void AddSponsor(Sponsor sponsor)
        {
            context.Add(sponsor);
            context.SaveChanges();
        }
    }
}
