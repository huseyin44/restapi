using AutoMapper;
using WebApplication3.Domain.Models;
using WebApplication3.Resources;
using WebApplication3.Extensions;

namespace WebApplication3.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Category, CategoryResource>();

            CreateMap<Product, ProductResource>()
                .ForMember(src => src.UnitOfMeasurement,
                           opt => opt.MapFrom(src => src.UnitOfMeasurement.ToDescriptionString()));
            
        }
    }
}
