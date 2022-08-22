using AutoMapper;
using CQRS_MedaitR_Example.MedHandlers.Queries.Requests;
using CQRS_MedaitR_Example.MedHandlers.Queries.Responses;
using CQRS_MedaitR_Example.Repositories;
using MediatR;

namespace CQRS_MedaitR_Example.MedHandlers.Queries
{
    public class GetProductsQueryHandler : IRequestHandler<GetProductsQueryRequest, List<GetProductsQueryResponse>>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public GetProductsQueryHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
        public Task<List<GetProductsQueryResponse>> Handle(GetProductsQueryRequest request, CancellationToken cancellationToken)
        {
            var productList = _productRepository.GetAllProducts();
            var mapProductList = _mapper.Map<List<GetProductsQueryResponse>>(productList);
            return Task.FromResult(mapProductList);
        }
    }
}
