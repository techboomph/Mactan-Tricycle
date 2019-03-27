
namespace Mactan.Tricycle.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Mactan.Tricycle.DAL.Abstracts;

    public class AssetDriver : Entity<int>
    {
        public int AssetId { get;set; }
        public int DriverId {get;set;}
        public double Rental {get;set;}
        public double RentalConfig {get;set;}
        public int ContractMonth {get;set;}
        public DateTime DateStarted {get;set;}
        public DateTime DateFinishedActual {get;set;}
        public DateTime DateFinishedExpected {get;set;}
        [MaxLength(50)]
        public string ContractType {get;set;}
        public bool IsActive {get;set;}
        public virtual Driver Driver {get;set;}
        public virtual Asset Asset {get;set;}

        [InverseProperty("AssetDriver")]
        public virtual ICollection<Charge> Charges { get; set; } = new HashSet<Charge>();

    }
}