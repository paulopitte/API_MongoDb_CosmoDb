
namespace API_MongoDb_CosmoDb.Services
{
    using Domain.Entities;
    using Repository.Interfaces;
    using System;
    using System.Linq;

    public interface IProductServices
    {
        IQueryable<Product> QueryAll();

        Product Query(Guid key);
        void Insert(Product product);
    }



    public class ProductServices : IProductServices
    {
        private readonly IRepository<Product> _productRepository;

        public ProductServices(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public IQueryable<Product> QueryAll()
        {
            var result = _productRepository.QueryAll();

            return result;
        }

        public Product Query(Guid key)
        {
            var result = _productRepository.Query(key);

            return result;
        }

        public void Insert(Product product)
        {
            _productRepository.Insert(product);
        }
    }
}
