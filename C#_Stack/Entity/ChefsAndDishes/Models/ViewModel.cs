using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using ChefsAndDishes.Models;

namespace ChefsAndDishes.Models
{
public class ViewModel
    {
        public List<Chef> DisplayChefs {get;set;}

        public List<Dish> DisplayDishes {get;set;}

        public Dish dish {get;set;}
    }
}