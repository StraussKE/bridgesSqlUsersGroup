using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bridgesSqlUsersGroup.Models;

namespace bridgesSqlUsersGroup.Repsoitories
{
    public interface ITagRepository
    {
        IQueryable<Tag> Tags { get; }

        void AddTag(Tag tag);
    }
}
