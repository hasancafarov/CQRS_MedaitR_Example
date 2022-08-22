using MediatR;

namespace CQRS_MedaitR_Example.MedHandlers.Commands.Requests
{
    public class CreateProductCommandRequest:IRequest<Guid>
    {
        public string Name { get; set; }
    }
}
