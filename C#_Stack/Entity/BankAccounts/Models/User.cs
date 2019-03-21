using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BankAccounts.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}


        [Required(ErrorMessage="*Required")]
        [MinLength(2, ErrorMessage="Name must be at least 2 characters")]
        public string FirstName {get; set;}


        [Required(ErrorMessage="*Required")]
        [MinLength(2, ErrorMessage="Name must be at least 2 characters")]
        public string LastName {get; set;}


        [EmailAddress(ErrorMessage="Not a valid Email.")]
        [Required(ErrorMessage="*Required")]
        public string Email {get; set;}


        [DataType(DataType.Password)]
        [Required(ErrorMessage="*Required")]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters.")]
        public string Password {get;set;}


        public Decimal Balance {get;set;}
        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;


        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
    }
}