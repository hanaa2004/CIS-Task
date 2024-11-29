using Microsoft.AspNetCore.Mvc;

namespace MvCITI.Controllers
{
    public class stateManagementController : Controller
    {
        public IActionResult setsession()
        {

            HttpContext.Session.SetString("name", "hanaa");
            HttpContext.Session.SetInt32("age",20);
            return Content("dataa saved");
        }
        public IActionResult getsession()
        {

            string name = HttpContext.Session.GetString("name");
            int? age = HttpContext.Session.GetInt32("age");
            return Content($"name{name},age{age}"); 
        }


        public IActionResult settempdata()
        {
            TempData["msg"] = "hellowww from temp data";
            return Content("data saved");
        }
        public IActionResult gettempdata()
        {
            string tempmsg = TempData["msg"].ToString();
            TempData.Keep();

            return Content(tempmsg);
        }
    }
}
