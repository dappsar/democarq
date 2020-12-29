using demo.Application.Features.Products.Commands.Create;
using demo.Application.Features.Products.Commands.Update;
using demo.Application.Features.Products.Queries.GetAllCached;
using demo.Application.Features.Products.Queries.GetById;
using demo.Web.Areas.Catalog.Models;
using AutoMapper;

namespace demo.Web.Areas.Catalog.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<GetAllProductsCachedResponse, ProductViewModel>().ReverseMap();
            CreateMap<GetProductByIdResponse, ProductViewModel>().ReverseMap();
            CreateMap<CreateProductCommand, ProductViewModel>().ReverseMap();
            CreateMap<UpdateProductCommand, ProductViewModel>().ReverseMap();
        }
    }
}