
namespace Mactan.Tricycle.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Mactan.Tricycle.DAL.Abstracts;

    public class TransactionType : Entity<int>
    {
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(10)]
        public string Code { get; set; }

        [InverseProperty("TransactionType")]
        public virtual ICollection<Charge> Charges { get; set; } = new HashSet<Charge>();

        [InverseProperty("TransactionType")]
        public virtual ICollection<PaymentTransaction> PaymentTransactions { get; set; } = new HashSet<PaymentTransaction>();
       
    }
}