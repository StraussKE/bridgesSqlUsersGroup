using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace bridgesSqlUsersGroup.Models
{
    public class NewGroupEvent
    {
        [Required]
        DateTime GroupEventDate { get; set; }

        [Required]
        String Location { get; set; }

        [Required(ErrorMessage = "Please enter a topic")]
        [MaxLength(60, ErrorMessage ="Your topic name is too long"), MinLength(6, ErrorMessage ="Your topic name is too short")]
        String Topic { get; set; }

        [Required(ErrorMessage = "Please enter an GroupEvent descrition")]
        [MaxLength(3000, ErrorMessage = "Your description must not be more than 3000 characters.")]
        String Description { get; set; }
    }
}
