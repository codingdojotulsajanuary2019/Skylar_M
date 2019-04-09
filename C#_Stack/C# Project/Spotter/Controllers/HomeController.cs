using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Spotter.Models;

namespace Spotter.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        // Login Page //

        [Route("")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [Route("Register")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // First Registration Page (User Table) //

        // Post First Registration Page Info //

        [HttpPost("RegisterUser")]
        public IActionResult RegisterUser(User user)
        {
            if(ModelState.IsValid)
            {
                if(dbContext.Users.Any(u => u.Email == user.Email))
                {
                    ModelState.AddModelError("User.Email", "Email already in use.");
                    return View("Index");
                }
                else
                {
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    user.Password = Hasher.HashPassword(user, user.Password);
                    dbContext.Add(user);
                    dbContext.SaveChanges();
                    int LoggedInUserId = user.UserId;
                    HttpContext.Session.SetInt32("LoggedInUserId", LoggedInUserId);
                    return RedirectToAction("Step2");
                } 
            }
            else
            {
                return View("Index");
            }
        }

        // Second Registration Page (Personal Details Table) //

        [HttpGet("Step2")]
        public IActionResult Step2()
        {
            int? LoggedInUserId = HttpContext.Session.GetInt32("LoggedInUserId");
                ViewModel ViewData = new ViewModel()
                {
                    User = dbContext.Users.FirstOrDefault(u => u.UserId == LoggedInUserId)
                };
            return View(ViewData);
        }
        
        // Post Second Registration Page Info //

        [HttpPost("RegisterDetails")]
        public IActionResult RegisterDetails(PersonalDetails pd)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(pd);
                dbContext.SaveChanges();
                return RedirectToAction("Step3");
            }
            else
            {
                int? LoggedInUserId = HttpContext.Session.GetInt32("LoggedInUserId");
                ViewModel ViewData = new ViewModel()
                {
                    User = dbContext.Users.FirstOrDefault(u => u.UserId == LoggedInUserId)
                };
                return View("Step2", ViewData);
            }
        }
        
        // Third Registration Page (Physical Traits Table) //
        
        [HttpGet("Step3")]
        public IActionResult Step3()
        {
            int? LoggedInUserId = HttpContext.Session.GetInt32("LoggedInUserId");
                ViewModel ViewData = new ViewModel()
                {
                    User = dbContext.Users.FirstOrDefault(u => u.UserId == LoggedInUserId)
                };
            return View(ViewData);
        }

        // Post Third Registration Page Info //

        [HttpPost("RegisterTraits")]
        public IActionResult RegisterTraits(PhysicalTraits pt)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(pt);
                dbContext.SaveChanges();
                return RedirectToAction("Main");
            }
            else
            {
                int? LoggedInUserId = HttpContext.Session.GetInt32("LoggedInUserId");
                ViewModel ViewData = new ViewModel()
                {
                    User = dbContext.Users.FirstOrDefault(u => u.UserId == LoggedInUserId)
                };
                return View("Step3", ViewData);
            }
        }

        // Login Page //

        [HttpPost("login")]
        public IActionResult Login(LoginUser LoginUser)
        {
            if(ModelState.IsValid)
            {
                User userInDb = dbContext.Users.FirstOrDefault(u => u.Email == LoginUser.Email);
                if(userInDb == null)
                {
                    ModelState.AddModelError("LoginUser.Email", "Invalid Email/Password");
                    return View("Index");
                }

                var hasher = new PasswordHasher<LoginUser>();
                var result = hasher.VerifyHashedPassword(LoginUser, userInDb.Password, LoginUser.Password);

                if(result == 0)
                {
                    ModelState.AddModelError("LoginUser.Email", "Invalid Email/Password");
                    return View("Index");
                }
                int LoggedInUserId = userInDb.UserId;
                HttpContext.Session.SetInt32("LoggedInUserId", LoggedInUserId);
                return RedirectToAction("Main");
            }
            else
            {
                return View("Index");
            }
        }
    }
    
}
