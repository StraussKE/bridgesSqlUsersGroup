using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;

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

    public class LoginModel
    {
        [Required]
        [UIHint("email")]
        public string Email { get; set; }

        [Required]
        [UIHint("password")]
        public string Password { get; set; }
    }

    public class RoleEditModel
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<User> Members { get; set; }
        public IEnumerable<User> NonMembers { get; set; }
    }

    public class RoleModificationModel
    {
        [Required]
        public string RoleName { get; set; }
        public string RoleId { get; set; }
        public string[] IdsToAdd { get; set; }
        public string[] IdsToDelete { get; set; }
    }
}
