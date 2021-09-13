using System.Threading.Tasks;
using API.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    public class AdminController : BaseApiController
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppUser> _roleManager;
        public AdminController(UserManager<AppUser> userManager, RoleManager<AppUser> roleManager)
        {
            _roleManager = roleManager;
            _userManager = userManager;
        }

        // [Authorize(Roles = "Admin")]
        // [HttpGet("users-and-roles")]
        // public async Task<ActionResult> GetUsersWithRoles()
        // {
        //     var uwR = from user in 
        //     var users = await _userManager.Users
        //         .Include(r => r.UserRoles)
        //         .OrderBy(u => u.UserName)
        //         .Select(u => new
        //         {
        //             u.Id,
        //             Username = u.UserName,
        //             Roles = u.UserRoles.Select(r => r.RoleName).ToList()
        //         })
        //         .ToListAsync();

        //     return Ok(users);
        // }
    }
}