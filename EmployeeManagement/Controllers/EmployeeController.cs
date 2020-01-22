using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;
using EmployeeManagement.Model;
namespace EmployeeManagement.Controllers
{
    public class EmployeeController : Controller
    {
        //  IEmployeeRepository employeeRepository = new EmployeeRepository();
        private readonly IEmployeeRepository employeeRepository;
        public EmployeeController(IEmployeeRepository emrepository)//dependency injected object
        {
            employeeRepository = emrepository;
        }
        public IActionResult Search(int? id)
        {
            int Id = (int)((id == null) ? 1 : id);

            Employee emp = employeeRepository.GetEmployee(Id);
            //if (emp != null)
            //{
            //    return Content(emp.Id + "\n" + emp.Name + "\n" + emp.Email + "\n " + emp.Dept);
            //}
            //else
            //    return Content("Employee does not exist");
            //ViewData["id"] = emp.Id;
            //ViewData["name"] = emp.Name;
            //ViewData["email"] = emp.Email;
            //ViewData["dept"] = emp.Dept;
            //ViewData["employee"] = emp;
            //ViewBag.employee = emp;
            //ViewBag.id = emp.Id;
            //ViewBag.name = emp.Name;
            //ViewBag.email = emp.Email;                                                                                
            //ViewBag.dept = emp.Dept;
            return View(emp);
        }
        public IActionResult Index()
        {
            List<Employee> elist = employeeRepository.DisplayDetails();
            return View(elist);
        }
        public ViewResult AboutEmployee()
        {
            Employee emp = employeeRepository.GetEmployee(2);
            // ViewBag.projectName = "BookHive";
            EmployeeProjectViewModel ep = new EmployeeProjectViewModel();
            ep.employee = emp;
            ep.projectName = "BookHive";
            return View(ep);
        }
        public IActionResult GetAllEmployees()
        {
            List<Employee> elist = (employeeRepository.DisplayDetails()).Where(e=>e.Dept=="cse").ToList();
            return View("~/Views/Employee/Index.cshtml",elist);
        }
    }
}