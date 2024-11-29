using Microsoft.AspNetCore.Mvc;
using MvCITI.Models;
using System.Runtime.CompilerServices;

namespace MvCITI.Controllers
{
    public class BindController : Controller
    {
        //bind/testprimitive/1?name=hanaa&color=red&color=green
        public IActionResult testprimitive(int id,String name,int age,List<string>color)
        {
            return Content($"name ={name} id={id} age={age}");
        }
        //bind/testdict?name=hanaa&phones[hanaa]=123
        public IActionResult testdict(string name, Dictionary<string, int> phones)
        {
            foreach (var phone in phones)
            {
                return Content($"{phone}={phone.Value}");
            };
            return Content("invalid");
            
        }
        //binding custom/complex type
        //bind/comp/1?name=hanaa&manager_name=ammar

        public IActionResult comp ([Bind(include:"id,name")]dept dept) 
        {
            return Content("oooooookk");
        }

    }
}
