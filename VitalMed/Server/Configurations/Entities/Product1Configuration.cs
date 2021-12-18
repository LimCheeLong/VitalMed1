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
                 ProductName = "Vaccum Cleaner",
                 ProductPrice = 25.99,
                 ProductDesc = "Vaccums dirt and dust from the ground"
             }
            );
        }
    }
}