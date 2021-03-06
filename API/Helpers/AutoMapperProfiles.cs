using API.Dtos;
using API.DTOs;
using API.Entity;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, LoginDto>();
            CreateMap<AppUser, RegisterDto>();
            CreateMap<RegisterDto, AppUser>();
        }
    }
}