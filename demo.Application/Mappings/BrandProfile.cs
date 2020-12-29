using demo.Application.Features.Brands.Commands.Create;
using demo.Application.Features.Brands.Queries.GetAllCached;
using demo.Application.Features.Brands.Queries.GetById;
using demo.Domain.Entities.Catalog;
using AutoMapper;

namespace demo.Application.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<CreateBrandCommand, Brand>().ReverseMap();
            CreateMap<GetBrandByIdResponse, Brand>().ReverseMap();
            CreateMap<GetAllBrandsCachedResponse, Brand>().ReverseMap();
        }
    }
}