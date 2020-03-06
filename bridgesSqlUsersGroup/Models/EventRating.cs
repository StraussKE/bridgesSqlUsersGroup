using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bridgesSqlUsersGroup.Models
{
    public class EventRating
    {
        [Key]
        public virtual Dictionary<User, Event> Key { get; set; }

        public int ERating { get; set; }

    }
}
