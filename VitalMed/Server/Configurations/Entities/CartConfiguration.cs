using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitalMed.Shared.Domain;

namespace Vitalmed.Server.Configurations.Entities
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasData(
             new Cart
             {
                 ID = 1,
                 Username = "seedUser"
             }
            );
        }
    }
}