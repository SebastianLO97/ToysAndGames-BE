using AutoMapper;
using Core.Entities;
using ToysAndGames.DTOs;

namespace ToysAndGames.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, ProductDTO>();
        }
    }
}
