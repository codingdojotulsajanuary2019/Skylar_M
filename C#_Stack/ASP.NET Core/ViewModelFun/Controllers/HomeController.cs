using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            string[] names = new string[]{
                "Sally", "Billy", "Joey", "Moose"
            };
            return View(names);
        }

        [HttpGet("numbers")]
        public IActionResult Numbers()
        {
            int[] numbers = new int[]{
                1, 2, 3, 420, 5, 69
            };
            return View(numbers);
        }
        
        [HttpGet("user")]
        public IActionResult User1()
        {
            User user = new User(){
                FirstName = "Skylar",
                LastName = "Macias"
            };

            return View(user);
        }
        
        [HttpGet("users")]
        public IActionResult Users()
        {
            User user2 = new User(){
                FirstName = "Samuel",
                LastName = "Jackson"
            };
            User user3 = new User(){
                FirstName = "Tom",
                LastName = "Cruise"
            };
            User user4 = new User(){
                FirstName = "Kanye",
                LastName = "West"
            };
            List<User> UList = new List<User>(){
                user2, user3, user4
            };

            return View(UList);
        }
    }
}
