using MongoDB.Bson;
using System.Collections.Generic;

namespace Linapp.Repository
{
    public interface IProductRepository
    {
        ProductDocument GetById(ObjectId Id);
        IEnumerable<ProductDocument> GetByCategory(string category);
        IEnumerable<ProductDocument> GetByName(string name);
        void Insert(ProductDocument productDocument);
        void Update(ProductDocument productDocument);
        void DeleteByName(string productName);
    }
}