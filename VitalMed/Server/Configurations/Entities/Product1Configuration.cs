using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitalMed.Shared.Domain;

namespace VitalMed.Server.Configurations.Entities
{
    public class Product1Configuration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
             new Product
             {
                 ID = 1,
                 ProductName = "Vitamin C",
                 ProductPrice = 25.99,
                 ProductDesc = "Supplies you with Vitamin C",
                 CId = "Health products"
             }
            ) ;
        }
    }
}