using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VitalMed.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly string ProductsEndpoint = $"{Prefix}/products";
        public static readonly string CategoriesEndpoint = $"{Prefix}/category";
        public static readonly string CustomersEndpoint = $"{Prefix}/customer";
        public static readonly string OrdersEndpoint = $"{Prefix}/orders";
        public static readonly string FavouritesEndpoint = $"{Prefix}/favourites";
        public static readonly string CartItemsEndpoint = $"{Prefix}/CartItems";
        public static readonly string ReviewsEndpoint = $"{Prefix}/Reviews";
    }
}