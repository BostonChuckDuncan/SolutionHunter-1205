using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace API.Entity
{
    public class AppUser : IdentityUser<int>
    {
        public bool CanTrial { get; set; } = false; // allowed to trial (only once)
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        [Required]
        public bool TrialBegan { get; set; }
#nullable enable
        public DateTime? TrialStart { get; set; }
        public DateTime? TrialEnd { get; set; }
#nullable disable
        public bool CCTypeUser { get; set; } = false;
#nullable enable
        public string? NameOnCC { get; set; }
        public string? CCNumber { get; set; }
        public string? CCExpires { get; set; }
        public string? CCAuthCode { get; set; }
#nullable disable
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
#nullable enable
        public string? Phone1 { get; set; }
        public string? Phone2 { get; set; }
#nullable disable
        [Required]
        public string KnownAs { get; set; }
        [Required]
        public string EmailAddress { get; set; }
#nullable enable
        public string? Question { get; set; }
        public string? Answer { get; set; }
#nullable disable
        public ICollection<AppUserRole> UserRoles { get; set; }
    }

}
