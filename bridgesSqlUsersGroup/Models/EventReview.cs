using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bridgesSqlUsersGroup.Models
{
    public class EventReview
    {
        [Key]
        public int EventReviewId { get; set; }

        [ForeignKey("EventId"), Column(Order = 0)]
        public Guid FkEventId { get; set; }

        [ForeignKey("UserId"), Column(Order = 1)]
        public Guid FkUsertId { get; set; }

        public string Review { get; set; }
    }
}
