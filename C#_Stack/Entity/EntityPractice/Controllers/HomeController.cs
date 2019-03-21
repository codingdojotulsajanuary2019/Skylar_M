using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EntityPractice.Models;

namespace EntityPractice.Controllers
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
            List<User> AllUsers = dbContext.Users.ToList();
            List<User> Jeffersons = dbContext.Users.Where(u => u.LastName == "Jefferson").ToList();
            List<User> MostRecent = dbContext.Users.OrderByDescending(u => u.CreatedAt).Take(5).ToList();
            return View();
        }
        public IActionResult GetOneUser(string Email)
        {
            User oneUser = dbContext.Users.FirstOrDefault(user => user.Email == Email);
            return View();
        }
        [HttpPost("create")]
        public IActionResult CreateUser(User newUser)
        {
            dbContext.Add(newUser);
            dbContext.SaveChanges();
            return View("Index");
        }
        [HttpGet("update/{userId}")]
        public IActionResult UpdateUser(int userId)
        {
            User RetrievedUser = dbContext.Users.FirstOrDefault(user => user.UserId == userId);
            RetrievedUser.FirstName = "New first name";
            RetrievedUser.LastName = "New last name";
            RetrievedUser.Email = "New email";
            RetrievedUser.UpdatedAt = DateTime.Now;
            dbContext.SaveChanges();
            return View("Index");
        }
        [HttpGet("delete/{userId}")]
        public IActionResult DeleteUser(int userId)
        {
            User RetrievedUser = dbContext.Users.SingleOrDefault(user => user.UserId == userId);
            dbContext.Users.Remove(RetrievedUser);
            dbContext.SaveChanges();
            return View("Index");
        }

    }
}
