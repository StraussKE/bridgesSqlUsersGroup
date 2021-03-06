﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bridgesSqlUsersGroup.Models
{
    public class Tag
    {
        public int TagId { get; set; }
        
        // string value of the tag
        public string TagName { get; set; }

        // list of events that share this tag
        public virtual List<Event> TaggedEvents { get; set; }
    }
}
