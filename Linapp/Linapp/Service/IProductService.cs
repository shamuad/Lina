using System.Collections.Generic;
using Linapp.Domain;
using MongoDB.Bson;

namespace Linapp.Service
{
    public interface IProductService
    {
        Product GetById(ObjectId id);
        IEnumerable<Product> GetByName(string name);
        void Insert(Product product);
        void Update(Product product);
        void DeleteByName(string productName);
    }
}
