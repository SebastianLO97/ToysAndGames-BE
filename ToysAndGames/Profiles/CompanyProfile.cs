using AutoMapper;
using Core.Entities;
using ToysAndGames.DTOs;

namespace ToysAndGames.Profiles
{
    public class CompanyProfile : Profile
    {
        public CompanyProfile()
        {
            CreateMap<Company, CompanyDTO>();
        }
    }
}
