using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos
{
  public class UserForDetailedDto
  {
    public int Id { get; set; }
    public string Username { get; set; }
    public string KnownAs { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone1 { get; set; }
    public string Phone2 { get; set; }
    public string EmailAddress { get; set; }
    public string Question { get; set; }
    public int ProjectAdmin { get; set; }
    public bool SystemAdmin { get; set; }
  }
}
