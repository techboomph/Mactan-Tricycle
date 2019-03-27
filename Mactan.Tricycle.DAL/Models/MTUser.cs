
namespace Mactan.Tricycle.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Mactan.Tricycle.DAL.Abstracts;

    public class MTUser : Entity<int>
    {
        [MaxLength(20)]
        public string Username { get;set; }
        [MaxLength(200)]
        public string Password {get;set;}
        [MaxLength(50)]
        public string FirstName {get;set;}
        [MaxLength(50)]
        public string LastName {get;set;}
        [MaxLength(50)]
        public string MiddleName {get;set;}
        [MaxLength(200)]
        public string Address {get;set;}
        [MaxLength(20)]
        public string ContactNo {get;set;}
        [MaxLength(100)]
        public string Email {get;set;}
        public bool IsActive {get;set;}

        [InverseProperty("MTUser")]
        public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new HashSet<PaymentTransaction>();
        [InverseProperty("MTUser")]
        public virtual ICollection<AuditHistory> AuditHistories { get; set; } = new HashSet<AuditHistory>();

        
    
    }
}