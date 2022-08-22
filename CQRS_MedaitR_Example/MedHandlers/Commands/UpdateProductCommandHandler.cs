using AutoMapper;
using CQRS_MedaitR_Example.Entities;
using CQRS_MedaitR_Example.MedHandlers.Commands.Requests;
using CQRS_MedaitR_Example.MedHandlers.Commands.Responses;
using CQRS_MedaitR_Example.Repositories;
using MediatR;

namespace CQRS_MedaitR_Example.MedHandlers.Commands
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public UpdateProductCommandHandler(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var mapProductRequest = _mapper.Map<Product>(request);
            var product = _productRepository.UpdateProduct(mapProductRequest);
            var mapProduct = _mapper.Map<UpdateProductCommandResponse>(product);
            return Task.FromResult(mapProduct);
        }
    }
}
