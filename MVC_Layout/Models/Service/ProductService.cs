using Microsoft.CodeAnalysis;
using MVC_Layout.Models.Context;
using MVC_Layout.Models.Data;
using MVC_Layout.Models.Entity;
using MVC_Layout.Models.Repository;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Layout.Models.Service
{
    public class ProductService : IProduct
    {
        DatabaseContext db = new DatabaseContext();

    

        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }
    }
}
