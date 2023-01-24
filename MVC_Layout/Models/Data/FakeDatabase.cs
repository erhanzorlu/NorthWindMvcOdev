using MVC_Layout.Models.Entity;
using System.Collections.Generic;
using System.Linq;

namespace MVC_Layout.Models.Data
{
    public class FakeDatabase
    {
        //Categories Data
        public static List<Category> Categories = new List<Category>
        {
            new Category{ID=1,CategoryName="Teknoloji"},
            new Category{ID=2,CategoryName="Giyimler"},
            new Category{ID=3,CategoryName="Kitap"}
        };

        //Products Data

        public static List<Product> Products = new List<Product>
        {
            new Product
        { ID = 1,
            ProductName = "HP Notebook", UnitPrice = 20000, ImagePath = "https://productimages.hepsiburada.net/s/300/550/110000290587665.jpg",
            Description = "Hp Victus 15-FA0003NT Intel Core i7-12700H 16GB 1TB SSD 4GB 3050Ti 15.6” FHD 144Hz Freedos Taşınabilir Bilgisayar 6Z5Z0EA",
            Category = Categories.Where(x => x.ID == 1).FirstOrDefault(),CategoryId=1
        },
new Product
        { ID = 2,
            ProductName = "U.S. Polo Assn. Erkek Vişne Sweatshirt ", UnitPrice = 305, ImagePath = "https://productimages.hepsiburada.net/s/335/1000/110000340467525.jpg",
            Description = "Erkek düz renk sweatshirt",
            Category = Categories.Where(x => x.ID == 2).FirstOrDefault(),CategoryId= 2
        },
new Product
        { ID = 3,
            ProductName = "1984", UnitPrice = 30, ImagePath = "https://productimages.hepsiburada.net/s/37/500/10535266484274.jpg",
            Description = "George Orwell",
            Category = Categories.Where(x => x.ID == 3).FirstOrDefault(),CategoryId=3
        },

        };

    }
}
