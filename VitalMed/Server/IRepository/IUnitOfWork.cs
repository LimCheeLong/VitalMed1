using VitalMed.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VitalMed.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Category> Categories { get; }
        IGenericRepository<Favourite> Favourites { get; }
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<Product> Products { get; }
        IGenericRepository<Review> Reviews { get; }
        IGenericRepository<CartItem> CartItems { get; }
        IGenericRepository<Cart> Cart { get; set; }
    }
}