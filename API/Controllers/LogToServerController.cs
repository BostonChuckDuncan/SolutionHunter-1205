using API.Data;
using API.Dtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Api.Controllers {
    [Authorize]
    [Route ("api/[controller]")]
    [ApiController]
    public class LogToServerController : ControllerBase {

        private readonly ILogRepository _repo;
        public LogToServerController (ILogRepository repo) {
            _repo = repo;
        }

        [AllowAnonymous]
        [HttpPost("writeAngularLogMessage")]
        public async Task WriteAngularLogMessage(LogMessagesDto logMessagesDto)
        {
            string message = logMessagesDto.message;
            await _repo.AddLogMessage(message);
        }
    }
}
