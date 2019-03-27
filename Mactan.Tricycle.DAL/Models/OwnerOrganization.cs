
namespace Mactan.Tricycle.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Mactan.Tricycle.DAL.Abstracts;

    public class OwnerOrganization : Entity<int>
    {
        [MaxLength(100)]
        public string OwnerOrganizationName { get;set; }
        [MaxLength(50)]
        public string RepresentFirstName {get;set;}
        [MaxLength(50)]
        public string RepresentLastName {get;set;}
        [MaxLength(50)]
        public string RepresentMiddleName {get;set;}
        [MaxLength(20)]
        public string RepresentContactNo {get;set;}
        [MaxLength(200)]
        public string RepresentAddress {get;set;}

        [InverseProperty("OwnerOrganization")]
        public virtual ICollection<Asset> Assets { get; set; } = new HashSet<Asset>();

    }
}