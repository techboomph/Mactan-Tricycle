namespace Mactan.Tricycle.DAL.Abstracts
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using Mactan.Tricycle.DAL.Interfaces;

    public abstract class Entity<T> : IEntity<T>
    {
        public T Id { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        [Required]
        [MaxLength(64)]
        public string CreatedBy { get; set; } = "SYSTEM";
        public DateTime Updated { get; set; } = DateTime.Now;
        [Required]
        [MaxLength(64)]
        public string UpdatedBy { get; set; } = "SYSTEM";
    }
}