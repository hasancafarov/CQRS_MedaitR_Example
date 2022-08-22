using CQRS_MedaitR_Example.MedHandlers.Queries.Responses;
using MediatR;

namespace CQRS_MedaitR_Example.MedHandlers.Queries.Requests
{
    public class GetProductByIdQueryRequest : IRequest<GetProductByIdQueryResponse>
    {
        public Guid Id { get; set; }
    }
}
