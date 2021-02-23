using MongoDB.Bson.Serialization.Attributes;
using System;

namespace WebAPIDemo.Entity
{
    public class BaseEntity
    {
        [BsonId] public Guid Id { get; }

    }
}
