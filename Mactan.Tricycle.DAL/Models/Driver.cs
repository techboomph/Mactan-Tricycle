
namespace Mactan.Tricycle.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Mactan.Tricycle.DAL.Abstracts;

    public class Driver : Entity<int>
    {
        [MaxLength(50)]
        public string DriversLicense { get;set; }
        [MaxLength(50)]
        public string FirstName {get;set;}
        [MaxLength(50)]
        public string LastName {get;set;}
        [MaxLength(50)]
        public string MiddleName {get;set;}
        public DateTime DriverLicenseExpiry {get;set;}
        public DateTime DateOfBirth {get;set;}
        [MaxLength(10)]
        public string MaritalStatus {get;set;}
        [MaxLength(20)]
        public string ContactNo {get;set;}
        [MaxLength(50)]
        public string FacebookAccount {get;set;}
        [MaxLength(200)]
        public string Address {get;set;}
        public bool IsActive {get;set;}

        [InverseProperty("Driver")]
        public virtual ICollection<AssetDriver> AssetDrivers { get; set; } = new HashSet<AssetDriver>();

        [InverseProperty("Driver")]
        public virtual ICollection<Charge> Charges { get; set; } = new HashSet<Charge>();

    }
}