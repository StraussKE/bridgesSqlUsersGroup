using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bridgesSqlUsersGroup.Models;

namespace bridgesSqlUsersGroup.Repsoitories
{
    public class EFGroupEventRepository : IGroupEventRepository
    {
        private AppIdentityDbContext context;

        public EFGroupEventRepository(AppIdentityDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<GroupEvent> GroupEvents => context.GroupEvents;


        public void AddGroupEvent(GroupEvent groupEvent)
        {
            context.Add(groupEvent);
            context.SaveChanges();
        }
    }
}
