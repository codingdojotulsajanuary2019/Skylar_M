using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ChefsAndDishes.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ChefsAndDishes.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
        public HomeController(MyContext context)
        {
            dbContext = context;
        }


        [HttpGet("")]
        public IActionResult Index()
        {
            ViewModel DisplayChefs = new ViewModel()
            {
                DisplayChefs = dbContext.Chefs.Include(chefs => chefs.CreatedDishes).ToList()
            };
            return View(DisplayChefs);
        }
        
        
        [HttpGet("dishes")]
        public IActionResult Dishes()
        {
            ViewModel DisplayDishes = new ViewModel()
            {
                DisplayDishes = dbContext.Dishes.Include(dishes => dishes.Creator).ToList()
            };
            return View(DisplayDishes);
        }
        
        
        [HttpGet("new_chef")]
        public IActionResult NewChef()
        {
            return View();
        }
        
        
        [HttpPost("create_chef")]
        public IActionResult CreateChef(Chef chef)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(chef);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View("NewChef");
            }
        }
        
        
        [HttpGet("new_dish")]
        public IActionResult NewDish()
        {
            ViewModel DisplayChefs = new ViewModel()
            {
                DisplayChefs = dbContext.Chefs.ToList()
            };
            return View(DisplayChefs);
        }
        
        
        [HttpPost("create_dish")]
        public IActionResult CreateDish(Dish dish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(dish);
                dbContext.SaveChanges();
                return RedirectToAction("Dishes");
            }
            else
            {   
                ViewModel DisplayChefs = new ViewModel()
                {
                    DisplayChefs = dbContext.Chefs.ToList()
                };
                return View("NewDish", DisplayChefs);
            }
        }
    }
}
