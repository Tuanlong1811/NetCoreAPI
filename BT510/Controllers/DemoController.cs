using Microsoft.AspNetCore.Mvc;
using DemoMvc.Models;

namespace Demomvc.Controllers
{
    public class DemoController : Controller
    {
 public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string fName, string ABC)
    {
        string strResult = "Hello" + fName + "-" +ABC;
        ViewBag.xcv = strResult;
        return View();
    }
    }
}