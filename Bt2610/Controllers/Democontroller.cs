using Microsoft.AspNetCore.Mvc;
//nguyentuanlong-1721050348

namespace NetMVC.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //nhan du lieu tu view gui len
        [HttpPost]
        public IActionResult Index(string fName, string ABC)
        {
            string strResult = "Hello " + fName + "-" + ABC;
            ViewBag.xcv = strResult;
            return View();
        }
    }
}