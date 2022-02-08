



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
                 CId = "Health products",
                 ProductImage = "https://medicaldialogues.in/h-upload/2020/05/13/128680-vitamin-c.jpg"
             }
            ) ;
            builder.HasData(
            new Product
            {
                ID = 2,
                ProductName = "Baby Wipes",
                ProductPrice = 6.99,
                ProductDesc = "Wipes suitable for babies",
                CId = "Baby Care Products",
                ProductImage = "https://gphb01pdazurefileshare.blob.core.windows.net/sys-master-hybris-media/h37/h52/16339841613854/600623-guardian-baby-care-soft-wipes-fragrance-free-triple-pack-3x90pcs-1-1050Wx1050H"
            }
           );
            builder.HasData(
           new Product
           {
               ID = 3,
               ProductName = "Toothbrushes",
               ProductPrice = 6.99,
               ProductDesc = "Hard bristle, use with care",
               CId = "Oral Care Products",
               ProductImage = "https://www.cheatsheet.com/wp-content/uploads/2017/08/Toothbrushes-768x559.jpg"
           }
          );
        }
    }
}