using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace bridgesSqlUsersGroup.Models
{
    [ResponseCache(CacheProfileName = "Default30")]
    public class NewUserModel
    {

        [Required, MaxLength(50)]
        public string UserName { get; set; }

        [Required, MaxLength(30)]
        [RegularExpression("^[a-zA-Z0-9-]*$", ErrorMessage = "Please select a name containing only alphanumeric characters and hyphens")]
        public string FirstName { get; set; }

        [Required, MaxLength(30)]
        [RegularExpression("^[a-zA-Z0-9-]*$", ErrorMessage = "Please select a name containing only alphanumeric characters and hyphens")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter an Email address")]
        [EmailAddress]
        public string Email { get; set; }

        [Required, DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password), Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}
