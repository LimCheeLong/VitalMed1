using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitalMed.Shared.Domain;

namespace VitalMed.Server.Configurations.Entities
{
    public class Categories1Configuration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(
             new Category
             {
                 ID = 1,
                 Thumbnail = "https://cdn.discordapp.com/attachments/915960385323040778/940443791003877396/unknown.png",
                 Name = "Health Products"
             }
            );
            builder.HasData(
             new Category
             {
                 ID = 2,
                 Thumbnail = "https://cdn.discordapp.com/attachments/915960385323040778/940444204646158356/unknown.png",
                 Name = "Baby Care Products"
             }
            );
            builder.HasData(
             new Category
             {
                 ID = 3,
                 Thumbnail = "https://cdn.discordapp.com/attachments/915960385323040778/940444449971007509/unknown.png",
                 Name = "Oral Care Products"
             }
            );
        }
    }
}