using Microsoft.AspNetCore.Mvc;
using DemoMVC.Models;

namespace DemoMVC.Controllers
{
    public class GodController : Controller
    {
        //khai bao cac phuong thuc
        public IActionResult Index()
        {
            return View();
        }
    }
}