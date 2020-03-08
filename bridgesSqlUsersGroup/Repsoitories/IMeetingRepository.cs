using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bridgesSqlUsersGroup.Models;

namespace bridgesSqlUsersGroup.Repsoitories
{
    interface IMeetingRepository
    {
        IQueryable<Meeting> Meetings { get; }

        void AddMeeting (Meeting meeting);
    }
}
