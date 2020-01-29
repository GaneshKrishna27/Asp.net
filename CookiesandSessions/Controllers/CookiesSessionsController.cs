﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CookiesandSessions.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CookiesandSessions.Controllers
{
    public class CookiesSessionsController : Controller
    {
        private readonly UserAccountContext _context;

        public CookiesSessionsController(UserAccountContext context)
        {
            this._context = context;
        }

        // GET: CookiesSessions
        [HttpGet]
        public ActionResult RegisterUser()
        {

            return View();
        }
        [HttpPost]
        public ActionResult RegisterUser(UserAccount uc)
        {
            try
            {
                _context.Add(uc);
                _context.SaveChanges();
                ViewBag.message = uc.Username + " has got successfully Registered";
                return RedirectToAction("Login");
                
            }
            catch (Exception e)
            {
                ViewBag.message = uc.Username + " registered failed";
                return View();
            }
            
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserAccount uc)
        {
            var logUser = _context.UserAccounts.Where(e => e.Username == uc.Username &&  e.Password == uc.Password).ToList();
            if (logUser.Count==0)
            {
                ViewBag.message = "Not valid user";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("Uname", uc.Username);
               // HttpContext.Session.SetString("lastLogin", DateTime.Now.ToString());
                return RedirectToAction("CreateDashBoard");
            }
            
        }
        public ActionResult CreateDashBoard()
        {
            if(HttpContext.Session.GetString("Uname")!=null)
            {
                ViewBag.uname = HttpContext.Session.GetString("Uname").ToString();
                //ViewBag.lldt = HttpContext.Session.GetString("lastLogin").ToString();
                if (Request.Cookies["lastLogin"] != null)
                    ViewBag.lldt = Request.Cookies["lastLogin"].ToString();
            }
            return View();
        }
        public ActionResult Logout()
        {
            Response.Cookies.Append("lastLogin", DateTime.Now.ToString());
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
        // GET: CookiesSessions/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CookiesSessions/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CookiesSessions/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CookiesSessions/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CookiesSessions/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CookiesSessions/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CookiesSessions/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}