using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace PodcastPlayer.Models
{
    public class ApplicationUser : IdentityUser
    {
        //override identity user, add new column
        public bool isSuperAdmin { get; set; } = false;

        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }

        [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return (FirstName + " " + LastName).Trim();
            }
        }
    }
}
