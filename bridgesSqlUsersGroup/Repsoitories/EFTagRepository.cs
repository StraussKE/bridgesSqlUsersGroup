using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bridgesSqlUsersGroup.Models;

namespace bridgesSqlUsersGroup.Repsoitories
{
    public class EFTagRepository : ITagRepository
    {
        private AppIdentityDbContext context;

        public EFTagRepository(AppIdentityDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Tag> Tags => context.Tags;


        public void AddTag(Tag tag)
        {
            context.Add(tag);
            context.SaveChanges();
        }
    }
}
