using Microsoft.AspNetCore.Mvc;
using FirstResponsiveWebAppEssick.Models;
using Microsoft.Win32;
using System;

namespace FirstResponsiveWebAppEssick.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.BY = "0";
            return View();
        }
        [HttpPost]
        public IActionResult Index(ResponsiveAppModel model)
        {
            ViewBag.BY = model.AgeThisYear();
            return View(model);
        }
    }
}
