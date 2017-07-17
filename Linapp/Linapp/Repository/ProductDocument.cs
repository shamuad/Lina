using MongoDB.Bson;
using System;

namespace Linapp.Repository
{
    public class ProductDocument
    {
        public ObjectId productId { get; set; }
        public string productCategory { get; set; }
        public string ProductName { get; set; }
        public string productDescription { get; set; }
        public decimal productPrice { get; set; }
        public DateTime productDate { get; set; }
    }
}
