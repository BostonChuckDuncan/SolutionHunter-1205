using System.Collections.Generic;
using System.Threading.Tasks;
using HunterServer.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace HunterServer.Controllers
{
    [Authorize]
    [Route ("api/[controller]")]
    [ApiController]
    public class RandomCacheController : ControllerBase {

        private IRandomCacheRepository _repo;
        public RandomCacheController (IRandomCacheRepository repo) {
            _repo = repo;
        }
        
    [AllowAnonymous]
        [HttpGet("{amount}/{projectId}")]   // HttpGet(localhost:4200/api/RandomCache/{amount}/{marker}
        public async Task<IActionResult> GetRandomBytes( int amount, int projectId )   // amount is maximum decimal number
        {
            var toReturn = await _repo.GetRandomInt(amount, projectId);
            return Ok(toReturn);
        }
    }
}