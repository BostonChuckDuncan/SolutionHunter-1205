using System;
using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class RegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

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

        public string? CCAuthCode { get; set; }

        public string? CCExpires { get; set; }

        public string? CCNumber { get; set; }

#nullable disable
        [Required]
        public byte[] PasswordHash { get; set; }
        
        [Required]
        public byte[] PasswordSalt { get; set; }

        [Required]
        public bool CCTypeUser { get; set; }

        [Required]
        public bool CanTrial { get; set; }

#nullable enable
        public string? NameOnCC { get; set; }
        public DateTime? TrialBegan { get; set; }
        public DateTime? TrialStart { get; set; }
        public DateTime? TrialEnd { get; set; }
        public string? rolesJson { get; set; }
#nullable disable

    }
}