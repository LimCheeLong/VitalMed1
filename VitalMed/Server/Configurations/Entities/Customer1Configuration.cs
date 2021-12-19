using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VitalMed.Shared.Domain;

namespace VitalMed.Server.Configurations.Entities
{
    public class Customer1Configuration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasData(
             new Customer
             {
                 ID = 1,
                 ContactNumber = 83183903,
                 Email ="limcheelong4@gmail.com",
                 Address = "416 Bedok North Ave 2 #07-51",
             }
            );
        }
    }
}