using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Spotter.Models
{
    public class PersonalDetails
    {
        [Key]
        public int PersonalDetailsId {get;set;}

        public int UserId {get;set;}

        [Required(ErrorMessage="*Required")]
        [MinLength(2, ErrorMessage="Name must be at least 2 characters")]
        public string FirstName {get; set;}
        
        

        [Required(ErrorMessage="*Required")]
        [MinLength(2, ErrorMessage="Name must be at least 2 characters")]
        public string LastName {get; set;}



        [Required(ErrorMessage="*Required")]
        public string City {get;set;}



        [Required(ErrorMessage="*Required")]
        public string State {get;set;}



        [Required(ErrorMessage="*Required")]
        public string Gym {get;set;}
    }
}