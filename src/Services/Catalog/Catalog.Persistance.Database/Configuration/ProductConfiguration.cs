using Catalog.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalog.Persistance.Database.Configuration
{
    public class ProductConfiguration
    {
        public ProductConfiguration(EntityTypeBuilder<Product> entityBuilder)
        {
            entityBuilder.HasIndex(x=> x.ProductId);
            entityBuilder.Property(x => x.Name).IsRequired().HasMaxLength(100);
            entityBuilder.Property(x => x.Description).IsRequired().HasMaxLength(500);

            //products by default
            var products = new List<Product>();
            var random = new Random();

            for (int i = 1; i <=100; i++)
            {
                products.Add( new Product
                {
                        ProductId = i,
                        Name = $"Product {i}",
                        Description = $"Description for product {i}",
                        Price = random.Next(100, 1000)
                });
            }
            entityBuilder.HasData(products);
        }
    }
}
