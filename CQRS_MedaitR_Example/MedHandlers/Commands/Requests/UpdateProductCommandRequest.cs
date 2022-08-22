using CQRS_MedaitR_Example.MedHandlers.Commands.Responses;
using MediatR;

namespace CQRS_MedaitR_Example.MedHandlers.Commands.Requests
{
    public class UpdateProductCommandRequest : IRequest<UpdateProductCommandResponse>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
