using System;
using System.Collections.Generic;
using System.Linq;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Linapp.Repository
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMongoCollection<ProductDocument> collection;


        public ProductRepository()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            var database = client.GetDatabase("product");
            collection = database.GetCollection<ProductDocument>("products");
        }

        public void DeleteByName(string productname)
        {
            var filter = Builders<ProductDocument>.Filter.Eq(p => p.Name, productname);
            collection.DeleteMany(filter);
        }

        public ProductDocument GetById(ObjectId Id)
        {
            return collection.Find(p => p.Id == Id).ToList().First();
        }

        public IEnumerable<ProductDocument> GetByName(string name)
        {
            return collection.Find(p => p.Name == name).ToList();
        }

        public void Insert(ProductDocument productDocument)
        {
            collection.InsertOne(productDocument);
        }

        public void Update(ProductDocument productDocument)
        {
            var filter = Builders<ProductDocument>.Filter.Eq(p => p.Id, productDocument.Id);
            collection.DeleteMany(filter);
        }
    }
}
