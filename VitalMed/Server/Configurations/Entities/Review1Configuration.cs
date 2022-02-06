using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitalMed.Shared.Domain;

namespace VitalMed.Server.Configurations.Entities
{
    public class Review1Configuration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasData(
             new Review
             {
                 ID = 1,
                 Name = "Cheelong",
                 ProductName = "Vitamin C",
                 Rating = "5",
                 ReviewDesc = "great"
             }
            );
        }
    }
}