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
        public static readonly string CategoriesEndpoint = $"{Prefix}/categories";
    }
}