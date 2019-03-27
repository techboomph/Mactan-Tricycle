
namespace Mactan.Tricycle.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Mactan.Tricycle.DAL.Abstracts;

    public class ChargeType : Entity<int>
    {
        [MaxLength(100)]
        public string Name { get; set; }

        [InverseProperty("ChargeType")]
        public virtual ICollection<Charge> Charges { get; set; } = new HashSet<Charge>();
       
    }
}