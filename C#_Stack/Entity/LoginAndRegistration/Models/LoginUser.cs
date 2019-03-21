using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace LoginAndRegistration.Models
{
    public class LoginUser
    {
        [NotMapped]
        [EmailAddress]
        [Required]
        public string Email {get; set;}

        [NotMapped]
        [DataType(DataType.Password)]
        [Required]
        public string Password {get;set;}
    }
}