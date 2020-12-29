using demo.Application.Features.Products.Commands.Create;
using demo.Application.Features.Products.Queries.GetAllCached;
using demo.Application.Features.Products.Queries.GetAllPaged;
using demo.Application.Features.Products.Queries.GetById;
using demo.Domain.Entities.Catalog;
using AutoMapper;

namespace demo.Application.Mappings
{
    internal class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<CreateProductCommand, Product>().ReverseMap();
            CreateMap<GetProductByIdResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsCachedResponse, Product>().ReverseMap();
            CreateMap<GetAllProductsResponse, Product>().ReverseMap();
        }
    }
}