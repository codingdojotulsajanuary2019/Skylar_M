using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Spotter.Models
{
    public class ViewModel
    {
        public User User {get;set;}

        public LoginUser LoginUser {get;set;}

        public Message Message {get;set;}

        public PersonalDetails PersonalDetails {get;set;}

        public PhysicalTraits PhysicalTraits {get;set;}

    }
}