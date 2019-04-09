using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace Spotter.Models
{
    public class Message
    {
        [Key]
        public int MessageId {get;set;}

        
        public int ReceiverId {get;set;}

        
        public int SenderId {get;set;}


        public string Content {get;set;}


        public DateTime CreatedAt {get;set;} = DateTime.Now;


        public User Receiver {get;set;}

        public User Sender {get;set;}
        
    }
}