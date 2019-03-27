
namespace Mactan.Tricycle.DAL.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using Mactan.Tricycle.DAL.Abstracts;

    public class AuditHistory : Entity<int>
    {
        [MaxLength(50)]
        public string TableName { get;set; }
        [MaxLength(50)]
        public string ColumnName {get;set;}
        [MaxLength(200)]
        public string OldValue {get;set;}
        [MaxLength(200)]
        public string NewValue {get;set;}
        public int MTUserId {get;set;}
        public DateTime AuditHistoryTime {get;set;} = DateTime.Now;
        public virtual MTUser MTUSer {get;set;}

    }
}