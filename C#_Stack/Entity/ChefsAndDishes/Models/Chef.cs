using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using ChefsAndDishes.Models;

namespace ChefsAndDishes.Models
{
    public class MustBe18Attribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            Chef chef = (Chef)validationContext.ObjectInstance;
            DateTime Over18 = DateTime.Today.AddYears(-18);
            if (chef.DOB <= Over18)
            {
                return ValidationResult.Success;
            }
            else
            {
                return new ValidationResult("Must be at least 18 years of age.");
            }
        }
    }
    public class Chef
    {
        [Key]
        public int ChefId {get;set;}


        [Required(ErrorMessage="*Required")]
        [MinLength(2, ErrorMessage="Name must be at least 2 characters")]
        public string FirstName {get; set;}


        [Required(ErrorMessage="*Required")]
        [MinLength(2, ErrorMessage="Name must be at least 2 characters")]
        public string LastName {get; set;}

        [Required(ErrorMessage="*Required")]
        [MustBe18]
        public DateTime DOB {get;set;}


        public List<Dish> CreatedDishes {get;set;}

    }
}