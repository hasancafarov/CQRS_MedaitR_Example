using CQRS_MedaitR_Example.Entities;

namespace CQRS_MedaitR_Example.Repositories
{
    public class ProductRepository : IProductRepository
    {
        List<Product> Products;
        public ProductRepository()
        {
            Products = new List<Product> {
                new Product { Id = Guid.NewGuid(),Name="Phone",CreateDate = DateTime.UtcNow  },
                new Product { Id = Guid.NewGuid(),Name="Laptop",CreateDate = DateTime.UtcNow  },
                new Product { Id = Guid.NewGuid(),Name="TV",CreateDate = DateTime.UtcNow  },
            };
        }
        public Guid AddProduct(Product product)
        {
            product.Id = Guid.NewGuid();
            product.CreateDate = DateTime.UtcNow;
            Products.Add(product);
            var insertedProduct = GetProductById(product.Id);
            return insertedProduct.Id;
        }

        public bool DeleteProduct(Guid id)
        {
            var product = GetProductById(id);

            if (product == null)
                return false;
            Products.Remove(product);
            return true;
        }

        public List<Product> GetAllProducts()
        {
            return Products;
        }

        public Product GetProductById(Guid id)
        {
            var product = Products.FirstOrDefault(p => p.Id == id);
            return product;
        }

        public Product UpdateProduct(Product product)
        {
            var productEntity = GetProductById(product.Id);
            if (productEntity != null)
            {
                productEntity.Id = product.Id;
                productEntity.Name = product.Name;
            }
            return productEntity;
        }
    }
}
