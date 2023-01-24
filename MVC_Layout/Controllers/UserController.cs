using Microsoft.AspNetCore.Mvc;
using MVC_Layout.Models.Context;
using MVC_Layout.Models.Entity;
using MVC_Layout.Models.Service;

namespace MVC_Layout.Controllers
{
    public class UserController : Controller
    {
       
        UserService userService = new UserService();
        public IActionResult Index()
        {
            return RedirectToAction("Create");
        }
       public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(User user)
        {
            userService.Create(user);
            return RedirectToAction("Basarili");
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username,string password)
        {
           string uyarı= userService.Validation(username, password);
            if (uyarı=="Kullanıcı kayıtlı")
            {
                return RedirectToAction("Basarili");
            }
            else
            {
                return RedirectToAction("Basarisiz");
            }
            
        }
        public IActionResult Basarili()
        {
            return View();
        }
        public IActionResult Basarisiz()
        {
            return View();
        }
    }
}
