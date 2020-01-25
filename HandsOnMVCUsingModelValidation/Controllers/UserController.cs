using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HandsOnMVCUsingModelValidation.Models;
using HandsOnMVCUsingModelValidation.Repositories;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace HandsOnMVCUsingModelValidation.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Country = new SelectList(new string[] { "","india", "us", "china", "uk" });
            return View();
        }
        [HttpPost]
        public IActionResult Create(User item)
        {
            UserRepository repository = new UserRepository();
            repository.Add(item);
            return RedirectToAction("Login");
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Login(string uname,string pwd)
        {
            UserRepository repository = new UserRepository();
            User user = repository.Validate(uname, pwd);
            if (user != null)
            {
                return RedirectToAction("Details", user);
                //return RedirectToAction("Greet",new { id=10});
            }
            else
            {
                ViewData["err"] = "invalid cerendials";

                return View();
            }
        }
        public IActionResult Details([Bind(include:"Name,Pwd")]User item)
        {
            return View(item);
        }
        public IActionResult Greet(int id)
        {
            return View();
        }

    }
}