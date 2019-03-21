using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CRUDelicious.Models;

namespace CRUDelicious.Controllers
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
            DishBag DisplayDishes = new DishBag()
            {
                DisplayDishes = dbContext.Dishes.ToList()
            };
            Console.WriteLine(DisplayDishes);
            return View("Index", DisplayDishes);
        }
        
        
        
        
        
        [HttpGet("new/dish")]
        public IActionResult New()
        {
            return View();
        }
        
        
        [HttpPost("new/dish/create")]
        public IActionResult Create(Dish dish)
        {
            if(ModelState.IsValid)
            {
                dbContext.Add(dish);
                dbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("New");
            }
        }
        [HttpGet("{dishId}")]
        public IActionResult Dish(int dishId)
        {
            Dish SingleDish = dbContext.Dishes.FirstOrDefault(d => d.Id == dishId);
            return View("Dish", SingleDish);
        }

        [HttpGet("{dishId}/edit")]
        public IActionResult Edit(int dishId)
        {
            Dish SingleDish = dbContext.Dishes.FirstOrDefault(d => d.Id == dishId);
            return View(SingleDish);
        }

        [HttpPost("{dishId}/update")]
        public IActionResult Update(int dishId, Dish newDish)
        {
            if(ModelState.IsValid){
                Dish SingleDish = dbContext.Dishes.FirstOrDefault(d => d.Id == dishId);
                SingleDish.Name = newDish.Name;
                SingleDish.Chef = newDish.Chef;
                SingleDish.Tastiness = newDish.Tastiness;
                SingleDish.Calories = newDish.Calories;
                SingleDish.Decsription = newDish.Decsription;
                SingleDish.UpdatedAt = DateTime.Now;
                return View("Dish", SingleDish);
            }
            else
            {
                Dish SingleDish = dbContext.Dishes.FirstOrDefault(d => d.Id == dishId);
                return View("Edit", SingleDish);
            }
        }

        [HttpGet("{dishId}/delete")]
        public IActionResult Delete(int dishId)
        {
            Dish SingleDish = dbContext.Dishes.FirstOrDefault(d => d.Id == dishId);
            dbContext.Dishes.Remove(SingleDish);
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
