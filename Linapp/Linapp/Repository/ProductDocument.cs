using Linapp.Domain;
using MongoDB.Bson;
using System;

namespace Linapp.Repository
{
    public class ProductDocument
    {
        public ObjectId Id { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime PDate { get; set; }
    }
}
