
namespace Mactan.Tricycle.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Mactan.Tricycle.DAL.Abstracts;

    public class SystemConfig : Entity<int>
    {
        [MaxLength(50)]
        public string Key { get; set; }
        [MaxLength(100)]
        public string Value { get; set; }
       
    }
}