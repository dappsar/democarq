using demo.Application.Features.Brands.Commands.Create;
using demo.Application.Features.Brands.Commands.Update;
using demo.Application.Features.Brands.Queries.GetAllCached;
using demo.Application.Features.Brands.Queries.GetById;
using demo.Web.Areas.Catalog.Models;
using AutoMapper;

namespace demo.Web.Areas.Catalog.Mappings
{
    internal class BrandProfile : Profile
    {
        public BrandProfile()
        {
            CreateMap<GetAllBrandsCachedResponse, BrandViewModel>().ReverseMap();
            CreateMap<GetBrandByIdResponse, BrandViewModel>().ReverseMap();
            CreateMap<CreateBrandCommand, BrandViewModel>().ReverseMap();
            CreateMap<UpdateBrandCommand, BrandViewModel>().ReverseMap();
        }
    }
}