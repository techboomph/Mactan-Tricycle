namespace Mactan.Tricycle.DAL.Interfaces
{
    using System;
    using System.ComponentModel.DataAnnotations;

    public interface IEntity
    {

        [Timestamp]
        byte[] RowVersion { get; set; }

        DateTime Created { get; set; }
        string CreatedBy { get; set; }
        DateTime Updated { get; set; }
        string UpdatedBy { get; set; }
    }
    public interface IEntity<T> : IEntity
    {
        T Id { get; set; }
    }
}