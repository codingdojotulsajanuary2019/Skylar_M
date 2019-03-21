using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace BankAccounts.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId {get;set;}

        public decimal Amount {get;set;}


        public DateTime CreatedAt {get; set;} = DateTime.Now;


        public int UserId {get;set;}


        public User AccountOwner {get;set;}
    }
}