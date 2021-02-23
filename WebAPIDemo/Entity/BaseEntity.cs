using MongoDB.Bson.Serialization.Attributes;
using System;

namespace WebAPIDemo.Entity
{
    public abstract class BaseEntity
    {
        [BsonId] public Guid Id { get; set; }

    }
}
