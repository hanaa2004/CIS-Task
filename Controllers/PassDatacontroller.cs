using Microsoft.AspNetCore.Mvc;
using MvCITI.Models;
using MvCITI.Views.viewmodel;

namespace MvCITI.Controllers
{
    public class PassDatacontroller : Controller
    {
        itiDBcontext context=new itiDBcontext();
        public IActionResult passdata(int Id)
        {
            Employee emp = context.Employees.FirstOrDefault(e => e.id == Id);

            List<string>branches=new List<string>();
            branches.Add("alex");
            branches.Add("mansoyra");
            branches.Add("cairo");
            branches.Add("tanta");
            
            string color = "Red";
            
            string message = "hellow";
            EmployeeWithMessageAndBranchesListViewModel empViewModel=new EmployeeWithMessageAndBranchesListViewModel();
            empViewModel.emp_id = emp.id;
            empViewModel.emp_name = emp.name;
            empViewModel.branches = branches;
            empViewModel.message=message;
            empViewModel.color=color;

            return View(empViewModel);
        }
    }
}
