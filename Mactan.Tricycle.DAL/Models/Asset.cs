
namespace Mactan.Tricycle.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Mactan.Tricycle.DAL.Abstracts;

    public class Asset : Entity<int>
    {
        public string FranchiseKey { get; set; }
        public double? AssetCost { get; set; }
        public DateTime FranchiseRenewalDate {get;set;}
        public string AssetConfiguration {get;set;}
        public string LLCSPNo {get;set;}
        [MaxLength(10)]
        public string VehicleCode {get;set;}
        [MaxLength(50)]
        public string EngineNo {get;set;}
        [MaxLength(100)]
        public string ChassisNo {get;set;}
        public DateTime? VehicleRenewalDate {get;set;}
        [MaxLength(100)]
        public string Manufacturer {get;set;}
        public DateTime PurchaseDate {get;set;}
        [MaxLength(20)]
        public string ORCRNo {get;set;}
        [MaxLength(150)]
        public string AssetType {get;set;}
        public int OwnerOrganizationId {get;set;}
        public int AssetPartId {get;set;}
        public bool IsActive {get;set;}
        public virtual OwnerOrganization OwnerOrganization {get;set;}

        public virtual Asset AssetPart {get;set;}

        [InverseProperty("AssetPart")]
        public virtual ICollection<Asset> Assets { get; set; } = new HashSet<Asset>();

        [InverseProperty("Asset")]
        public virtual ICollection<AssetDriver> AssetDrivers { get; set; } = new HashSet<AssetDriver>();

        

    }
}