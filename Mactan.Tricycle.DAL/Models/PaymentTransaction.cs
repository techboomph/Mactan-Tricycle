
namespace Mactan.Tricycle.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Mactan.Tricycle.DAL.Abstracts;

    public class PaymentTransaction : Entity<int>
    {
        public double Amount {get;set;}
        public DateTime TransactionDate {get;set;}
        public int MTUserId {get;set;}
        public int ChargeId {get;set;}
        public bool IsDeleted {get;set;}
        public int TransactionTypeId {get;set;}
        public virtual Charge Charge {get;set;}
        public virtual MTUser MTUser {get;set;}
        public virtual TransactionType TransactionType {get;set;}
    }
}