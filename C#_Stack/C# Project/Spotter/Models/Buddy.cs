using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Spotter.Models
{
    public class Buddy
    {
        [Key]
        public int BuddyId {get;set;}


        public int RequesterId {get;set;}


        public int RequestedId {get;set;}


        public User Requester {get;set;}


        public User Requested {get;set;}

    }
}