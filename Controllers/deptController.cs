using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MvCITI.Models;

namespace MvCITI.Controllers
{
    public class deptController : Controller
    {
        itiDBcontext context = new itiDBcontext();
        public IActionResult Index()
        {
            List<dept> deptlistmodel = context.Depts.Include(g => g.Employee).ToList();

            return View(deptlistmodel);
        }
        public IActionResult New ()
        {
            return View(new dept());
         }
        [HttpPost]
        public IActionResult savenew(dept dept)
        {
            if (dept.name != null)
            {
                context.Depts.Add(dept);
                context.SaveChanges();
                return RedirectToAction("index");
            }
            else return View("new",dept);
           

        }
        public IActionResult remove()
        {
            return View(new dept());
        }
        public IActionResult saveremove(int id,[Bind(include:"id")] dept dep)
        {
            if (id==dep.id)
            {
                context.Depts.Remove(dep);
                context.SaveChanges(); 
                return RedirectToAction("index");
            }
            else return View("new",dep);
           

        }

    }
}
