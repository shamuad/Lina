using Linapp.Repository;
using MongoDB.Bson;
using System;

namespace Linapp.Domain
{
    public class Product
    {
        public ObjectId Id { get; private set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime PDate { get; set; }

        public Product(Category category, string name, string description, decimal price, DateTime productdate)
        {

            Id = ObjectId.GenerateNewId();
            Category = category;
            Name = name;
            Description = description;
            Price = price;
            PDate = productdate;
        }

        public Product()
        {
        }

        public Product Load(ProductDocument document)
        {
            Id = document.Id;
            Category = document.Category;
            Name = document.Name;
            Description = document.Description;
            Price = document.Price;
            PDate = document.PDate;

            return this;
        }

        public ProductDocument ToDocument()
        {
            var productDocument = new ProductDocument();

            productDocument.Id = this.Id;
            productDocument.Category = this.Category;
            productDocument.Name = this.Name;
            productDocument.Description = this.Description;
            productDocument.Price = this.Price;
            productDocument.PDate = this.PDate;

            return productDocument;
        }
    }
}
