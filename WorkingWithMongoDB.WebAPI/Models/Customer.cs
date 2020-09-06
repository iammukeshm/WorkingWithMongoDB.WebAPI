using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithMongoDB.WebAPI.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [BsonElement("PhoneNumber")]
        public string Contact { get; set; }
        public string Email { get; set; }
    }
}
