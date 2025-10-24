using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using CodeRefactoring.Constants;

namespace CodeRefactoring.Data.Entities
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(UserConstants.MaxNameLength), MinLength(UserConstants.MinNameLength)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(UserConstants.MaxNameLength), MinLength(UserConstants.MinNameLength)]
        public string LastName { get; set; }
    }
}