using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using ChefsAndDishes.Models;

namespace ChefsAndDishes.Models
{
    public class MustBePositive : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Dish Dish = (Dish)validationContext.ObjectInstance;
            if (Dish.Calories >= 0)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Calories must be a positive number.");
            }
        }
    }
    public class Dish
    {
        [Key]
        public int DishId {get;set;}


        [Required(ErrorMessage="*Required")]
        public string Name {get;set;}

        public int Tastiness {get;set;}

        [MustBePositive]
        [Required(ErrorMessage="*Required")]
        public int Calories  {get;set;}

        public int ChefId {get;set;}

        public Chef Creator {get;set;}



    }
}