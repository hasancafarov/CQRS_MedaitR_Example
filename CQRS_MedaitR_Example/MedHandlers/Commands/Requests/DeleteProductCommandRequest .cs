using MediatR;

namespace CQRS_MedaitR_Example.MedHandlers.Commands.Requests
{
    public class DeleteProductCommandRequest : IRequest<bool>
    {
        public Guid Id { get; set; }
    }
}
