using AutoMapper;
using CQRS_MedaitR_Example.Entities;
using CQRS_MedaitR_Example.MedHandlers.Commands.Requests;
using CQRS_MedaitR_Example.MedHandlers.Commands.Responses;
using CQRS_MedaitR_Example.MedHandlers.Queries.Responses;

namespace CQRS_MedaitR_Example.Mapper
{
    public class RegisterMapper : Profile
    {
        public RegisterMapper()
        {
            CreateMap<Product, GetProductByIdQueryResponse>();
            CreateMap<Product, GetProductsQueryResponse>();
            CreateMap<Product, UpdateProductCommandResponse>();
            CreateMap<CreateProductCommandRequest, Product>();
            CreateMap<UpdateProductCommandRequest, Product>();
        }
    }
}
