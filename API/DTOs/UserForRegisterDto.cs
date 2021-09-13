using System.ComponentModel.DataAnnotations;

namespace HunterServer.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Phone1 { get; set; }

        public string Phone2 { get; set; }

        [Required]
        public string KnownAs { get; set; }

        public string EmailAddress { get; set; }

        [Required]
        public string UserName { get; set; }
        
        [Required]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Must specify password between 8 and 50 characters")]
        public string Password { get; set; }

        public string Question { get; set; }

        public string Answer { get; set; }

        [Required]
        public int ProjectAdmin { get; set; }

        [Required]
        public bool SystemAdmin { get; set; }
    }
}