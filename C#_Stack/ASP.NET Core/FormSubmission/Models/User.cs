using System;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    {
        [Required(ErrorMessage="*Required")]
        [MinLength(2, ErrorMessage="Name must be longer than 2 characters.")]
        public string FirstName {get;set;}


        [Required(ErrorMessage="*Required")]
        [MinLength(2, ErrorMessage="Name must be longer than 2 characters.")]
        public string LastName {get;set;}


        [Required(ErrorMessage="*Required")]
        public int Age {get;set;}


        [Required(ErrorMessage="*Required")]
        [DataType(DataType.EmailAddress)]
        public string Email {get;set;}


        [Required(ErrorMessage="*Required")]
        [DataType(DataType.Password)]
        public string Password {get;set;}
    }
}