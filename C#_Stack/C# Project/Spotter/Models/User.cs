using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Spotter.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}



        [EmailAddress(ErrorMessage="Not a valid Email.")]
        [Required(ErrorMessage="*Required")]
        public string Email {get; set;}


        [DataType(DataType.Password)]
        [Required(ErrorMessage="*Required")]
        [MinLength(8, ErrorMessage="Password must be at least 8 characters.")]
        public string Password {get;set;}


        public DateTime CreatedAt {get; set;} = DateTime.Now;
        public DateTime UpdatedAt {get; set;} = DateTime.Now;


        /* public int PersonalDetailsId {get;set;}

        public int PhysicalTraitsId {get;set;}


        public PersonalDetails PersonalDetails {get;set;}

        public PhysicalTraits PhysicalTraits {get;set;} */
        

        public List<Buddy> Buddies {get;set;}
        

        [InverseProperty("Sender")]
        public List<Message> Received {get;set;}
        
        
        [InverseProperty("Receiver")]
        public List<Message> Sent {get;set;}
        
        
        
        [InverseProperty("Requested")]
        public List<Buddy> Requesters {get;set;}
        
        
        [InverseProperty("Requester")]
        public List<Buddy> Requested {get;set;}


        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}
    }
}