namespace CQRS_MedaitR_Example.Entities
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
