using Microsoft.AspNetCore.Mvc;
using MVC_Layout.Models.Context;
using MVC_Layout.Models.Data;
using System.Linq;

namespace MVC_Layout.Controllers
{
    public class CategoryController : Controller
    {   DatabaseContext db=new DatabaseContext();
        public IActionResult Details(int id)//2
        {   
            var products=db.Products.Where(x=>x.Category.ID== id).ToList();
            return View(products);
        }
    }
}
