using CQRS_MedaitR_Example.MedHandlers.Queries.Responses;
using MediatR;

namespace CQRS_MedaitR_Example.MedHandlers.Queries.Requests
{
    public class GetProductsQueryRequest : IRequest<List<GetProductsQueryResponse>>
    {
    }
}
