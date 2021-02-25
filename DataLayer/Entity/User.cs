using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;

namespace DataLayer.Entity
{
    public class User : BaseEntity
    {
        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonElement("email")]
        [Required]
        public string Email { get; set; }

        [BsonElement("username")]
        [Required]
        public string Username { get; set; }
        
        [BsonElement("createdAt")]
        public DateTime CreatedAt { get; set; }
    }
}
