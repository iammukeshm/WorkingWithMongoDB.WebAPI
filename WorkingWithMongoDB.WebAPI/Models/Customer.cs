using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingWithMongoDB.WebAPI.Models
{
    public class Customer
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [Required(ErrorMessage = "First name is required")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [BsonElement("PhoneNumber")]
        public string Contact { get; set; }
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
    }
}
