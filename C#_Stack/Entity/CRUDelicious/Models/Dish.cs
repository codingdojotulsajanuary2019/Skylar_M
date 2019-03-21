using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace CRUDelicious.Models
{
    public class Dish
    {
        [Key]
        public int Id {get;set;}


        [Required(ErrorMessage="*Required")]
        [MinLength(3, ErrorMessage="Dish name must be at least 3 characters.")]
        public string Name {get;set;}


        [Required(ErrorMessage="*Required")]
        [MinLength(3, ErrorMessage="Creator name must be at least 3 characters.")]
        public string Chef {get;set;}
        public int Tastiness {get;set;}


        [Required(ErrorMessage="*Required")]
        public int Calories {get;set;}


        [Required(ErrorMessage="*Required")]
        [MinLength(20, ErrorMessage="Please enter a more detailed description.")]
        public string Decsription {get;set;}
        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
    public class DishBag
    {
        public List<Dish> DisplayDishes {get;set;}
    }
}