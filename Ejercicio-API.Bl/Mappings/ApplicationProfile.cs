using AutoMapper;
using Ejercicio_API.Bl.Dto;
using Ejercicio_API.Models;

namespace Ejercicio_API.Bl.Mappings
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Country, CountryDto>()
                .ReverseMap();
            CreateMap<Product, ProductDto>()
                .ReverseMap();
        }
    }
}
