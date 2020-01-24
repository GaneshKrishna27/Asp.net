using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnEmployeeUsingMVC.Models;
using HandsOnEmployeeUsingMVC.Repository;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HandsOnEmployeeUsingMVC.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Signup()
        {
            ViewBag.Designation = new SelectList(new string[] {"program Analyst","Support","Developer","Testing"  });
            ViewBag.ProjectName = new SelectList(new string[] { "Emart","Bank","Education","Library"});
            return View();
        }
        [HttpPost]
        public IActionResult Signup(Employee item)
        {
            EmployeeRepository repository = new EmployeeRepository();
            repository.Add(item);
            return RedirectToAction("Login");
        
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(string EmpId,string pwd)
        {
            EmployeeRepository repository = new EmployeeRepository();
            Employee emp = repository.Validate(EmpId, pwd);
            if (emp != null)
            {
                return RedirectToAction("Details", emp);
                //return RedirectToAction("Greet",new { id=10});
            }
            else
            {
                ViewData["err"] = "invalid cerendials";

                return View();
            }
        }
        public IActionResult Details(Employee item)
        {
            return View(item);
        }

    }
}