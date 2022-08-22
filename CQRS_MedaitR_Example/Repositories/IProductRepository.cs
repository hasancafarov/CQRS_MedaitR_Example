using CQRS_MedaitR_Example.Entities;

namespace CQRS_MedaitR_Example.Repositories
{
    public interface IProductRepository
    {
        public Guid AddProduct(Product product);
        public Product UpdateProduct(Product product);
        public bool DeleteProduct(Guid id);
        public Product GetProductById(Guid id);
        public List<Product> GetAllProducts();
    }
}
