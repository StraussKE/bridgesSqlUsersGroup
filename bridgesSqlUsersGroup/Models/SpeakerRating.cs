using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bridgesSqlUsersGroup.Models
{
    public class SpeakerRating
    {
        [Key]
        public Dictionary<User, Speaker> Key { get; set; }

        public int SRating { get; set; }

    }
}
