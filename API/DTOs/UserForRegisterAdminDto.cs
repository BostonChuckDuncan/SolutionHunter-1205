using System.ComponentModel.DataAnnotations;

namespace HunterServer.Dtos
{
    public class UserForRegisterAdminDto
    {
        [Required]
        public string UserName { get; set; }
        
        [Required]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Must specify password between 8 and 50 characters")]
        public string Password { get; set; }
    }
}