using Linapp.Repository;
using System;
using System.Collections.Generic;
using Linapp.Domain;
using MongoDB.Bson;
using System.Linq;

namespace Linapp.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repository;
        private List<Product> productList;

        public ProductService(IProductRepository repository)
        {
            this.repository = repository;
        }

        public void DeleteByName(string productName)
        {
            repository.DeleteByName(productName);
        }

        public Product GetById(ObjectId id)
        {
            return new Product().Load(repository.GetById(id));
        }

        public IEnumerable<Product> GetByName(string name)
        {
            productList = new List<Product>();
            foreach (var item in repository.GetByName(name))
            {
                var product = new Product();
                productList.Add(product.Load(item));
            }
            return productList;
        }

        public void Insert(Product product)
        {
            EnsureProductNameIsNotUsed(product);
            repository.Insert(product.ToDocument());
        }

        public void EnsureProductNameIsNotUsed(Product product)
        {
            var productFetched = repository.GetByName(product.Name);
            if (productFetched.Any())
            {
                throw new Exception();
            }
        }

        public void Update(Product product)
        {
            repository.Update(product.ToDocument());
        }
    }
}
