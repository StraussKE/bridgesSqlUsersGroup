using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace bridgesSqlUsersGroup.Models
{
    public class SpeakerReview
    {
        [Key]
        public int SpeakerReviewId { get; set; }

        [ForeignKey("SpeakerId"), Column(Order = 0)]
        public Guid FkEventId { get; set; }

        [ForeignKey("UserId"), Column(Order = 1)]
        public Guid FkUsertId { get; set; }

        public string Review { get; set; }
    }
}
