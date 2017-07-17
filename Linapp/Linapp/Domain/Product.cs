using Linapp.Repository;
using MongoDB.Bson;
using System;

namespace Linapp.Domain
{
    public class Product
    {
        public ObjectId productId{ get; private set; } 
        public string productCategory { get; set; }
        public string ProductName { get; set; }
        public string productDescription { get; set;}
        public decimal productPrice { get; set; }
        public DateTime productDate { get; set; }

        public Product(string category, string name,string description, decimal price, DateTime productdate)
        {

            productId = ObjectId.GenerateNewId();
            productCategory = category;
            ProductName = name;
            productDescription = description;
            productPrice = price;
            productDate = productdate;
        }

        public Product()
        {
        }

        public Product Load(ProductDocument document)
        {
            productId = document.productId;
            productCategory = document.productCategory;
            ProductName = document.ProductName;
            productDescription = document.productDescription;
            productPrice = document.productPrice;
            productDate = document.productDate;

            return this;
        }

        public ProductDocument ToDocument()
        {
            var productDocument = new ProductDocument();

            productDocument.productId = this.productId;
            productDocument.productCategory = this.productCategory;
            productDocument.ProductName = this.ProductName;
            productDocument.productDescription = this.productDescription;
            productDocument.productPrice = this.productPrice;
            productDocument.productDate = this.productDate;

            return productDocument;
        }
    }
}
