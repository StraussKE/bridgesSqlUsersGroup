using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bridgesSqlUsersGroup.Models;

namespace bridgesSqlUsersGroup.Repsoitories
{
    public class EFSpeakerRepository : ISpeakerRepository
    {
        private AppIdentityDbContext context;

        public EFSpeakerRepository(AppIdentityDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Speaker> Speakers => context.Speakers;

        public void AddSpeaker(Speaker speaker)
        {
            context.Add(speaker);
            context.SaveChanges();
        }
    }
}
