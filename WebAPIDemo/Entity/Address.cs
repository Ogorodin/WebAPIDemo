using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIDemo.Entity
{
    public class Address : BaseEntity
    {
        [BsonElement("street")]
        public string Street { get; set; }
        [BsonElement("number")]
        public int Number { get; set; }
        [BsonElement("city")]
        public string City { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}\nStreet: {Street}\nNumber: {Number}\nCity: {City}";
        }
    }
}
