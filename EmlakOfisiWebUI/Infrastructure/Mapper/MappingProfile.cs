using AutoMapper;
using Entities.Dtos;
using Entities.Models;
using Microsoft.AspNetCore.Identity;

namespace EmlakOfisiWebUI.Infrastructure.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<EstateDtoForInsertion, Estate>();
            CreateMap<EstateDtoForUpdate, Estate>().ReverseMap();
            CreateMap<UserDtoForCreation, IdentityUser>();
            CreateMap<UserDtoForUpdate, IdentityUser>().ReverseMap();
            CreateMap<CategoryDtoForInsertion, Category>().ReverseMap();
            CreateMap<CategoryDtoForUpdate, Category>().ReverseMap();
        }
    }
}
