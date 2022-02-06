using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vitalmed.Server.Configurations.Entities;
using VitalMed.Server.Configurations.Entities;
using VitalMed.Server.Models;
using VitalMed.Shared.Domain;

namespace VitalMed.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Favourite> Favourites { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<CartItem> CartItems { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new Product1Configuration());
            builder.ApplyConfiguration(new Categories1Configuration());
            builder.ApplyConfiguration(new Customer1Configuration());
            builder.ApplyConfiguration(new CartItemConfiguration());
            builder.ApplyConfiguration(new Review1Configuration());
        }

        public DbSet<VitalMed.Shared.Domain.Cart> Cart { get; set; }


    }
}
