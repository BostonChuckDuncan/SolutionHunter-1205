using System;
using Microsoft.AspNetCore.Mvc;
using HunterServer.Dtos;
using System.Threading.Tasks;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using API.Data;

namespace HunterServer.Controllers
{
    [Authorize]
    [Microsoft.AspNetCore.Components.Route("api/[controller]")]
    [ApiController]
    public class ProjectsController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IProjectRepository _repo;
        public ProjectsController(IProjectRepository repo, IMapper mapper)
        {
            _mapper = mapper;
            _repo = repo;
        }

        [HttpGet("GetProfile/{id}")]
        public async Task<IActionResult> GetProfileById(int id)
        {
            var result = await _repo.GetProfile(id);
            return Ok(result);
        }



    }
}