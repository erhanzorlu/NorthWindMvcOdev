using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC_Layout.Models;
using MVC_Layout.Models.Repository;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Layout.Controllers
{
    public class HomeController : Controller
    {
        private  ICategory _categoryService;
        private  IProduct _productService;
        private IUser _userService;

        public HomeController(ICategory categoryService, IProduct productService,IUser userService)
        {
            _categoryService = categoryService;
            _productService = productService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            ViewBag.Categories = _categoryService.GetCategories();
            return View(_productService.GetProducts());
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
       
    }
}
