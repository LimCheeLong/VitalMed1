using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitalMed.Shared.Domain;

namespace Vitalmed.Server.Configurations.Entities
{
    public class CartItemConfiguration : IEntityTypeConfiguration<CartItem>
    {
        public void Configure(EntityTypeBuilder<CartItem> builder)
        {
            //seed to prevent error due to cartitem being null
            builder.HasData(
             new CartItem
             {
                 ID = 1
             }
            );
        }
    }
}