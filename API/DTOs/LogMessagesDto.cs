using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class LogMessagesDto
    {
        [Required]
        public string Id {get;set;}
        [Required]
        public string message { get; set; }

    }
}
