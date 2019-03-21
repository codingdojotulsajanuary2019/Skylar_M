using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;
using BankAccounts.Models;

namespace BankAccounts.Models
{
public class ViewModel
    {
        public List<Transaction> DisplayTrans {get;set;}
        public List<User> DisplayUsers {get;set;}

        public User User {get;set;}

        public LoginUser LoginUser {get;set;}
        public Transaction Transaction {get;set;}

        public int LoggedInUserId {get;set;}
    }
}