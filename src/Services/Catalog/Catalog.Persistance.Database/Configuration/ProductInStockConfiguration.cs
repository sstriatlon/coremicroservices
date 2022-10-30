using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Catalog.Persistance.Database.Configuration
{
    public class ProductInStockConfiguration
    {
        public ProductInStockConfiguration(EntityTypeBuilder<ProductInStock> entityBuilder)
        {
            entityBuilder.HasKey(x => x.ProductsInStockId);
            var products = new List<ProductInStock>();
            var random = new Random();

            for (int i = 1; i <= 100; i++)
            {
                products.Add(new ProductInStock
                {
                    ProductsInStockId = i,
                    ProductId = i,
                    Stock = random.Next(0, 20)
                });
            }
            entityBuilder.HasData(products);
        }
    }
}
