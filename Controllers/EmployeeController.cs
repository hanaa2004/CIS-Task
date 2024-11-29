using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;
using MvCITI.Models;

namespace MvCITI.Controllers
{
    public class EmployeeController : Controller
    {

        itiDBcontext context = new itiDBcontext();
        public IActionResult Index()
        {
            return View(context.Employees.ToList());
        }
        public IActionResult edit(int id)
        {
           Employee empmodel= context.Employees.FirstOrDefault(e=>e.id == id);
            ViewData["deptlist"] = context.Depts.ToList();
            return View(empmodel);

        }

        public IActionResult saveedit(int id, Employee newemp)
        {
            if (newemp.name != null)
            {
                Employee oldemp = context.Employees.FirstOrDefault(e => e.id == id);
                if (ModelState.IsValid)
                {
                    oldemp.name = newemp.name;
                    oldemp.address = newemp.address;
                    oldemp.dept_id = newemp.dept_id;
                    oldemp.age = newemp.age;
                    oldemp.salary = newemp.salary;
                    context.SaveChanges();
                    return RedirectToAction("index");
                }
            }
            return View("edit", newemp);
        }
        public IActionResult New()
        {
            ViewData["deptlist"] = context.Depts.ToList();
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult savenew( Employee newemp)
        {
            if (ModelState.IsValid)
            {
                
                        context.Employees.Add(newemp);

                        context.SaveChanges();
                        return RedirectToAction("index");
              
               
                
            }
            ViewData["deptlist"] = context.Depts.ToList();
            return View("new", newemp);
        }
    }
}
