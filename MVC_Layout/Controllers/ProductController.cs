using Microsoft.AspNetCore.Mvc;
using MVC_Layout.Models.Context;
using MVC_Layout.Models.Service;

namespace MVC_Layout.Controllers
{
    public class ProductController : Controller
    {
        DatabaseContext db=new DatabaseContext();   
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int Id)
        {
            var product = db.Products.Find(Id);
            if (product != null)
            {
                return View(product);
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}
