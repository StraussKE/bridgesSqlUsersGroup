using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bridgesSqlUsersGroup.Models;

namespace bridgesSqlUsersGroup.Repsoitories
{
    interface IGroupEventRepository
    {
        IQueryable<GroupEvent> GroupEvents { get; }

        void AddGroupEvent (GroupEvent groupEvent);
    }
}
