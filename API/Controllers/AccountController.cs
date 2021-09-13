using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using API.Entity;
using API.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace API.Controllers
{
    public class AccountController : BaseApiController
    {
        private readonly ITokenService _tokenService;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<AppRole> _roleManager;
        public AccountController(
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager,
            ITokenService tokenService,
            IMapper mapper,
            RoleManager<AppRole> roleManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
            _mapper = mapper;
            _tokenService = tokenService;
            _roleManager = roleManager;
        }

        [HttpPost("register")]
        // [Authorize]
        [Authorize(Roles = "Admin")]
        public async Task<ActionResult<UserDto>> Register(RegisterDto registerDto)
        {
            if (await this.UserExists(registerDto.Username)) return BadRequest("Username is taken");

            var user = _mapper.Map<AppUser>(registerDto);

            user.UserName = registerDto.Username.ToLower();

            var result = await _userManager.CreateAsync(user, registerDto.Password);

            if (!result.Succeeded) return BadRequest(result.Errors);

            var roleResult = await _userManager.AddToRoleAsync(user, "Member");

            if (!roleResult.Succeeded) return BadRequest(result.Errors);

            return new UserDto
            {
                Username = user.UserName,
                Token = await _tokenService.CreateToken(user),
                KnownAs = user.KnownAs
            };
        }

        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<UserDto>> Login(LoginDto loginDto)
        {
            if (await this.CountOfUsersAsync() == 0)  // have we inited the data -> need the admin account
            {
                // populate Roles for the application users
                var roles = new List<AppRole>()
                {
                    new AppRole { Name = "Admin" },
                    new AppRole { Name = "Lead" },
                    new AppRole { Name = "Tester" },
                    new AppRole { Name = "Member" },
                    new AppRole { Name = "Trial"},
                    new AppRole { Name = "Visitor"}  
                };

                // Replace all existing roles !
                var allRoles = _roleManager.Roles.ToList();
                foreach( var role in allRoles )
                {
                    await _roleManager.DeleteAsync(role);
                }

                // Add the new ones we want in "roles" list
                foreach (var role in roles)
                {
                    await _roleManager.CreateAsync(role);
                }

                // seed with admin
                var regAdminDto = new RegisterDto()
                {
                    Username = "admin",
                    FirstName = "System",
                    LastName = "Administrator",
                    KnownAs = "Admin",
                    EmailAddress = "sysAdmin@myUrl.com",
                    CCTypeUser = default,  // is not credit card type user
                    Password = "P@$$w0r4",
                };

                var userDto = await this.Register(regAdminDto);
                var userAdminAdded = await _userManager.Users.SingleOrDefaultAsync(x => x.UserName == "admin");
                await _userManager.AddToRolesAsync(userAdminAdded,
                    new[] { "Admin", "Lead", "Tester", "Member" });  // Register will already add admin to "Member"


                return BadRequest("System Initialized: Administrator created");
            }

            // validate the user login
            var user = await _userManager.Users
                    .SingleOrDefaultAsync(x => x.UserName == loginDto.Username.ToLower());     

            if (user == null) return Unauthorized("Invalid Username");

            var result = await _signInManager
                    .CheckPasswordSignInAsync(user, loginDto.Password, false);

            if (!result.Succeeded) return Unauthorized();

            var userRoles = _userManager.GetRolesAsync(user).Result;
            List<string> roleNames = new List<string>();

            return new UserDto
            {
                Username = user.UserName,
                Token = await _tokenService.CreateToken(user),
                roleslist = Newtonsoft.Json.JsonConvert.SerializeObject(roleNames.ToArray()),
                KnownAs = user.KnownAs
            };
        }

        private async Task<bool> UserExists(string username)
        {
            return await this._userManager.Users.AnyAsync(x => x.UserName == username.ToLower());
        }

        private async Task<int> CountOfUsersAsync()
        {
            var numUsers = await _userManager.Users.CountAsync<AppUser>();
            return numUsers;
        }

        private async Task<IList<string>> GetUserRolesAsync(string Id)
        {
            var user = await _userManager.FindByIdAsync(Id);
            var roles = await _userManager.GetRolesAsync(user);
            return roles;
        }
    }
}