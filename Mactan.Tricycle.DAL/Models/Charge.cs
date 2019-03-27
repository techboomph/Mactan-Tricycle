
namespace Mactan.Tricycle.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Mactan.Tricycle.DAL.Abstracts;

    public class Charge : Entity<int>
    {
        public int ChargeTypeId { get;set; }
        public double ChargeAmount {get;set;}
        public DateTime ChargeDate {get;set;}
        public int DriverId {get;set;}
        public int AssetDriverId {get;set;}
        public bool IsDeleted {get;set;}
        public int TransactionTypeId {get;set;}
        public virtual Driver Driver {get;set;}
        public virtual AssetDriver AssetDriver {get;set;}
        public virtual ChargeType ChargeType {get;set;}
        public virtual TransactionType TransactionType {get;set;}

        [InverseProperty("Charge")]
        public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new HashSet<PaymentTransaction>();

    }
}