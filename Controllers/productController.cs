using Microsoft.AspNetCore.Mvc;

namespace MvCITI.Controllers
{
    public class productController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult gethtml()
        {
            return View("view1");
        }

    }
}
