using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using BankAccounts.Models;
using Microsoft.AspNetCore.Identity;

namespace LoginAndRegistration.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("register")]
        public IActionResult Register(User user)
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
                    return RedirectToAction("Account");
                } 
            }
            else
            {
                return View("Index");
            }
        }

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
                return RedirectToAction("Account");
            }
            else
            {
                return View("Index");
            }
        }


        [HttpGet("Account")]
        public IActionResult Account()
        {
                int? LoggedInUserId = HttpContext.Session.GetInt32("LoggedInUserId");
                ViewModel AccountPage = new ViewModel()
                {
                    User = dbContext.Users.FirstOrDefault(u => u.UserId == LoggedInUserId),
                    DisplayTrans = dbContext.Transactions.ToList()
                };
                return View(AccountPage);
        }

        [HttpPost("Account")]
        public IActionResult DWAccount(Transaction trans)
        {
            dbContext.Add(trans);
            dbContext.SaveChanges();
            return RedirectToAction("Account");
        }


        [HttpGet("logout")]
        public IActionResult Logout()
        {
            return RedirectToAction("Index");
        }
    }
}