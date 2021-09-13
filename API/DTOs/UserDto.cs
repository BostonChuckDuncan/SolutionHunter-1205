using API.Entity;

namespace API.Dtos
{
    public class UserDto
    {
        public string Username { get; set; }
        public string Token { get; set; }
        public string roleslist { get; set; }
        public string KnownAs { get; set;  }
    }
}