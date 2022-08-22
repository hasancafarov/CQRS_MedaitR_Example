namespace CQRS_MedaitR_Example.MedHandlers.Commands.Responses
{
    public class UpdateProductCommandResponse
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
