using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using login_and_registration.Models;
using Microsoft.AspNetCore.Http;

namespace login_and_registration.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.Clear();
            return View();
        }
        [Route("/success")]
        public IActionResult Success()
        {
            ViewBag.activeUser = HttpContext.Session.GetString("activeUser");
            return View("Success");
        }
        [HttpPost]
        [Route("/user/register")]
        public IActionResult Register(string first_name, string last_name, string email, string password, string confirm_password)
        {
            User NewUser = new User
            {
                First_name = first_name,
                Last_name = last_name,
                Email = email,
                Password = password,
                Confirm_password = confirm_password
            };
            TryValidateModel(NewUser);
            if (ModelState.IsValid)
            {
                HttpContext.Session.SetString("activeUser", (string)NewUser.First_name);
                return RedirectToAction("Success");
            } else {
                return View("Index");
            }
        }
    }
}
