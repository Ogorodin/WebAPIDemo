using MongoDB.Bson.Serialization.Attributes;
using System;

namespace DataLayer.Entity
{
    public abstract class BaseEntity
    {
        [BsonId] public Guid Id { get; set; }

    }
}
